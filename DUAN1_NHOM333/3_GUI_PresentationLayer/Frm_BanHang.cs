using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;
using _2_BUS_BusinessLayer.BUS_Services;
using _2_BUS_BusinessLayer.BUS_Utilities;
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
        private IServiceHoaDon _iServiceHoaDon;
        private IServiceHoaDonChiTiet _iServiceHoaDonChiTiet;
        private CheckHoaDon checkHoaDon;
        #region TenBien
        public string flag;
        public string flag1;
        public double ThanhTien = 0;
        public int SoLuong = 1;
        public double ThanhTien1 = 0;
        public double TongTien = 0;
        public int ThemSoLuong1 = 0;
        public bool ThanhToan = false;
        public double DonGia;
        // cells click
        public int IDClick = 0;
        public string TenSanPhamClick;
        public double DonGiaClick = 0;
        public int SoLuongClick = 0;
        public double ThanhTienClick = 0;
        public string MaHoaDonClick;
        public string MaHoaDonChiTietClick;
        public string TenSanPhamClick1;
        public double DonGiaClick1 = 0;
        public string MaThongTinClick;
        public bool an = true;

        #endregion

        public Frm_BanHang()
        {
            checkHoaDon = new CheckHoaDon();
            _lstBusHoaDonChiTiets = new List<BUS_HoaDonChiTiet>();
            _iServiceQlHoaDon = new ServiceQLHoaDon();
            _iServiceQlHoaDonChiTiet = new ServiceQLHoaDonChiTiet();
            _iServiceQlctSanPham = new ServiceQLTTSanPham();
            _iServiceQlHienThi = new ServiceQLHienThi();
            _iServiceHoaDon = new ServiceHoaDon();
            _iServiceHoaDonChiTiet = new ServiceHoaDonChiTiet();
            InitializeComponent();
            SoLuong = Convert.ToInt32(nbr_SoLuong.Text);
            //Loaddata();
            grb_SanPham.Visible = true;
            grb_barcode.Visible = false;
            lbMahoadon.Visible = false;
            lbTenSanPham.Visible = false;
            lbDonGia.Visible = false;
            lbSoLuong.Visible = false;
            lb_Tongtien.Visible = false;
            lbTrangThai.Visible = false;
            LoaddataSanPham();
            //LoadView();
        }
        bool Check()
        {
            if (checkHoaDon.checkNull(nbr_SoLuong.Text))
            {
                MessageBox.Show(" Số Lượng Không Được Để Trống", "Thông Báo");
                return false;
            }
            return true;
        }
        void LoaddataSanPham()
        {
            dgidSanPham.ColumnCount = 3;
            dgidSanPham.Columns[0].Name = "Tên Sản Phẩm";
            dgidSanPham.Columns[1].Name = "Đơn Giá";
            //dgidSanPham.Columns[2].Name = "Sô Lượng ";
            //dgidSanPham.Columns[3].Name = "Thành Tiền";
            dgidSanPham.Columns[2].Name = "Mã Thông Tin";
            dgidSanPham.Columns[2].Visible = false;
            dgidSanPham.Rows.Clear();

            foreach (var x in _iServiceQlctSanPham.GetLstThongTinSanPhams().Where(c => c.Barcode.StartsWith(txtBarcode.Text)))
            {
                dgidSanPham.Rows.Add(x.TenSanPham, x.DonGia);
            }
            DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
            but1.Text = "Thêm Sản Phẩm";
            but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            but1.UseColumnTextForButtonValue = true;
            dgidSanPham.Columns.Add(but1);
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
                                         x.ThanhTien,
                                         x.MaHoaDonChiTiet,
                                         x.Id,


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
                                         MaHoaDonChiTiet = g.Key.MaHoaDonChiTiet,
                                         Id = g.Key.Id,
                                     }).ToList();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Name = "Đơn Giá";
            dataGridView1.Columns[2].Name = "Sô Lượng ";
            dataGridView1.Columns[3].Name = "Thành Tiền";
            dataGridView1.Columns[4].Name = "Mã Hóa Đơn";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Name = "Mã Hóa Đơn Chi Tiết";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Name = "ID HoaDonChiTiet";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Rows.Clear();
            foreach (var x in _lstBusHoaDonChiTiets)
            {
                dataGridView1.Rows.Add(x.TenSanPham, x.DonGia, x.SoLuong, x.ThanhTien, x.MaHoaDon, x.MaHoaDonChiTiet, x.Id);
            }
            DataGridViewButtonColumn but1 = new DataGridViewButtonColumn();
            but1.Text = "Sửa";
            but1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            but1.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn but2 = new DataGridViewButtonColumn();
            but2.Text = "Xóa";
            but2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            but2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(but1);
            dataGridView1.Columns.Add(but2);

        }
        void LoadView()
        {
            _iServiceHoaDon.GetLstFromDB();
            lv_HoaDon.Clear();
            foreach(var x in _iServiceHoaDon.GetLstHoaDon().Where(c=>c.TrangThai == 1 && c.NgayXuat == DateTime.Today))
            {
                
                lv_HoaDon.Items.Add(x.MaHoaDon);
                //lv_HoaDon.BackgroundImage.Width();
            }
        }

        private void TinhTien()
        {
            double TT = 0;
            foreach (var x in _lstBusHoaDonChiTiets)
            {
                TT += Convert.ToDouble(x.ThanhTien);


            }

            TongTien = TT;
        }
        public void ThemSoLuong(int sl)
        {
            ThemSoLuong1 = sl;
            MessageBox.Show(ThemSoLuong1.ToString());
        }
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Name = "Đơn Giá";
            dataGridView1.Columns[2].Name = "Sô Lượng ";
            dataGridView1.Columns[3].Name = "Thành Tiền";
            dataGridView1.Columns[4].Name = "Mã Thông Tin";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Rows.Clear();

            foreach (var x in _iServiceQlctSanPham.GetLstThongTinSanPhams().Where(c => c.Barcode.StartsWith(txtBarcode.Text)))
            {
                dataGridView1.Rows.Add(x.TenSanPham, x.DonGia, SoLuong, ThanhTien = Convert.ToDouble(x.DonGia * Convert.ToInt32(nbr_SoLuong.Text)));
                flag = x.TenSanPham;
                DonGia = Convert.ToDouble(x.DonGia);

            }
            LuuHoaDon();
            TinhTien();
            Loaddata();
            lbTongTien.Text = TongTien.ToString();
            LoadView();
        }


        public void SuaHoaDon()
        {

            HoaDon hd = new HoaDon();
            hd.MaHoaDon = flag1;
            hd.Id = _iServiceQlHoaDon.getLstHoaDonBUS().Max(c => c.Id) + 1;
            hd.MaNhanVien = "MNV1";
            hd.NgayXuat = DateTime.Today;
            hd.ThanhTien = TongTien;
            hd.TrangThai = 0;

            _iServiceHoaDon.SuaHD(hd);
            _iServiceHoaDon.LuuHD();

        }
        public void LuuHoaDon()
        {
            //if (Check() == true)
            //{
            //    return;
            //}
            //else
            //{
                HoaDon hd = new HoaDon();
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                hd.Id = _iServiceQlHoaDon.getLstHoaDonBUS().Max(c => c.Id) + 1;
                hd.MaHoaDon = "HD" + hd.Id;
                string MaHoaDon = hd.MaHoaDon;
                flag1 = hd.MaHoaDon;
                hd.MaNhanVien = "MNV1";
                hd.NgayXuat = DateTime.Today;
                hd.ThanhTien = ThanhTien;
                hd.TrangThai = 1;
                hdct.MaHoaDonChiTiet = "HDCT" + hdct.Id;

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
                }
                else if (dem == 4)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 5);
                    dem++;
                }
                else if (dem == 5)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 6);
                    dem++;
                }
                else if (dem == 6)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 7);
                    dem++;
                }
                else if (dem == 7)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 8);
                    dem++;
                }
                else if (dem == 8)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 9);
                    dem++;
                }
                else if (dem == 9)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 10);
                    dem++;
                }
                else if (dem == 10)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 11);
                    dem++;
                }
                else if (dem == 11)
                {
                    hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id + 12);
                    dem++;
                }

                #endregion

                hdct.MaHoaDonChiTiet = "HDCT" + hdct.Id;
                hdct.MaThongTin = _iServiceQlctSanPham.GetLstThongTinSanPhams()
                    .Where(c => c.TenSanPham == flag).Select(c => c.MaThongTin).FirstOrDefault();

                hdct.MaHoaDon = MaHoaDon;
                hdct.DonGia = DonGia;
                hdct.SoLuong = Convert.ToInt32(nbr_SoLuong.Text);
                hdct.TrangThai = 1;
                hdct.BarCode = txtBarcode.Text;
                hdct.TenSanPham = flag;
                hdct.GhiChu = "Không";
                if (dem == 1)
                {

                    _iServiceQlHoaDon.ThemHD(hd);
                    _iServiceQlHoaDon.LuuHD();
                }

                _iServiceQlHoaDonChiTiet.ThemHDCT(hdct);
                _iServiceQlHoaDonChiTiet.Luu();

                #region hienthi

                BUS_HoaDonChiTiet bus = new BUS_HoaDonChiTiet();
                bus.Id = hdct.Id;
                bus.MaHoaDon = "HD" + hd.Id;
                bus.MaNhanVien = "MNV1";
                bus.NgayXuat = DateTime.Today;
                bus.ThanhTien = ThanhTien;
                bus.TrangThai = 1;
                //bus.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
                bus.MaHoaDonChiTiet = hdct.MaHoaDonChiTiet;
                bus.MaHoaDon = hd.MaHoaDon;
                bus.DonGia = DonGia;
                bus.SoLuong = Convert.ToInt32(nbr_SoLuong.Text);
                bus.TrangThai = 1;
                bus.BarCode = txtBarcode.Text;
                bus.TenSanPham = flag;
                bus.GhiChu = "Không";
                _lstBusHoaDonChiTiets.Add(bus);


                 LoadView();
                #endregion


           // }
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
            if (ThanhToan == false)
            {
                if (MessageBox.Show("Bạn có muốn thanh toán hay không?", "Thông Báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ThanhToan = true;
                    this.Close();

                }

            }
        }
        private void lbTongTien_Click(object sender, EventArgs e)
        {

        }
        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {

        }
        #endregion





        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán hay không?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ThanhToan = true;
                SuaHoaDon();
                _iServiceQlHoaDonChiTiet.Luu();
                MessageBox.Show("Thanh Toán Thành Công");
            }
        }


        #region Thêm

        // Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn thêm hay không?", "Thông Báo", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    LuuHoaDon();
            //    TinhTien();
            //    lbTongTien.Text = TongTien.ToString();

            //}
            LoadView();

            /// LoadTen();
            #endregion
        }

        // #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }





        void LoadTen()
        {
            lbMahoadon.Visible = true;
            lbTenSanPham.Visible = true;
            lbDonGia.Visible = true;
            lbSoLuong.Visible = true;
            lb_Tongtien.Visible = true;
            lbTrangThai.Visible = true;

            _lstBusHoaDonChiTiets = (from x in _lstBusHoaDonChiTiets
                                     group x by new
                                     {


                                         x.TenSanPham,
                                         x.BarCode,
                                         x.MaHoaDon,
                                         x.DonGia,
                                         x.SoLuong,
                                         x.TrangThai,
                                         x.ThanhTien,
                                         x.MaHoaDonChiTiet,
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
                                         MaHoaDonChiTiet = g.Key.MaHoaDonChiTiet,
                                         // ThanhTien = g.
                                     }).ToList();
            foreach (var x in _lstBusHoaDonChiTiets)
            {
                lbMahoadon.Text = x.MaHoaDon;
                lbTenSanPham.Text = x.TenSanPham;
                lbDonGia.Text = Convert.ToString(x.DonGia);
                lbSoLuong.Text = Convert.ToString(x.SoLuong);
                lbTrangThai.Text = x.TrangThai == 0 ? "Đã Thanh Toán" : "Chưa Thanh Toán";
                lb_Tongtien.Text = lbTongTien.Text;
            }
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if ((rowindex == _lstBusHoaDonChiTiets.Count) || columnindex == -1 || rowindex == -1) return;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 7)

            {
                TenSanPhamClick = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                DonGiaClick = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[1].Value.ToString());
                SoLuongClick = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                ThanhTien = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[3].Value.ToString());
                MaHoaDonClick = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                MaHoaDonChiTietClick = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                IDClick = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[6].Value.ToString());
                #region SuaHienThi
                var a = _lstBusHoaDonChiTiets.Where(c => c.Id == IDClick).FirstOrDefault();
                _lstBusHoaDonChiTiets.Remove(a);
                BUS_HoaDonChiTiet bus = new BUS_HoaDonChiTiet();
                bus.Id = _lstBusHoaDonChiTiets.Where(c => c.TenSanPham == TenSanPhamClick).Select(c => c.Id).FirstOrDefault();

                bus.MaHoaDon = MaHoaDonClick;
                bus.MaNhanVien = "MNV1";
                bus.NgayXuat = DateTime.Today;
                bus.ThanhTien = DonGia * Convert.ToInt32(nbr_SoLuong.Text);
                bus.TrangThai = 1;
                //bus.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
                bus.MaHoaDonChiTiet = MaHoaDonChiTietClick;
                bus.DonGia = DonGia;
                bus.SoLuong = Convert.ToInt32(nbr_SoLuong.Text);
                bus.TrangThai = 1;
                bus.BarCode = txtBarcode.Text;
                bus.TenSanPham = TenSanPhamClick;
                bus.GhiChu = "Không";

                _lstBusHoaDonChiTiets.Add(bus);


                #endregion
                HoaDon hd = new HoaDon();
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                // hd = _iServiceQlHoaDon.getLstHoaDonBUS().Where(c => c.MaHoaDon == MaHoaDonClick).FirstOrDefault();
                hd.MaHoaDon = MaHoaDonClick;
                string mhd = MaHoaDonClick;
                hd.Id = _iServiceHoaDon.GetLstHoaDon().Max(c => c.Id) + 1;
                hd.MaNhanVien = "MNV1";
                hd.NgayXuat = DateTime.Today;
                hd.ThanhTien = TongTien;
                hd.TrangThai = 1;
                hdct.MaHoaDonChiTiet = MaHoaDonChiTietClick;
                string mhdct = hdct.MaHoaDonChiTiet;
                hdct.Id = IDClick;
                hdct.MaThongTin = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Where(c => c.TenSanPham == TenSanPhamClick).Select(c => c.MaThongTin).FirstOrDefault();
                hdct.MaHoaDon = MaHoaDonClick;
                hdct.DonGia = DonGiaClick;
                hdct.SoLuong = Convert.ToInt32(nbr_SoLuong.Text);
                hdct.TrangThai = 1;
                hdct.BarCode = txtBarcode.Text;
                hdct.TenSanPham = TenSanPhamClick;
                hdct.GhiChu = "Không";
                int bien = 0;
                if (bien == 0)
                {

                    _iServiceHoaDon.SuaHD(hd);
                    _iServiceHoaDon.LuuHD();
                    bien++;
                }
                _iServiceHoaDonChiTiet.SuaHDCT(hdct);
                _iServiceHoaDonChiTiet.LuuHDCT();

                TinhTien();
                LoadTen();
                Loaddata();
                lbTongTien.Text = TongTien.ToString();
            }
            // Click Xóa 
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 8)

            {
                TenSanPhamClick = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                DonGiaClick = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[1].Value.ToString());
                SoLuongClick = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                ThanhTien = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[3].Value.ToString());
                MaHoaDonClick = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                MaHoaDonChiTietClick = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                IDClick = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[6].Value.ToString());
                //var a = _lstBusHoaDonChiTiets.Where(c => c.MaHoaDonChiTiet == MaHoaDonChiTietClick).Select(c => c.Id).FirstOrDefault();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var a = _lstBusHoaDonChiTiets.Where(c => c.Id == IDClick).FirstOrDefault();
                    _lstBusHoaDonChiTiets.Remove(a);
                    _iServiceHoaDonChiTiet.XoaHDCT(MaHoaDonChiTietClick);
                    MessageBox.Show("Xóa Thành Công", "Thông Báo");
                    Loaddata();
                    LoadTen();
                    TinhTien();
                    LoadView();
                    lbTongTien.Text = TongTien.ToString();
                }
            }
        }

        private void btn_QuetMa_Click(object sender, EventArgs e)
        {

            if (an == true)
            {
                grb_barcode.Visible = true;
                grb_SanPham.Visible = false;
                btn_QuetMa.Text = "Sản Phẩm";
                an = false;
            }
            else if (an == false)
            {
                grb_SanPham.Visible = true;
                grb_barcode.Visible = false;
                btn_QuetMa.Text = "Quét Mã";
                an = true;
            }
        }


        private void dgidSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            int columnindex = e.ColumnIndex;
            if ((rowindex == _iServiceQlctSanPham.GetLstThongTinSanPhams().Count) || columnindex == -1 || rowindex == -1) return;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 3)

            {
                TenSanPhamClick1 = dgidSanPham.Rows[rowindex].Cells[0].Value.ToString();
                DonGiaClick1 = Convert.ToDouble(dgidSanPham.Rows[rowindex].Cells[1].Value.ToString());
               // MaThongTinClick = dgidSanPham.Rows[rowindex].Cells[2].Value.ToString();
                flag = TenSanPhamClick1;
                DonGia = DonGiaClick1;
                ThanhTien = DonGia * Convert.ToInt32(nbr_SoLuong.Text);
                LuuHoaDon();
                TinhTien();
                Loaddata();
                lbTongTien.Text = TongTien.ToString();
            }
        }
        #region Thừa
        private void Frm_BanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            // if (ThanhToan == false)
            // {
            //     if (MessageBox.Show("Bạn có muốn thanh toán hay không?", "Thông Báo", MessageBoxButtons.YesNo,
            //         MessageBoxIcon.Question) == DialogResult.Yes)
            //     {
            //         Close();
            //     }
            // }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtBarcode_KeyUp_1(object sender, KeyEventArgs e)
        {
            
        }
    }
}

