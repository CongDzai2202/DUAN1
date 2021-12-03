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
    public partial class Frm_ThongKe : Form
    {
        private IServiceQLHoaDon _iServiceQLHoaDon;
        private IServiceQLHoaDonChiTiet _iServiceQLHoaDonChiTiet;
        public Frm_ThongKe()
        {
            _iServiceQLHoaDon = new ServiceQLHoaDon();
            _iServiceQLHoaDonChiTiet = new ServiceQLHoaDonChiTiet();
            InitializeComponent();
            Loaddata();

        }
        void Loaddata()
        {
            var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                      join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                      select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
            dgid_Data.ColumnCount = 9;
            dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
            dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
            dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
            dgid_Data.Columns[3].Name = "Ngày Bán";
            dgid_Data.Columns[4].Name = "Giá Bán";
            dgid_Data.Columns[5].Name = "Số Lượng Bán";
            dgid_Data.Columns[6].Name = "Thành Tiền";
            dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
            dgid_Data.Columns[8].Name = "Trạng Thái";
            dgid_Data.Rows.Clear();
            foreach(var x in LST)
            {
                dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
            }
        }

        private void cbx_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            if (cbx_Ngay.Checked == true && rdb_ChuaThanhToan.Checked == false && rdb_DTT.Checked == false)
            {
                cbx_thang.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                foreach (var x in LST.Where(c => c.NgayXuat == DateTime.Today))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                }
            }
            else if (rdb_DTT.Checked == true && cbx_Ngay.Checked == true && rdb_ChuaThanhToan.Checked == false)
            {
                cbx_thang.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                foreach (var x in LST.Where(c => c.NgayXuat == DateTime.Today && c.TrangThai == 0))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                }
            }
            else if (cbx_Ngay.Checked == false)
            {
                Loaddata();
            }
        }

        private void cbx_thang_CheckedChanged(object sender, EventArgs e)
        {
            Check();   
            if (cbx_thang.Checked == true)
            {
                cbx_Ngay.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-19);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.NgayXuat >= DateTime.Today.AddDays(-30)))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    
                }
            }
            else if (cbx_thang.Checked == false)
            {
                Loaddata();
            }
        }

        private void cbx_nam_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            if (cbx_nam.Checked == true && rdb_DTT.Checked == false && rdb_ChuaThanhToan.Checked == false)
            {
                cbx_Ngay.Checked = false;
                cbx_thang.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-365);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365)))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
           
            else if (cbx_nam.Checked == false)
            {
                Loaddata();
            }
        }

        private void rdb_DTT_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            if (rdb_DTT.Checked == true)
            {
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-365);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.TrangThai == 0))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
            else if (rdb_DTT.Checked == false)
            {
                Loaddata();
            }
        }
        void Check()
        {
            if(rdb_DTT.Checked == true && cbx_Ngay.Checked == true)
            {
                cbx_thang.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                foreach (var x in LST.Where(c => c.NgayXuat == DateTime.Today && c.TrangThai == 0))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                }
            }
            else if(rdb_DTT.Checked == true && cbx_thang.Checked == true)
            {
                cbx_Ngay.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-19);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.NgayXuat >= DateTime.Today.AddDays(-30) && c.TrangThai == 0))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
            else if(rdb_DTT.Checked == true && cbx_nam.Checked == true)
            {
                cbx_Ngay.Checked = false;
                cbx_thang.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-365);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365) && c.TrangThai == 0))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
            else if (rdb_ChuaThanhToan.Checked == true && cbx_Ngay.Checked == true)
            {
                cbx_thang.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                foreach (var x in LST.Where(c => c.NgayXuat == DateTime.Today && c.TrangThai == 1))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                }
            }
            else if (rdb_ChuaThanhToan.Checked == true && cbx_thang.Checked == true)
            {
                cbx_Ngay.Checked = false;
                cbx_nam.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-19);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.NgayXuat >= DateTime.Today.AddDays(-30) && c.TrangThai == 1))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
            else if (rdb_ChuaThanhToan.Checked == true && cbx_nam.Checked == true)
            {
                cbx_Ngay.Checked = false;
                cbx_thang.Checked = false;
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-365);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365) && c.TrangThai == 1))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
        }

        private void rdb_ChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            Check();
            if (rdb_ChuaThanhToan.Checked == true)
            {
                var LST = (from a in _iServiceQLHoaDon.getLstHoaDonBUS()
                           join b in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaHoaDon equals b.MaHoaDon
                           select new { a.MaHoaDon, a.MaNhanVien, a.ThanhTien, a.TrangThai, a.NgayXuat, b.MaHoaDonChiTiet, b.TenSanPham, b.DonGia, b.SoLuong }).ToList();
                dgid_Data.ColumnCount = 9;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
                dgid_Data.Columns[1].Name = "Tên Sản Phẩm";
                dgid_Data.Columns[2].Name = "Mã Nhân Viên ";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Giá Bán";
                dgid_Data.Columns[5].Name = "Số Lượng Bán";
                dgid_Data.Columns[6].Name = "Thành Tiền";
                dgid_Data.Columns[7].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[8].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                //DateTime dt = DateTime.Today.AddDays(-365);
                //MessageBox.Show(dt.ToString());

                foreach (var x in LST.Where(c => c.TrangThai == 1))
                {
                    dgid_Data.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.MaNhanVien, x.NgayXuat, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");

                }
            }
            else if (rdb_ChuaThanhToan.Checked == false)
            {
                Loaddata();
            }
        }
    }
}
