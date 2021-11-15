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
    public partial class Frm_QuanLiNCC : Form
    {
        private IServicesQLNhaCungCap _iServicesQLNhaCungCap;
        private string idWhenclick;

        public Frm_QuanLiNCC()
        {
            _iServicesQLNhaCungCap = new ServicesQLNhaCungCap();
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            _iServicesQLNhaCungCap = new ServicesQLNhaCungCap();
            dgv_NhaCungCap.ColumnCount = 5;
            dgv_NhaCungCap.Columns[0].Name = "Mã NCC";
            dgv_NhaCungCap.Columns[1].Name = "Tên NCC";
            dgv_NhaCungCap.Columns[2].Name = "Số ĐT";
            dgv_NhaCungCap.Columns[3].Name = "Địa Chỉ";
            dgv_NhaCungCap.Columns[3].Name = "Trạng Thái";
            dgv_NhaCungCap.Rows.Clear();
            if (_iServicesQLNhaCungCap.getLstNhaCungCap().Count < 0) return;
            foreach (var x in _iServicesQLNhaCungCap.getLstNhaCungCap())
            {
                dgv_NhaCungCap.Rows.Add(x.MaNhaCungCap, x.TenNhaCungCap, x.SoDienThoai, x.DiaChi, x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Them.Enabled = false;
            var row = dgv_NhaCungCap.Rows;
            int rowindex = e.RowIndex;
            if (rowindex == _iServicesQLNhaCungCap.getLstNhaCungCap().Count || rowindex == -1) return;
            txt_MaNcc.Text = row[rowindex].Cells[0].Value.ToString();
            txt_TenNcc.Text = row[rowindex].Cells[1].Value.ToString();
            txt_SDT.Text = row[rowindex].Cells[2].Value.ToString();
            txt_diachi.Text = row[rowindex].Cells[3].Value.ToString();
            idWhenclick = txt_MaNcc.Text;//_iServicesQLNhaCungCap.getLstNhaCungCap().Where(c => c.TenNhaCungCap == txt_TenNcc.Text).Select(c => c.MaNhaCungCap).FirstOrDefault();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm hay không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.Id = _iServicesQLNhaCungCap.getLstNhaCungCap().Max(c => c.Id) + 1;
                ncc.MaNhaCungCap = "MNCC" + ncc.Id;
                ncc.TenNhaCungCap = txt_TenNcc.Text;
                ncc.SoDienThoai = txt_SDT.Text;
                ncc.DiaChi = txt_diachi.Text;
                ncc.TrangThai = 1;

                MessageBox.Show(_iServicesQLNhaCungCap.ThemNCC(ncc), "Thông Báo");
                
            }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            if (MessageBox.Show("Bạn có muốn sửa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.MaNhaCungCap = idWhenclick;
                ncc.TenNhaCungCap = txt_TenNcc.Text;
                ncc.SoDienThoai = txt_SDT.Text;
                ncc.DiaChi = txt_diachi.Text;
                ncc.TrangThai = 1;

                MessageBox.Show(_iServicesQLNhaCungCap.SuaNCC(ncc), "Thông Báo");
               
            }
            LoadData();
        }
        private void clearfrom()
        {
            txt_MaNcc.Text = "";
            txt_TenNcc.Text = "";
            txt_SDT.Text = "";
            txt_diachi.Text = "";
            btn_Them.Enabled = true;
        }
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            clearfrom();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm;
            if (_iServicesQLNhaCungCap.Statusdata() == false)
            {
                confirm = MessageBox.Show("Dữ liệu chưa được lưu. \n Bạn có muốn lưu trước khi thoát?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                if (confirm == DialogResult.Yes) _iServicesQLNhaCungCap.saveNCC();
            }
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_NhaCungCap.Rows.Clear();
            if (_iServicesQLNhaCungCap.getLstNhaCungCap().Count < 0) return;
            _iServicesQLNhaCungCap = new ServicesQLNhaCungCap();
            foreach (var x in _iServicesQLNhaCungCap.getLstNhaCungCap().Where(c=>c.TenNhaCungCap.ToLower().StartsWith(txt_search.Text)))
            {
                dgv_NhaCungCap.Rows.Add(x.MaNhaCungCap, x.TenNhaCungCap, x.SoDienThoai, x.DiaChi, x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                MessageBox.Show(_iServicesQLNhaCungCap.saveNCC(),"Thông Báo");
            }
            LoadData();
        }
    }
}
