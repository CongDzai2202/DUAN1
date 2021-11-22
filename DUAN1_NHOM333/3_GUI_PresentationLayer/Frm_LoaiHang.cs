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
    public partial class Frm_LoaiHang : Form
    {
        private IServiceQLLoaiHang _iserviceQLLoaiHang;
        private int _id;
        public Frm_LoaiHang()
        {
            _iserviceQLLoaiHang = new ServiceQLLoaiHang();
            InitializeComponent();
            LoadGrid();

        }

        private void btn_ThemLh_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                LoaiHang lh = new LoaiHang();
                lh.Id = _iserviceQLLoaiHang.GetLstLoaiSanPham().Max(c => c.Id) + 1;
                lh.MaLoaiHang = tbx_MaLoaiHang.Text;
                lh.TenLoaiHang = tbx_TenLoaiHang.Text;
                if (rbt_HoatDong.Checked==true)
                {
                    lh.TrangThai = 1;
                }
                else
                {
                    lh.TrangThai = 0;
                }
                MessageBox.Show(_iserviceQLLoaiHang.ThemHDCT(lh));
                _iserviceQLLoaiHang.GetDataFromDB();
                LoadGrid();
            }
        }
        void LoadGrid()
        {
            dtgrid_LoaiHang.ColumnCount =4;
            dtgrid_LoaiHang.Columns[0].Name = "ID";
            dtgrid_LoaiHang.Columns[1].Name = "Mã loại hàng";
            dtgrid_LoaiHang.Columns[2].Name = "Tên loại hàng";
            dtgrid_LoaiHang.Columns[3].Name = "Trạng thái";
            dtgrid_LoaiHang.Columns[0].Visible = false;
            dtgrid_LoaiHang.Rows.Clear();
            foreach (var x in _iserviceQLLoaiHang.GetLstLoaiSanPham())
            {
                dtgrid_LoaiHang.Rows.Add(x.Id, x.MaLoaiHang, x.TenLoaiHang, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
            }

        }
        private void dtgrid_LoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            if (rowindex >= _iserviceQLLoaiHang.GetLstLoaiSanPham().Count) return;
            _id = Convert.ToInt32(dtgrid_LoaiHang.Rows[rowindex].Cells[0].Value);
            LoaiHang lh = _iserviceQLLoaiHang.GetLstLoaiSanPham().Where(c => c.Id == _id).FirstOrDefault();
            lh.MaLoaiHang = tbx_MaLoaiHang.Text;
            lh.TenLoaiHang = tbx_TenLoaiHang.Text;
            rbt_HoatDong.Checked = lh.TrangThai == 1 ? true : false;
            rbt_KhongHĐ.Checked = lh.TrangThai == 0 ? true : false;
        }

        private void btn_SuaLH_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                LoaiHang lh = _iserviceQLLoaiHang.GetLstLoaiSanPham().Where(c => c.Id == _id).FirstOrDefault();
                lh.MaLoaiHang = tbx_MaLoaiHang.Text;
                lh.TenLoaiHang = tbx_TenLoaiHang.Text;
                rbt_HoatDong.Checked = lh.TrangThai == 1 ? true : false;
                rbt_KhongHĐ.Checked = lh.TrangThai == 0 ? true : false;
                MessageBox.Show(_iserviceQLLoaiHang.SuaHDCT(lh));
                _iserviceQLLoaiHang.GetDataFromDB();
                LoadGrid();
            }
        }

        private void btn_XoaLh_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                LoaiHang lh = _iserviceQLLoaiHang.GetLstLoaiSanPham().Where(c => c.Id == _id).FirstOrDefault();
                MessageBox.Show(_iserviceQLLoaiHang.XoaHDCT(lh));
                _iserviceQLLoaiHang.GetDataFromDB();
                LoadGrid();
            }
        }
    }
}
