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
    public partial class Frm_XuatXu : Form
    {
        private IServiceQLXuatXu _iserviceQLXuatXu;
        private int _id;
        public Frm_XuatXu()
        {
            _iserviceQLXuatXu = new ServiceQLXuatXu();
            InitializeComponent();
            LoadGrid();
        }
        void LoadGrid()
        {
            dtgrid_XuatXu.ColumnCount = 4;
            dtgrid_XuatXu.Columns[0].Name = "ID";
            dtgrid_XuatXu.Columns[1].Name = "Mã xuất xứ";
            dtgrid_XuatXu.Columns[2].Name = "Tên nước";
            dtgrid_XuatXu.Columns[3].Name = "Trạng thái";
            dtgrid_XuatXu.Columns[0].Visible = false;
            dtgrid_XuatXu.Rows.Clear();
            foreach (var x in _iserviceQLXuatXu.GetLstXuatXu())
            {
                dtgrid_XuatXu.Rows.Add(x.Id, x.MaXuatXu, x.TenNuoc, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }

        private void btn_ThemXuatXu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                XuatXu xx = new XuatXu();
                xx.Id = _iserviceQLXuatXu.GetLstXuatXu().Max(c => c.Id) + 1;
                xx.MaXuatXu = tbx_MaXuatXu.Text;
                xx.TenNuoc = tbx_TenNuoc.Text;
                if (rbt_HoatDong.Checked == true)
                {
                    xx.TrangThai = 1;
                }
                else
                {
                    xx.TrangThai = 0;
                }
                MessageBox.Show(_iserviceQLXuatXu.ThemXX(xx));
                _iserviceQLXuatXu.GetDataFromDB();
                LoadGrid();
            }
        }

        private void dtgrid_XuatXu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            if (rowindex >= _iserviceQLXuatXu.GetLstXuatXu().Count) return;
            _id = Convert.ToInt32(dtgrid_XuatXu.Rows[rowindex].Cells[0].Value);
            XuatXu xx = _iserviceQLXuatXu.GetLstXuatXu().Where(c => c.Id == _id).FirstOrDefault();
            xx.MaXuatXu = tbx_MaXuatXu.Text;
            xx.TenNuoc = tbx_TenNuoc.Text;
            rbt_HoatDong.Checked = xx.TrangThai == 1 ? true : false;
            rbt_KhongHĐ.Checked = xx.TrangThai == 0 ? true : false;
        }

        private void btn_SuaXX_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                XuatXu xx = _iserviceQLXuatXu.GetLstXuatXu().Where(c => c.Id == _id).FirstOrDefault();

                xx.MaXuatXu = tbx_MaXuatXu.Text;
                xx.TenNuoc = tbx_TenNuoc.Text;
                if (rbt_HoatDong.Checked == true)
                {
                    xx.TrangThai = 1;
                }
                else
                {
                    xx.TrangThai = 0;
                }
                MessageBox.Show(_iserviceQLXuatXu.SuaXX(xx));
                _iserviceQLXuatXu.GetDataFromDB();
                LoadGrid();

            }
        }

        private void btn_XoaXX_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                XuatXu xx = _iserviceQLXuatXu.GetLstXuatXu().Where(c => c.Id == _id).FirstOrDefault();
                MessageBox.Show(_iserviceQLXuatXu.XoaXX(xx));
                _iserviceQLXuatXu.GetDataFromDB();
                LoadGrid();
            }
        }
    }
}
