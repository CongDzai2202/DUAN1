using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;
using _2_BUS_BusinessLayer.BUS_Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_NhanVien : Form
    {
        private ISevicesQLNhanVien _iQLNV;
        int _id;
        private MaHoaMK maHoaMK;
        public Frm_NhanVien()
        {
            _iQLNV = new ServiceQLNhanVien();
            maHoaMK = new MaHoaMK();
            InitializeComponent();
            _iQLNV.GetDataFromDB();
            loadCbx();
            LoadGrid();
        }
        void loadCbx()
        {
            foreach (var x in _iQLNV.GetLstChucVu())
            {
                cbx_ChucVu.Items.Add(x.TenChucVu);
            }
            cbx_ChucVu.SelectedIndex = 0;
            foreach (var x in getYearOfBirth())
            {
                cbx_NamSinh.Items.Add(x.Trim());
            }
          
        }
        public string[] getYearOfBirth()
        {
            string[] arrYears = new string[2021 - 1900];
            int temp = 1900;
            for (int i = 0; i < arrYears.Length; i++)
            {
                arrYears[i] = temp.ToString();
                temp++;
            }

            return arrYears;
        }
        /// <summary>
        /// 
        /// </summary>
        private void LoadGrid()
        {
            dtgrid_NhanVien.ColumnCount = 8;
            dtgrid_NhanVien.Columns[0].Name = "Tên nhân viên";
            dtgrid_NhanVien.Columns[1].Name = "Số CMND";
            dtgrid_NhanVien.Columns[2].Name = "Năm sinh";
            dtgrid_NhanVien.Columns[3].Name = "Số điện thoại";
            dtgrid_NhanVien.Columns[4].Name = "Trạng thái";
            dtgrid_NhanVien.Columns[5].Name = "Địa chỉ";
            dtgrid_NhanVien.Columns[6].Name = "Chức vụ";
            dtgrid_NhanVien.Columns[7].Name = "ID";
            dtgrid_NhanVien.Columns[7].Visible = false;
            dtgrid_NhanVien.Rows.Clear();
            foreach (var x in _iQLNV.GetLstNhanVien())
            {
                foreach (var y in _iQLNV.GetLstChucVu().Where(c=>c.MaChucVu==x.MaChucVu))
                {
                    dtgrid_NhanVien.Rows.Add(x.TenNhanVien, x.SoCmnd, x.NamSinh, x.SoDienThoai, x.TrangThai == 1 ? "Hoạt động" : "Ngừng hoạt động", x.DiaChi, y.TenChucVu,x.Id);
                }
              
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

                DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    if (txb_TenNhanVien.Text == "" || txb_MatKhau.Text == "" || txb_CMND.Text == "" || txb_SDTNV.Text == "" || txb_DiaChi.Text == "")
                    {
                        DialogResult dm = MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (_iQLNV.GetLstNhanVien().Any(c => c.SoCmnd == txb_CMND.Text))

                    {
                        DialogResult dm = MessageBox.Show("Số chứng minh nhân dân đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (_iQLNV.GetLstNhanVien().Any(c => c.SoDienThoai == txb_SDTNV.Text))

                    {
                        DialogResult dm = MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.Id = _iQLNV.GetLstNhanVien().Max(c => c.Id) + 1;
                        nv.MaNhanVien = "NV" + nv.Id;
                        nv.TenNhanVien = txb_TenNhanVien.Text;
                        nv.SoCmnd = txb_CMND.Text;
                        nv.NamSinh = Convert.ToInt32(cbx_NamSinh.Text);
                        nv.SoDienThoai = txb_SDTNV.Text;
                        nv.MatKhau = maHoaMK.MaHoaMk(txb_MatKhau.Text);
                        if (rbt_HoatDong.Checked = true)
                        {
                            nv.TrangThai = 1;
                        }
                        else
                        {
                            nv.TrangThai = 0;
                        }
                        nv.DiaChi = txb_DiaChi.Text;
                        nv.MaChucVu = _iQLNV.GetLstChucVu().Where(c => c.TenChucVu == cbx_ChucVu.Text).Select(c => c.MaChucVu).FirstOrDefault();
                        MessageBox.Show(_iQLNV.ThemNV(nv));
                    _iQLNV.GetDataFromDB();
                        LoadGrid();
                    }
                }
            
         
        }

        private void dtgrid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            if (rowindex >= _iQLNV.GetLstNhanVien().Count) return;
            _id = Convert.ToInt32(dtgrid_NhanVien.Rows[rowindex].Cells[7].Value);
            NhanVien nv = _iQLNV.GetLstNhanVien().Where(c => c.Id == _id).FirstOrDefault();
            txb_TenNhanVien.Text = nv.TenNhanVien;
            txb_CMND.Text = nv.SoCmnd;
            cbx_NamSinh.Text = Convert.ToString(nv.NamSinh);
            txb_SDTNV.Text = nv.SoDienThoai;
            txb_MatKhau.Text = nv.MatKhau;
            rbt_HoatDong.Checked = nv.TrangThai == 1 ? true : false;
            rbt_KhongHĐ.Checked = nv.TrangThai == 0 ? true : false;
            txb_DiaChi.Text = nv.DiaChi;
            cbx_ChucVu.Text = _iQLNV.GetLstChucVu().Where(c => c.MaChucVu == nv.MaChucVu).Select(c => c.TenChucVu).FirstOrDefault();

            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                   
                   
                        NhanVien nv = _iQLNV.GetLstNhanVien().Where(c => c.Id == _id).FirstOrDefault();
                        nv.TenNhanVien = txb_TenNhanVien.Text;
                        nv.SoCmnd = txb_CMND.Text;
                        nv.NamSinh = Convert.ToInt32(cbx_NamSinh.Text);
                        nv.SoDienThoai = txb_SDTNV.Text;
                        nv.MatKhau = txb_MatKhau.Text;
                        if (rbt_HoatDong.Checked = true)
                        {
                            nv.TrangThai = 1;
                        }
                        else
                        {
                            nv.TrangThai = 0;
                        }
                        nv.DiaChi = txb_DiaChi.Text;
                        nv.MaChucVu = _iQLNV.GetLstChucVu().Where(c => c.TenChucVu == cbx_ChucVu.Text).Select(c => c.MaChucVu).FirstOrDefault();
                        MessageBox.Show(_iQLNV.SuaNV(nv));
                        _iQLNV.GetDataFromDB();
                        LoadGrid();
                    
                }
            }
            catch (Exception)
            {
                DialogResult dm = MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                NhanVien nv = _iQLNV.GetLstNhanVien().Where(c => c.Id == _id).FirstOrDefault();
                MessageBox.Show(_iQLNV.XoaNV(nv));
                _iQLNV.GetDataFromDB();
                LoadGrid();
            }
        }
        public void LoadGridTimKiem(string nv)
        {
             dtgrid_NhanVien.ColumnCount = 8;
            dtgrid_NhanVien.Columns[0].Name = "Tên nhân viên";
            dtgrid_NhanVien.Columns[1].Name = "Số CMND";
            dtgrid_NhanVien.Columns[2].Name = "Năm sinh";
            dtgrid_NhanVien.Columns[3].Name = "Số điện thoại";
            dtgrid_NhanVien.Columns[4].Name = "Trạng thái";
            dtgrid_NhanVien.Columns[5].Name = "Địa chỉ";
            dtgrid_NhanVien.Columns[6].Name = "Chức vụ";
            dtgrid_NhanVien.Columns[7].Name = "ID";
            dtgrid_NhanVien.Columns[7].Visible = false;
            dtgrid_NhanVien.Rows.Clear();
            foreach (var x in _iQLNV.TimKiemNV(nv))
            {
                foreach (var y in _iQLNV.GetLstChucVu().Where(c=>c.MaChucVu==x.MaChucVu))
                {
                    dtgrid_NhanVien.Rows.Add(x.TenNhanVien, x.SoCmnd, x.NamSinh, x.SoDienThoai, x.TrangThai == 1 ? "Hoạt động" : "Ngừng hoạt động", x.DiaChi, y.TenChucVu,x.Id);
                }
              
            }
        }

        private void tbx_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadGridTimKiem(tbx_TimKiem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txb_CMND.Text = "";
            txb_DiaChi.Text = "";
            txb_MatKhau.Text = "";
            txb_SDTNV.Text = "";
            txb_TenNhanVien.Text = "";
        }
    }
}
