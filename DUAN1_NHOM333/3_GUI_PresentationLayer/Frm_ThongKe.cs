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
        private List<IServiceQLHoaDon> _lstHoaDon;
        private IServiceQLHienThi _iServiceQLHienThi;
        private IServiceThongKe _iServiceThongKe;
        public string MaHoaDonClick;
        public string MaNhanVienClick;
        public int SoLuongClick;
        public DateTime NgayXuatClick;
        public double TongTienClick;
        public double TongTien = 0;
        public Frm_ThongKe()
        {
            _iServiceQLHienThi = new ServiceQLHienThi();
            _iServiceQLHoaDon = new ServiceQLHoaDon();
            _iServiceQLHoaDonChiTiet = new ServiceQLHoaDonChiTiet();
            _lstHoaDon = new List<IServiceQLHoaDon>();
            InitializeComponent();
            Loaddata();
            LoadDataChiTiet();
            TinhTien();

        }
        void Loaddata()
        {

            dgid_Data.ColumnCount = 6;
            dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
            dgid_Data.Columns[1].Name = "Mã Nhân Viên";
            dgid_Data.Columns[2].Name = "Sô Lượng Bán";
            dgid_Data.Columns[3].Name = "Ngày Bán";
            dgid_Data.Columns[4].Name = "Tổng Tiền";
            dgid_Data.Columns[5].Name = "Trạng Thái";
            dgid_Data.Rows.Clear();
            foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS())
            {
                int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
            }
            DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
            but1.Text = "Chi Tiết";
            but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            but1.UseColumnTextForButtonValue = true;
            dgid_Data.Columns.Add(but1);
        }
        #region TimKiemHoaDon
        private void cbx_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            cbx_nam.Checked = false;
            cbx_thang.Checked = false;
            if (cbx_Ngay.Checked == true && rdb_ChuaThanhToan.Checked == false && rdb_DTT.Checked == false)
            {
                cbx_thang.Checked = false;
                cbx_nam.Checked = false;
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat == DateTime.Today.AddDays(-1)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_DTT.Checked == true && cbx_Ngay.Checked == true && rdb_ChuaThanhToan.Checked == false)
            {
                cbx_thang.Checked = false;
                cbx_nam.Checked = false;
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat == DateTime.Today.AddDays(-1) && c.TrangThai == 0))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (cbx_Ngay.Checked == true && rdb_DTT.Checked == false && rdb_ChuaThanhToan.Checked == true)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat == DateTime.Today.AddDays(-1) && c.TrangThai == 1))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
        }

        private void cbx_thang_CheckedChanged(object sender, EventArgs e)
        {
            cbx_Ngay.Checked = false;
            cbx_nam.Checked = false;
            if (cbx_thang.Checked == true && rdb_ChuaThanhToan.Checked == false && rdb_DTT.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-30)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (cbx_thang.Checked == true && rdb_DTT.Checked == true && rdb_ChuaThanhToan.Checked == false)
            {
                cbx_Ngay.Checked = false;
                cbx_nam.Checked = false;
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-30) && c.TrangThai == 0))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (cbx_thang.Checked == true && rdb_DTT.Checked == false && rdb_ChuaThanhToan.Checked == true)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-30) && c.TrangThai == 1))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
        }

        private void cbx_nam_CheckedChanged(object sender, EventArgs e)
        {
            cbx_Ngay.Checked = false;
            cbx_thang.Checked = false;
            if (cbx_nam.Checked == true && rdb_DTT.Checked == false && rdb_ChuaThanhToan.Checked == false)
            {
                cbx_thang.Checked = false;
                cbx_Ngay.Checked = false;
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (cbx_nam.Checked == true && rdb_DTT.Checked == true && rdb_ChuaThanhToan.Checked == false)
            {
               
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365) && c.TrangThai == 0))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (cbx_nam.Checked == true && rdb_DTT.Checked == false && rdb_ChuaThanhToan.Checked == true)
            {
               
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365) && c.TrangThai == 1))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }

        }

        private void rdb_DTT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_DTT.Checked == true && cbx_Ngay.Checked == false && cbx_thang.Checked == false && cbx_nam.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 0))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_DTT.Checked == true && cbx_Ngay.Checked == true && cbx_thang.Checked == false && cbx_nam.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 0 && c.NgayXuat == DateTime.Today.AddDays(-1)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_DTT.Checked == true && cbx_Ngay.Checked == false && cbx_thang.Checked == true && cbx_nam.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 0 && c.NgayXuat >= DateTime.Today.AddDays(-30)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_DTT.Checked == true && cbx_Ngay.Checked == false && cbx_thang.Checked == false && cbx_nam.Checked == true)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 0 && c.NgayXuat >= DateTime.Today.AddDays(-365)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }

        }
      

        private void rdb_ChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_ChuaThanhToan.Checked == true && cbx_Ngay.Checked == false && cbx_thang.Checked == false && cbx_nam.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 1))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_ChuaThanhToan.Checked == true && cbx_Ngay.Checked == true && cbx_thang.Checked == false && cbx_nam.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 1 && c.NgayXuat == DateTime.Today.AddDays(-1)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_ChuaThanhToan.Checked == true && cbx_Ngay.Checked == false && cbx_thang.Checked == true && cbx_nam.Checked == false)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.TrangThai == 1 && c.NgayXuat >= DateTime.Today.AddDays(-30)))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
            else if (rdb_ChuaThanhToan.Checked == true && cbx_Ngay.Checked == false && cbx_thang.Checked == false && cbx_nam.Checked == true)
            {
                dgid_Data.ColumnCount = 6;
                dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
                dgid_Data.Columns[1].Name = "Mã Nhân Viên";
                dgid_Data.Columns[2].Name = "Sô Lượng Bán";
                dgid_Data.Columns[3].Name = "Ngày Bán";
                dgid_Data.Columns[4].Name = "Tổng Tiền";
                dgid_Data.Columns[5].Name = "Trạng Thái";
                dgid_Data.Rows.Clear();
                TongTien = 0;
                foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c => c.NgayXuat >= DateTime.Today.AddDays(-365) && c.TrangThai == 1))
                {
                    int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                    dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                    TongTien += Convert.ToDouble(x.ThanhTien);
                    lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
                }
                DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
                but1.Text = "Chi Tiết";
                but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                but1.UseColumnTextForButtonValue = true;
                dgid_Data.Columns.Add(but1);
            }
        }
        #endregion
        void LoadDataChiTiet()
        {
            dgid_ChiTiet.ColumnCount = 6;
            dgid_ChiTiet.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
            dgid_ChiTiet.Columns[1].Name = "Tên Sản Phẩm";
            dgid_ChiTiet.Columns[2].Name = "Sô Lượng Bán";
            dgid_ChiTiet.Columns[3].Name = "Giá Tiền";
            dgid_ChiTiet.Columns[4].Name = "Mã Hóa Đơn";
            dgid_ChiTiet.Columns[4].Visible = false;
            dgid_ChiTiet.Rows.Clear();
            foreach (var x in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS())
            {
                dgid_ChiTiet.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.SoLuong, x.DonGia, x.MaHoaDon);
            }
        }
        void LoadChiTiet()
        {
            dgid_ChiTiet.ColumnCount = 6;
            dgid_ChiTiet.Columns[0].Name = "Mã Hóa Đơn Chi Tiết";
            dgid_ChiTiet.Columns[1].Name = "Tên Sản Phẩm";
            dgid_ChiTiet.Columns[2].Name = "Sô Lượng Bán";
            dgid_ChiTiet.Columns[3].Name = "Giá Tiền";
            dgid_ChiTiet.Columns[4].Name = "Mã Hóa Đơn";
            dgid_ChiTiet.Columns[4].Visible = false;
            dgid_ChiTiet.Rows.Clear();
            foreach (var x in _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Where(c => c.MaHoaDon == MaHoaDonClick))
            {
                dgid_ChiTiet.Rows.Add(x.MaHoaDonChiTiet, x.TenSanPham, x.SoLuong, x.DonGia, x.MaHoaDon);
            }
        }
        private void dgid_ChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dgid_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if ((rowindex == _iServiceQLHoaDon.getLstHoaDonBUS().Count) || columnindex == -1 || rowindex == -1) return;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 6)

            {
                MaHoaDonClick = dgid_Data.Rows[rowindex].Cells[0].Value.ToString();
                MaNhanVienClick = dgid_Data.Rows[rowindex].Cells[1].Value.ToString();
                SoLuongClick = Convert.ToInt32(dgid_Data.Rows[rowindex].Cells[2].Value.ToString());
                TongTienClick = Convert.ToDouble(dgid_Data.Rows[rowindex].Cells[4].Value.ToString());
                LoadChiTiet();

            }
        }
        void TinhTien()
        {
            TongTien = 0;
            foreach(var x in _iServiceQLHoaDon.getLstHoaDonBUS())
            {
                TongTien += Convert.ToDouble(x.ThanhTien);
                lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
            }
        }

        private void lb_TongTien_Click(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgid_Data.ColumnCount = 6;
            dgid_Data.Columns[0].Name = "Mã Hóa Đơn";
            dgid_Data.Columns[1].Name = "Mã Nhân Viên";
            dgid_Data.Columns[2].Name = "Sô Lượng Bán";
            dgid_Data.Columns[3].Name = "Ngày Bán";
            dgid_Data.Columns[4].Name = "Tổng Tiền";
            dgid_Data.Columns[5].Name = "Trạng Thái";
            dgid_Data.Rows.Clear();
            TongTien = 0;
            foreach (var x in _iServiceQLHoaDon.getLstHoaDonBUS().Where(c=>c.NgayXuat > datetimeStart.Value && c.NgayXuat<datetimeend.Value))
            {
                int SoLuong = _iServiceQLHoaDonChiTiet.getLstHoaDonChiTietBUS().Count(c => c.MaHoaDon == x.MaHoaDon);
                dgid_Data.Rows.Add(x.MaHoaDon, x.MaNhanVien, SoLuong, x.NgayXuat, x.ThanhTien, x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán");
                TongTien += Convert.ToDouble(x.ThanhTien);
                lb_TongTien.Text = TongTien.ToString() + "   VNĐ";
            }
            DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
            but1.Text = "Chi Tiết";
            but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            but1.UseColumnTextForButtonValue = true;
            dgid_Data.Columns.Add(but1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            rdb_ChuaThanhToan.Checked = false;
            rdb_DTT.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_GiaoDien gd = new Frm_GiaoDien();
            this.Hide();
            gd.Show();
        }
    }
}
