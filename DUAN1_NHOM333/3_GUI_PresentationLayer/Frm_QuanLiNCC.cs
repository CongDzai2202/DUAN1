using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_Utilities;
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
using _2_BUS_BusinessLayer.BUS_CheckNCC;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_QuanLiNCC : Form
    {
        private IServicesQLNhaCungCap _iServicesQLNhaCungCap;
        private string idWhenclick;
        private ICheckNCC check;

        public Frm_QuanLiNCC()
        {
            _iServicesQLNhaCungCap = new ServicesQLNhaCungCap();
            check = new checkNCC();
            InitializeComponent();
            rbtn_HD.Checked = true;
            LoadData();
        }
        bool Check()
        {
            if (check.checkNull(txt_TenNcc.Text))
            {
                MessageBox.Show(" Không được để trống tên Nhà Cung Cấp!", "Thông báo");
                return false;
            }
            if (check.checkChu(txt_TenNcc.Text))
            {
                MessageBox.Show("Tên nhà cung cấp phải nhập chữ! \n Không được nhập số!");
                return false;
            }
            if (check.checkNull(txt_SDT.Text))
            {
                MessageBox.Show(" Không được để trống SĐT!", "Thông báo");
                return false;
            }
            if (check.checkSo(txt_SDT.Text))
            {
                MessageBox.Show("SĐT phải nhập số! \n Không được nhập chữ!", "Thông báo");
                return false;
            }
            if (check.checkNull(txt_diachi.Text))
            {
                MessageBox.Show(" Không được để trống Địa Chỉ!", "Thông báo");
                return false;
            }

            return true;
        }
        void LoadData()
        {
            _iServicesQLNhaCungCap = new ServicesQLNhaCungCap();
            dgv_NhaCungCap.ColumnCount = 5;
            dgv_NhaCungCap.Columns[0].Name = "Mã NCC";
            dgv_NhaCungCap.Columns[0].Visible = false;
            dgv_NhaCungCap.Columns[1].Name = "Tên NCC";
            dgv_NhaCungCap.Columns[2].Name = "Số ĐT";
            dgv_NhaCungCap.Columns[3].Name = "Địa Chỉ";
            dgv_NhaCungCap.Columns[4].Name = "Trạng Thái";
            dgv_NhaCungCap.Rows.Clear();
            foreach (var x in _iServicesQLNhaCungCap.getLstNhaCungCaps())
            {
                dgv_NhaCungCap.Rows.Add(x.MaNhaCungCap, x.TenNhaCungCap, x.SoDienThoai, x.DiaChi, x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động");
            }
        }

        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Them.Enabled = false;
            var row = dgv_NhaCungCap.Rows;
            int rowindex = e.RowIndex;
            if (rowindex == _iServicesQLNhaCungCap.getLstNhaCungCaps().Count || rowindex == -1) return;
            txt_MaNcc.Text = row[rowindex].Cells[0].Value.ToString();
            txt_TenNcc.Text = row[rowindex].Cells[1].Value.ToString();
            txt_SDT.Text = row[rowindex].Cells[2].Value.ToString();
            txt_diachi.Text = row[rowindex].Cells[3].Value.ToString();
            rbtn_HD.Checked = row[rowindex].Cells[4].Value.ToString() == "Hoạt Động" ? true : false;
            rbtn_KHD.Checked = row[rowindex].Cells[4].Value.ToString() == "Không Hoạt Động" ? true : false;
            idWhenclick = _iServicesQLNhaCungCap.getLstNhaCungCaps().Where(c => c.TenNhaCungCap == txt_TenNcc.Text).Select(c => c.MaNhaCungCap).FirstOrDefault();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (Check() == false)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.Id = _iServicesQLNhaCungCap.getLstNhaCungCaps().Max(c => c.Id) + 1;
                    ncc.MaNhaCungCap = "MNCC" + ncc.Id;
                    ncc.TenNhaCungCap = txt_TenNcc.Text;
                    ncc.SoDienThoai = txt_SDT.Text;
                    ncc.DiaChi = txt_diachi.Text;
                    ncc.TrangThai = rbtn_HD.Checked?1:0;

                    MessageBox.Show(_iServicesQLNhaCungCap.ThemNCC(ncc), "Thông Báo");
                    _iServicesQLNhaCungCap.getLstNhaCungCaps();
                    _iServicesQLNhaCungCap.saveNCC();
                    LoadData();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            if (Check() == false)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.MaNhaCungCap = idWhenclick;
                    ncc.TenNhaCungCap = txt_TenNcc.Text;
                    ncc.SoDienThoai = txt_SDT.Text;
                    ncc.DiaChi = txt_diachi.Text;
                    ncc.TrangThai = rbtn_HD.Checked ? 1 : 0;

                    MessageBox.Show(_iServicesQLNhaCungCap.SuaNCC(ncc), "Thông Báo");
                    _iServicesQLNhaCungCap.getLstNhaCungCaps();
                    _iServicesQLNhaCungCap.saveNCC();
                    LoadData();
                }
            }
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

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            dgv_NhaCungCap.ColumnCount = 5;
            dgv_NhaCungCap.Columns[0].Name = "Mã NCC";
            dgv_NhaCungCap.Columns[0].Visible = false;
            dgv_NhaCungCap.Columns[1].Name = "Tên NCC";
            dgv_NhaCungCap.Columns[2].Name = "Số ĐT";
            dgv_NhaCungCap.Columns[3].Name = "Địa Chỉ";
            dgv_NhaCungCap.Columns[3].Name = "Trạng Thái";
            dgv_NhaCungCap.Rows.Clear();
            _iServicesQLNhaCungCap = new ServicesQLNhaCungCap();
            foreach (var x in _iServicesQLNhaCungCap.getLstNhaCungCaps().Where(c => c.TenNhaCungCap.StartsWith(txt_search.Text)))
            {
                dgv_NhaCungCap.Rows.Add(x.MaNhaCungCap, x.TenNhaCungCap, x.SoDienThoai, x.DiaChi, x.TrangThai == 1 ? "Hoạt Động" :"Không Hoạt Động");
            }
        }

        private void txt_search_MouseDown(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void Frm_QuanLiNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm;
            if (_iServicesQLNhaCungCap.Statusdata() == false)
            {
                confirm = MessageBox.Show("Dữ liệu chưa được lưu. \n Bạn có muốn lưu trước khi thoát?",
                    "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (confirm == DialogResult.Yes) _iServicesQLNhaCungCap.saveNCC();
            }
        }

        private void btn_dongman_Click(object sender, EventArgs e)
        {
            Frm_GiaoDien tk = new Frm_GiaoDien();
            this.Hide();
            tk.Show();
        }
    }
}
