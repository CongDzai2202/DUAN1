using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;
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
    public partial class Frm_DonViTinh : Form
    {
        private IServicesQLDonViTinh _iQLDonViTinh;
        private int _id;
        public Frm_DonViTinh()
        {
            _iQLDonViTinh = new ServiceQLDonViTinh();
            InitializeComponent();
            LoadGridDVT();
        }
        void LoadGridDVT()
        {
            dtgrid_DonViTinh.ColumnCount = 5;
            dtgrid_DonViTinh.Columns[0].Name = "Mã Đơn Vị Tính";
            dtgrid_DonViTinh.Columns[1].Name = "Tên Đơn Vị Tính";
            dtgrid_DonViTinh.Columns[2].Name = "Tên Chất Liệu";
            dtgrid_DonViTinh.Columns[3].Name = "Trạng thái";
            dtgrid_DonViTinh.Columns[4].Name = "ID";
            dtgrid_DonViTinh.Columns[4].Visible = false;
            dtgrid_DonViTinh.Rows.Clear();
            foreach (var x in _iQLDonViTinh.GetLstKichThuoc())
            {
                foreach (var y in _iQLDonViTinh.GetChatLieu().Where(c=>c.MaChatLieu==x.MaChatLieu))
                {
                    dtgrid_DonViTinh.Rows.Add(x.MaDonViTinh, x.TenDonViTinh, y.TenChatLieu, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.Id);
                }
            }
        }
        void LoadCBX()
        {

            foreach (var x in _iQLDonViTinh.GetChatLieu())
            {
                cbx_ChatLieu.Items.Add(x.TenChatLieu);
            }
            cbx_ChatLieu.SelectedIndex = 0;
        }

        private void btn_ThemDVT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DonViTinh dvt = new DonViTinh();
                dvt.Id = _iQLDonViTinh.GetLstKichThuoc().Max(c => c.Id) + 1;
                dvt.MaDonViTinh = tbx_Madonvitinh.Text;
                dvt.TenDonViTinh = tbx_TenDVT.Text;
                dvt.MaChatLieu = _iQLDonViTinh.GetChatLieu().Where(c => c.TenChatLieu == cbx_ChatLieu.Text).Select(c => c.MaChatLieu).FirstOrDefault();
                if (rbt_HoatDong.Checked == true)
                {
                    dvt.TrangThai = 1;
                }
                else
                {
                    dvt.TrangThai = 0;
                }
                MessageBox.Show(_iQLDonViTinh.ThemKT(dvt));
                _iQLDonViTinh.GetDataFromDB();
                LoadGridDVT();
            }
        }

     

        private void dtgrid_DonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            if (rowindex >= _iQLDonViTinh.GetLstKichThuoc().Count) return;
            _id = Convert.ToInt32(dtgrid_DonViTinh.Rows[rowindex].Cells[4].Value);
            DonViTinh dvt = _iQLDonViTinh.GetLstKichThuoc().Where(c => c.Id == _id).FirstOrDefault();
            tbx_Madonvitinh.Text = dvt.MaDonViTinh;
            tbx_TenDVT.Text = dvt.TenDonViTinh;
            rbt_HoatDong.Checked = dvt.TrangThai == 1 ? true : false;
            rbt_KhongHoatDong.Checked = dvt.TrangThai == 0 ? true : false;
            cbx_ChatLieu.Text = _iQLDonViTinh.GetChatLieu().Where(c => c.MaChatLieu == dvt.MaChatLieu).Select(c => c.TenChatLieu).FirstOrDefault();

        }
        private void btn_SuaDVT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DonViTinh dvt = _iQLDonViTinh.GetLstKichThuoc().Where(c => c.Id == _id).FirstOrDefault(); 
                
                dvt.MaDonViTinh = tbx_Madonvitinh.Text;
                dvt.TenDonViTinh = tbx_TenDVT.Text;
                dvt.MaChatLieu = _iQLDonViTinh.GetChatLieu().Where(c => c.TenChatLieu == cbx_ChatLieu.Text).Select(c => c.MaChatLieu).FirstOrDefault();
                if (rbt_HoatDong.Checked == true)
                {
                    dvt.TrangThai = 1;
                }
                else
                {
                    dvt.TrangThai = 0;
                }
                MessageBox.Show(_iQLDonViTinh.SuaKT(dvt));
                _iQLDonViTinh.GetDataFromDB();
                LoadGridDVT();
            }
        }

        private void btn_XoaDVT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                DonViTinh dvt = _iQLDonViTinh.GetLstKichThuoc().Where(c => c.Id == _id).FirstOrDefault();
                MessageBox.Show(_iQLDonViTinh.XoaKT(dvt));
                _iQLDonViTinh.GetDataFromDB();
                LoadGridDVT();
            }
        }
    }
}
