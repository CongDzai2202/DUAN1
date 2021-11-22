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
        public string flag;
        public string flag1;
        public double ThanhTien = 0;
        public int SoLuong = 1;
        public double ThanhTien1 = 0;
        public double TongTien = 0;

        public double DonGia;

        public Frm_BanHang()
        {
            _lstBusHoaDonChiTiets = new List<BUS_HoaDonChiTiet>();
            _iServiceQlHoaDon = new ServiceQLHoaDon();
            _iServiceQlHoaDonChiTiet = new ServiceQLHoaDonChiTiet();
            _iServiceQlctSanPham = new ServiceQLTTSanPham();
            _iServiceQlHienThi = new ServiceQLHienThi();
            _iServiceHoaDon = new ServiceHoaDon();
            _iServiceHoaDonChiTiet = new ServiceHoaDonChiTiet();
            InitializeComponent();
            
            grb_barcode.Visible = false;
        }

        public void LoadCMBMaThongTin()
        {
            // foreach (var x in _iServiceQlctSanPham.GetLstThongTinSanPhams().ToList())
            // {
            //     cbMaSanPham.Items.Add(x.TenSanPham);
            // }
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

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Name = "Đơn Giá";
            dataGridView1.Columns[2].Name = "Sô Lượng ";
            dataGridView1.Columns[3].Name = "Thành Tiền";
            dataGridView1.Rows.Clear();
            foreach (var x in _lstBusHoaDonChiTiets)
            {
                dataGridView1.Rows.Add(x.TenSanPham, x.DonGia, x.SoLuong, x.ThanhTien);
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
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Tên Sản Phẩm";
            dataGridView1.Columns[1].Name = "Đơn Giá";
            dataGridView1.Columns[2].Name = "Sô Lượng ";
            dataGridView1.Columns[3].Name = "Thành Tiền";

            dataGridView1.Rows.Clear();
            
            foreach (var x in _iServiceQlctSanPham.GetLstThongTinSanPhams().Where(c => c.Barcode.StartsWith(txtBarcode.Text)))
            {
                dataGridView1.Rows.Add(x.TenSanPham, x.DonGia, SoLuong, ThanhTien = Convert.ToDouble(x.DonGia * SoLuong));
                flag = x.TenSanPham;
                DonGia = Convert.ToDouble(x.DonGia);
                
            }
            LuuHoaDon();
            TinhTien();
            Loaddata();
            MessageBox.Show(TongTien.ToString());




        }

        public void LuuHoaDon()
        {
            HoaDon hd = new HoaDon();
            HoaDonChiTiet hdct = new HoaDonChiTiet();
            hd.Id = _iServiceQlHoaDon.getLstHoaDonBUS().Max(c => c.Id) + 1;
            hd.MaHoaDon = "HD" + hd.Id;
            string MaHoaDon = hd.MaHoaDon;
            hd.MaNhanVien = "MNV1";
            hd.NgayXuat = DateTime.Today;
            hd.ThanhTien = ThanhTien;
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

            hdct.MaThongTin = _iServiceQlctSanPham.GetLstThongTinSanPhams()
                .Where(c => c.TenSanPham == flag).Select(c => c.MaThongTin).FirstOrDefault();
            hdct.MaHoaDonChiTiet = "HDCT" + hdct.Id;
            hdct.MaHoaDon = MaHoaDon;
            hdct.DonGia = DonGia;
            hdct.SoLuong = SoLuong;
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
            _iServiceHoaDonChiTiet.LuuHDCT();

            #region hienthi

            MessageBox.Show("Thêm Thành Công");
            BUS_HoaDonChiTiet bus = new BUS_HoaDonChiTiet();
            bus.Id = hd.Id;
            bus.MaHoaDon = "HD" + hd.Id;
            bus.MaNhanVien = "MNV1";
            bus.NgayXuat = DateTime.Today;
            bus.ThanhTien = ThanhTien;
            bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
            //bus.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
            bus.MaHoaDonChiTiet = "HDCT" + hd.Id;
            bus.MaHoaDon = hd.MaHoaDon;
            bus.DonGia = DonGia;
            bus.SoLuong = SoLuong;
            bus.TrangThai = 1;
            bus.BarCode = txtBarcode.Text;
            bus.TenSanPham = flag;
            bus.GhiChu ="Không";
            _lstBusHoaDonChiTiets.Add(bus);
           

#endregion
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

            // int rowindex = e.RowIndex;
            // if (rowindex >= _iServiceQlctSanPham.GetLstThongTinSanPhams().Count || rowindex < 0) return;
            // int rowindex1 = e.RowIndex;
            // if (rowindex1 >= _iServiceQlHoaDon.getLstHoaDonBUS().Count || rowindex1 < 0) return;
            // int rowindex2 = e.RowIndex;
            // if (rowindex2 >= _iServiceHoaDonChiTiet.GetHoaDonChiTiets().Count || rowindex2 < 0) return;
            //cbMaSanPham.Text = dgrid_data.Rows[rowindex].Cells[0].Value.ToString();
            // txtMHDCT.Text= dgrid_data.Rows[rowindex1].Cells[1].Value.ToString();
            //txtDonGia.Text = dgrid_data.Rows[rowindex].Cells[2].Value.ToString();
            // rdb_DaThanhToan.Checked = Convert.ToInt32(dgrid_data.Rows[rowindex].Cells[3].Value.ToString())==1;
            // rdb_ChuaThanhToan.Checked = Convert.ToInt32(dgrid_data.Rows[rowindex].Cells[3].Value.ToString())==2;
            // txt_soluong.Text = dgrid_data.Rows[rowindex].Cells[4].Value.ToString();
            // lbTongTien.Text = dgrid_data.Rows[rowindex].Cells[5].Value.ToString();
            // txtBarcode.Text = dgrid_data.Rows[rowindex].Cells[6].Value.ToString();
            // flag1 = dgrid_data.Rows[rowindex2].Cells[7].Value.ToString();
            // //flag = txtMHDCT.Text;

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán hay không?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _iServiceQlHoaDonChiTiet.Luu();
                MessageBox.Show("Thanh Toán Thành Công");
            }
        }


        #region Thêm

        // Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm hay không?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
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

                // hdct.MaThongTin = _iServiceQlctSanPham.GetLstThongTinSanPhams()
                //     .Where(c => c.TenSanPham == cbMaSanPham.Text).Select(c => c.MaThongTin).FirstOrDefault();
                // hdct.MaHoaDonChiTiet = "HDCT" + hdct.Id;
                // hdct.MaHoaDon = MaHoaDon;
                // hdct.DonGia = float.Parse(txtDonGia.Text);
                // hdct.SoLuong = Convert.ToInt32(txt_soluong.Text);
                // hdct.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                // hdct.BarCode = txtBarcode.Text;
                // hdct.TenSanPham = cbMaSanPham.Text;
                // hdct.GhiChu = txtGhiChu.Text;
                // if (dem == 1)
                // {
                //     _iServiceQlHoaDon.ThemHD(hd);
                //     _iServiceQlHoaDon.LuuHD();
                // }
                //
                // _iServiceQlHoaDonChiTiet.ThemHDCT(hdct);
                // MessageBox.Show("Thêm Thành Công");
                //
                // #region ren
                //
                // BUS_HoaDonChiTiet bus = new BUS_HoaDonChiTiet();
                // bus.Id = hd.Id;
                // bus.MaHoaDon = "HD" + hd.Id;
                // bus.MaNhanVien = "MNV1";
                // bus.NgayXuat = DateTime.Today;
                // bus.ThanhTien = float.Parse(lbTongTien.Text);
                // bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                // //bus.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
                // bus.MaHoaDonChiTiet = "HDCT" + hd.Id;
                // bus.MaHoaDon = hd.MaHoaDon;
                // bus.DonGia = float.Parse(txtDonGia.Text);
                // bus.SoLuong = Convert.ToInt32(txt_soluong.Text);
                // bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                // bus.BarCode = txtBarcode.Text;
                // bus.TenSanPham = cbMaSanPham.Text;
                // bus.GhiChu = txtGhiChu.Text;
                // _lstBusHoaDonChiTiets.Add(bus);
            }

        
            LoadTen();
            #endregion
        }

        // #endregion

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm hay không?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HoaDon hd = new HoaDon();

                //hd = _iServiceHoaDon.GetLstHoaDon().Where(c => c.MaHoaDon == txtMHDCT.Text).FirstOrDefault();
                hd.MaHoaDon = flag;
                hd.Id = _iServiceQlHoaDon.getLstHoaDonBUS().Max(c => c.Id) + 1;
                hd.MaNhanVien = "MNV1";
                hd.NgayXuat = DateTime.Today;
                hd.ThanhTien = float.Parse(lbTongTien.Text);
                hd.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                HoaDonChiTiet hdct = new HoaDonChiTiet();
                // var a = _iServiceHoaDonChiTiet.GetHoaDonChiTiets().Where(c => c.MaHoaDon == flag)
                //     .Select(c => c.MaHoaDonChiTiet).FirstOrDefault();
                // hdct = _iServiceHoaDonChiTiet.GetHoaDonChiTiets().Where(c => c.MaHoaDonChiTiet == a).FirstOrDefault();
                // hdct.MaHoaDonChiTiet = flag1;
                // hdct.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
                // hdct.MaThongTin = _iServiceQlctSanPham.GetLstThongTinSanPhams()
                //     .Where(c => c.TenSanPham == cbMaSanPham.Text).Select(c => c.MaThongTin).FirstOrDefault();
                // hdct.MaHoaDon = flag;
                // hdct.DonGia = float.Parse(txtDonGia.Text);
                // hdct.SoLuong = Convert.ToInt32(txt_soluong.Text);
                // hdct.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                // hdct.BarCode = txtBarcode.Text;
                // hdct.TenSanPham = cbMaSanPham.Text;
                // hdct.GhiChu = txtGhiChu.Text;
                // _iServiceHoaDon.SuaHD(hd);
                // _iServiceHoaDon.LuuHD();
                // _iServiceHoaDonChiTiet.SuaHDCT(hdct);
                // _iServiceHoaDonChiTiet.LuuHDCT();
                // MessageBox.Show("Sửa Thành Công");
                // // List Hiển Thị
                // BUS_HoaDonChiTiet bus = new BUS_HoaDonChiTiet();
                // bus.Id = hd.Id;
                // bus.MaHoaDon = "HD" + hd.Id;
                // bus.MaNhanVien = "MNV1";
                // bus.NgayXuat = DateTime.Today;
                // bus.ThanhTien = float.Parse(lbTongTien.Text);
                // bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                // //bus.Id = _iServiceQlHoaDonChiTiet.getLstHoaDonChiTietBUS().Max(c => c.Id) + 1;
                // bus.MaHoaDonChiTiet = "HDCT" + hd.Id;
                // bus.MaHoaDon = hd.MaHoaDon;
                // bus.DonGia = float.Parse(txtDonGia.Text);
                // bus.SoLuong = Convert.ToInt32(txt_soluong.Text);
                // bus.TrangThai = rdb_DaThanhToan.Checked ? 1 : 2;
                // bus.BarCode = txtBarcode.Text;
                // bus.TenSanPham = cbMaSanPham.Text;
                // bus.GhiChu = txtGhiChu.Text;
                // _lstBusHoaDonChiTiets.Add(bus);
            }

            Loaddata();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // int sl = Convert.ToInt32(txt_soluong.Text);
                // float dg = float.Parse(txtDonGia.Text);
                // float tt = sl * dg;
                // lbTongTien.Text = Convert.ToString(tt);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Số Lượng Quá Nhiều");
                txt_soluong.Text = "";
            }
        }

        void LoadTen()
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
                lbTrangThai.Text = x.TrangThai == 1 ? "Đã Thanh Toán" : "Chưa Thanh Toán";
                lb_Tongtien.Text = Convert.ToString(x.ThanhTien);
            }
        }
        private void btn_NhapLai_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //     int rowindex = e.RowIndex;
            //     if (rowindex >= _iServiceQlctSanPham.GetLstThongTinSanPhams().Count || rowindex < 0) return;
            //     //cbMaSanPham.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            //     //txtMHDCT.Text = dgrid_data.Rows[rowindex].Cells[1].Value.ToString();
            //     //txtDonGia.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            //     // rdb_DaThanhToan.Checked = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString())==1 ? true:false;
            //     // rdb_ChuaThanhToan.Checked = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[2].Value.ToString())==2? true:false;
            //     //lbTongTien.Text = dgrid_data.Rows[rowindex].Cells[5].Value.ToString();
            //     txtBarcode.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString(); ;

        }

        private void btn_QuetMa_Click(object sender, EventArgs e)
        {
            grb_barcode.Visible = true;
        }
    }
}
