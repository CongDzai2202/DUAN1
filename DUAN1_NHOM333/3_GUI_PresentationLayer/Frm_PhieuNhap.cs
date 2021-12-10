using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;
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
    public partial class Frm_PhieuNhap : Form
    {
        private string idwhenclick;
        private IServiceQLNhapKho _iServiceQLNhapKho;
        private List<ViewNhapKho> _lstviewNhapKhos;
        public Frm_PhieuNhap()
        {
            _iServiceQLNhapKho = new ServiceQLNhapKho();
            _lstviewNhapKhos = new List<ViewNhapKho>();
            InitializeComponent();
            loadData();
            LoadCMBMSP();
            LoadCMBtenSP();
            LoadCMBMNCC();
            LoadCMBtenNCC();
            //loadLstView();
        }

        private void loadData()
        {
            dgv_nhapKho.ColumnCount = 8;
            dgv_nhapKho.Columns[0].Name = "Mã Phiếu Nhập";
            dgv_nhapKho.Columns[1].Name = "Mã Sản Phẩm";
            dgv_nhapKho.Columns[2].Name = "Tên Sản Phẩm";
            dgv_nhapKho.Columns[3].Name = "Mã NCC";
            dgv_nhapKho.Columns[4].Name = "Tên NCC";
            dgv_nhapKho.Columns[5].Name = "Số Lượng";
            dgv_nhapKho.Columns[6].Name = "Đơn giá Nhập";
            dgv_nhapKho.Columns[7].Name = "Ngày Nhập";
            dgv_nhapKho.Rows.Clear();
            foreach (var x in _iServiceQLNhapKho.getLstViewNL())
            {
                var item = x.Phieunhap;
                var pnct = x.Phieunhapchitiet;
                var ttsp = x.ThongtinSP;
                var ncc = x.Nhacungcap;
                dgv_nhapKho.Rows.Add(item.MaPhieuNhap, ttsp.MaSanPham, ttsp.TenSanPham, 
                    item.MaNhaCungCap, ncc.TenNhaCungCap, pnct.SoLuong, pnct.DonGiaNhap,item.NgayNhap);
            }
        }
        public void LoadCMBMSP()
        {
            foreach (var x in _iServiceQLNhapKho.getLstViewNL().ToList())
            {
                cbx_maSP.Items.Add(x.ThongtinSP.MaSanPham);
            }
        }
        public void LoadCMBtenSP()
        {
            foreach (var x in _iServiceQLNhapKho.getLstViewNL().ToList())
            {
                cbx_maSP.Items.Add(x.ThongtinSP.TenSanPham);
            }
        }
        public void LoadCMBMNCC()
        {
            foreach (var x in _iServiceQLNhapKho.getLstViewNL().ToList())
            {
                cbx_maSP.Items.Add(x.Nhacungcap.MaNhaCungCap);
            }
        }
        public void LoadCMBtenNCC()
        {
            foreach (var x in _iServiceQLNhapKho.getLstViewNL().ToList())
            {
                cbx_maSP.Items.Add(x.Nhacungcap.TenNhaCungCap);
            }
        }
        /* private void loadLstView()
         {
             var lstNk = new ServiceQLNhapKho().getLstViewNL();
             lstNk.ForEach(z =>
             {
                 ViewNhapKho view = new ViewNhapKho();
                 view.Phieunhap = z.Phieunhap;
                 view.Phieunhap.So = _iManageCtOdDetail.Getlst_View().OrderBy(x => x.Customer_Order_Details.Prd_Code).Where(x => x.Customer_Order_Details.Prd_Code == z.Products.Prd_Code).Sum(x => x.Customer_Order_Details.Quantity);
                 _lstView.Add(view);
             });
         }*/
        private void dgv_nhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maPhieu.Enabled = false;
            int rowindex = e.RowIndex;
            if (rowindex>=_iServiceQLNhapKho.getLstViewNL().Count || rowindex<0) return;
            txt_maPhieu.Text = dgv_nhapKho.Rows[rowindex].Cells[0].Value.ToString();
            cbx_maSP.Text = dgv_nhapKho.Rows[rowindex].Cells[1].Value.ToString();
            cbx_tenSP.Text = dgv_nhapKho.Rows[rowindex].Cells[2].Value.ToString();
            cbx_maNCC.Text = dgv_nhapKho.Rows[rowindex].Cells[3].Value.ToString();
            cbx_tenNCC.Text = dgv_nhapKho.Rows[rowindex].Cells[4].Value.ToString();
            txt_SoLuong.Text = dgv_nhapKho.Rows[rowindex].Cells[5].Value.ToString();
            txt_DonGia.Text = dgv_nhapKho.Rows[rowindex].Cells[6].Value.ToString();
            dtp_NgayNhap.Text = dgv_nhapKho.Rows[rowindex].Cells[7].Value.ToString();
            idwhenclick = dgv_nhapKho.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iServiceQLNhapKho.save()); 
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txt_maPhieu.Enabled = true;
            txt_maPhieu.Text = "";
            txt_DonGia.Text = "";
            txt_SoLuong.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_GiaoDien frm_GiaoDien = new Frm_GiaoDien();
            this.Hide();
            frm_GiaoDien.Show();
        }
    }
}
