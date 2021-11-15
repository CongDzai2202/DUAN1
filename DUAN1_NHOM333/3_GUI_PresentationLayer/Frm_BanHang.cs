using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;
using _2_BUS_BusinessLayer.BUS_Services;
using AForge.Video.DirectShow;
using ZXing;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_BanHang : Form
    {
        private int dem = 0;
        private IServiceQLCTSanPham _iServiceQlctSanPham;
        private IServiceQLHoaDon _iServiceQlHoaDon;
        private IServiceQLHoaDonChiTiet _iServiceQlHoaDonChiTiet;
        private List<BUS_HoaDonChiTiet> _lstBusHoaDonChiTiets;
        private IServiceQLHienThi _iServiceQlHienThi;
        public string flag;
        public Frm_BanHang()
        {
            _lstBusHoaDonChiTiets = new List<BUS_HoaDonChiTiet>();
            _iServiceQlHoaDon = new ServiceQLHoaDon();
            _iServiceQlHoaDonChiTiet = new ServiceQLHoaDonChiTiet();
            _iServiceQlctSanPham = new ServiceQLTTSanPham();
            _iServiceQlHienThi = new ServiceQLHienThi();
            InitializeComponent();
            LoadCMBMaThongTin();
        }

        public void LoadCMBMaThongTin()
        {
            foreach (var x in _iServiceQlctSanPham.GetLstThongTinSanPhams().ToList())
            {
                cbMaSanPham.Items.Add(x.TenSanPham);
            }
        }

        void Loaddata()
        {
            _lstBusHoaDonChiTiets = (from x in _lstBusHoaDonChiTiets
                                     group x by new
                                     {

                                         
                                         x.TenSanPham,
                                         x.BarCode,
                                         x.MaHoaDon,
                                         x.DonGia,
                                         x.SoLuong,
                                         x.TrangThai,
                                         x.ThanhTien
                                     }
                into g
                                     select new BUS_HoaDonChiTiet()
                                     {
                                         TenSanPham = g.Key.TenSanPham,
                                         BarCode = g.Key.BarCode,
                                         MaHoaDon = g.Key.MaHoaDon,
                                         DonGia = g.Key.DonGia,
                                         TrangThai = g.Key.TrangThai,
                                         ThanhTien = g.Key.ThanhTien,
                                         SoLuong = g.Sum(c => c.SoLuong),
                                         // ThanhTien = g.
                                     }).ToList();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Name = "Mã Hóa Đơn";
            dataGridView1.Columns[2].Name = "Đơn Giá";
            dataGridView1.Columns[3].Name = "Trạng Thái";
            dataGridView1.Columns[4].Name = "Sô Lượng";
            dataGridView1.Columns[5].Name = "Tổng Tiền";
            dataGridView1.Columns[6].Name = "BarCode";
            dataGridView1.Rows.Clear();

            foreach (var x in _lstBusHoaDonChiTiets)
            {
                dataGridView1.Rows.Add(x.TenSanPham, x.MaHoaDon, x.DonGia, x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Đông", x.SoLuong, x.SoLuong * x.DonGia, x.BarCode);
            }
        }
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            // var _lst = (from a in _iServiceQlctSanPham.GetLstThongTinSanPhams() join b in _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS() on a.MaThongTin equals b.MaThongTin join c in _iServiceQlHoaDon.getLstHoaDonBUS() on b.MaHoaDon equals c.MaHoaDon
            //     group a by new
            //     {
            //
            //
            //         a.TenSanPham,
            //         a.Barcode,
            //         c.MaHoaDon,
            //         a.DonGia,
            //         a.SoLuong,
            //         b.TrangThai,
            //         c.ThanhTien
            //         
            //     }
            //     into g
            //     select new BUS_HoaDonChiTiet()
            //     {
            //         TenSanPham = g.Key.TenSanPham,
            //         BarCode = g.Key.Barcode,
            //         MaHoaDon = g.Key.MaHoaDon,
            //         DonGia = g.Key.DonGia,
            //         SoLuong = g.Key.SoLuong,
            //         TrangThai = g.Key.TrangThai,
            //         ThanhTien = g.Key.ThanhTien,
            //         // ThanhTien = g.
            //     }).ToList();
            dgrid_data.ColumnCount = 7;
            dgrid_data.Columns[0].Name = "Tên Sản Phẩm";
            dgrid_data.Columns[1].Name = "Mã Hóa Đơn";
            dgrid_data.Columns[2].Name = "Đơn Giá";
            dgrid_data.Columns[3].Name = "Trạng Thái";
            dgrid_data.Columns[4].Name = "Sô Lượng";
            dgrid_data.Columns[5].Name = "Tổng tiền";
            dgrid_data.Columns[6].Name = "Barcode";
            dgrid_data.Rows.Clear();
            foreach (var x in _iServiceQlHienThi.getLstBusHoaDonChiTiets().Where(c => c.BarCode.StartsWith(txtBarcode.Text)))
            {
                dgrid_data.Rows.Add(x.TenSanPham, x.MaHoaDon, x.DonGia, x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Đông", x.SoLuong, x.ThanhTien, x.BarCode);
            }
        }

        #region Camera
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cboCamera.Items.Add(device.Name);
                cboCamera.SelectedIndex = 0;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame; ; ;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                }));
            }

            pictureBox.Image = bitmap;
        }

        private void Frm_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }
        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }
        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            // dgrid_data.ColumnCount = 10;
            // dgrid_data.Columns[0].Name = "Mã Sản Phẩm";
            // foreach (var x in _iServiceQlctSanPham.GetLstThongTinSanPhams().Where(c=>c.Barcode.StartsWith(txtBarcode.Text)))
            // {
            //     dgrid_data.Rows.Add(x.MaSanPham);
            // }
        }
        #endregion




        private void dgrid_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = e.RowIndex;
            if (rowindex >= _iServiceQlctSanPham.GetLstThongTinSanPhams().Count || rowindex < 0) return;
            cbMaSanPham.Text = dgrid_data.Rows[rowindex].Cells[0].Value.ToString();
            flag = dgrid_data.Rows[rowindex].Cells[1].Value.ToString();
            txtDonGia.Text = dgrid_data.Rows[rowindex].Cells[2].Value.ToString();
            // rdb_DaThanhToan.Checked = Convert.ToInt32(dgrid_data.Rows[rowindex].Cells[3].Value.ToString())==1;
            // rdb_ChuaThanhToan.Checked = Convert.ToInt32(dgrid_data.Rows[rowindex].Cells[3].Value.ToString())==2;
            txt_soluong.Text = dgrid_data.Rows[rowindex].Cells[4].Value.ToString();
            lbTongTien.Text = dgrid_data.Rows[rowindex].Cells[5].Value.ToString();
            txtBarcode.Text = dgrid_data.Rows[rowindex].Cells[6].Value.ToString();


        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            _iServiceQlHoaDon.LuuHD();
            _iServiceQlHoaDonChiTiet.Luu();
            MessageBox.Show("Thanh Toán Thành Công");
        }

        #region Thêm

        // Thêm
        private void button1_Click(object sender, EventArgs e)
        {

            HoaDon hd = new HoaDon();
            HoaDonChiTiet hdct = new HoaDonChiTiet();
            hd.Id = _iServiceQlHoaDon.getLstHoaDonBUS().Max(c => c.Id) + 1;
            hd.MaHoaDon = "HD" + hd.Id;
            string MaHoaDon = hd.MaHoaDon;
            hd.MaNhanVien = "MNV1";
            hd.NgayXuat = DateTime.Today;
            hd.ThanhTien = float.Parse(lbTongTien.Text);
            hd.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;

            #region dem++

            if (dem == 0)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 1);
                dem++;
            }
            else if (dem == 1)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 2);
                dem++;
            }
            else if (dem == 2)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 3);
                dem++;
            }
            else if (dem == 3)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 4);
                dem++;
            }else if (dem == 4)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 5);
                dem++;
            }else if (dem == 5)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 6);
                dem++;
            }else if (dem == 6)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 7);
                dem++;
            }else if (dem == 7)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 8);
                dem++;
            }else if (dem == 8)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 9);
                dem++;
            }else if (dem == 9)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 10);
                dem++;
            }else if (dem == 10)
            {
                hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 11);
                dem++;
            }

            #endregion
            hdct.MaThongTin = _iServiceQlctSanPham.GetLstThongTinSanPhams().Where(c => c.TenSanPham == cbMaSanPham.Text).Select(c => c.MaThongTin).FirstOrDefault();
            hdct.MaHoaDonChiTiet = "HDCT" + hdct.Id;
            hdct.MaHoaDon = MaHoaDon;
            hdct.DonGia = float.Parse(txtDonGia.Text);
            hdct.SoLuong = Convert.ToInt32(txt_soluong.Text);
            hdct.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
            hdct.BarCode = txtBarcode.Text;
            hdct.TenSanPham = cbMaSanPham.Text;
            hdct.GhiChu = txtGhiChu.Text;
            if (dem == 1)
            {
                _iServiceQlHoaDon.ThemHD(hd);
            }
            _iServiceQlHoaDonChiTiet.ThemHDCT(hdct);
            MessageBox.Show("Thêm Thành Công");

            #region ren

            BUS_HoaDonChiTiet bus = new BUS_HoaDonChiTiet();
            bus.Id = hd.Id;
            bus.MaHoaDon = "HD" + hd.Id;
            bus.MaNhanVien = "MNV1";
            bus.NgayXuat = DateTime.Today;
            bus.ThanhTien = float.Parse(lbTongTien.Text);
            bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
            //bus.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
            bus.MaHoaDonChiTiet = "HDCT" + hd.Id;
            bus.MaHoaDon = hd.MaHoaDon;
            bus.DonGia = float.Parse(txtDonGia.Text);
            bus.SoLuong = Convert.ToInt32(txt_soluong.Text);
            bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
            bus.BarCode = txtBarcode.Text;
            bus.TenSanPham =cbMaSanPham.Text;
            bus.GhiChu = txtGhiChu.Text;
            _lstBusHoaDonChiTiets.Add(bus);
            Loaddata();
            #endregion
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sl = Convert.ToInt32(txt_soluong.Text);
                float dg = float.Parse(txtDonGia.Text);
                float tt = sl * dg;
                lbTongTien.Text = Convert.ToString(tt);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Số Lượng Quá Nhiều");
                txt_soluong.Text = "";
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {

        }
    }
}
