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
using _2_BUS_BusinessLayer.BUS_Services;
using _2_BUS_BusinessLayer.BUS_Utilities;
using AForge.Video.DirectShow;
using ZXing;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_ThongTinSanPham : Form
    {
        private IServiceQLCTSanPham _iQLCTSanPham;
        private IServiceQLLoaiHang _iServiceQLLoaiHang;
        private CheckHoaDon _Check;
        public Frm_ThongTinSanPham()
        {
            _iQLCTSanPham = new ServiceQLTTSanPham();
            _iServiceQLLoaiHang = new ServiceLoaiHang();
            _Check = new CheckHoaDon();
            InitializeComponent();
            LoadData();
            LoadCMBLoaiHang();
        }

        void LoadCMBLoaiHang()
        {
            foreach (var x in _iServiceQLLoaiHang.GetLstLoaiSanPham().ToList())
            {
                cbxLoaiHang.Items.Add(x.MaLoaiHang);
            }

            //cbxLoaiHang.SelectedIndex = 0;
        }
        bool CheckALl()
        {
            if (_Check.checkNull(txtGiaBan.Text))
            {
                MessageBox.Show(" Giá Bán Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_Check.checkNull(txtSoluong.Text))
            {
                MessageBox.Show(" Số Lượng Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_Check.checkNull(txtTrongLuong.Text))
            {
                MessageBox.Show(" Trọng Lượng Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_Check.checkNull(cbxDonViTinh.Text))
            {
                MessageBox.Show(" Dơn Vị Tính Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_Check.checkNull(cbxLoaiHang.Text))
            {
                MessageBox.Show(" Loại Hàng Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_Check.checkNull(cbxXuatXu.Text))
            {
                MessageBox.Show(" Xuất Xứ Không Được Để Trống", "Thông Báo");
                return false;
            }
            if (_Check.checkString(txtSoluong.Text))
            {
                MessageBox.Show(" Sô Lượng Không Được Chứa Kí Tự", "Thông Báo");
                return false;
            }
            if (_Check.checkString(txtTrongLuong.Text))
            {
                MessageBox.Show(" Trọng Lượng Không Được Chứa Kí Tự", "Thông Báo");
                return false;
            }
            if (_Check.checkString(txtGiaBan.Text))
            {
                MessageBox.Show(" Giá Bán Không Được Chứa Kí Tự", "Thông Báo");
                return false;
            }
            return true;

        }
        void LoadData()
        {
            dgid_Data.ColumnCount = 10;
            dgid_Data.Columns[0].Name = "Mã Sản Phẩm";
            dgid_Data.Columns[1].Name = "Dơn Giá";
            dgid_Data.Columns[2].Name = "Sô Lượng";
            dgid_Data.Columns[3].Name = "Trọng Lượng";
            dgid_Data.Columns[4].Name = "Trạng Thái";
            dgid_Data.Columns[5].Name = "BarCode";
            dgid_Data.Columns[6].Name = "Mã Đơn Vị Tính";
            dgid_Data.Columns[7].Name = "Mã Loại Hàng";
            dgid_Data.Columns[8].Name = "Mã Xuất Xứ";
            dgid_Data.Columns[9].Name = "Mô Tả";
            dgid_Data.Rows.Clear();
            foreach (var x in _iQLCTSanPham.GetLstThongTinSanPhams())
            {
                dgid_Data.Rows.Add(x.MaThongTin, x.DonGia, x.SoLuong, x.TrongLuong,
                    x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Đông", x.Barcode, x.MaDonViTinh, x.MaLoaiHang,
                    x.MaXuatXu, x.MoTa);
            }
        }
        private void dgid_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex == _iQLCTSanPham.GetLstThongTinSanPhams().Count || rowindex == -1) return;
            txtMaSanPham.Text = dgid_Data.Rows[rowindex].Cells[0].Value.ToString();
            txtGiaBan.Text = dgid_Data.Rows[rowindex].Cells[1].Value.ToString();
            txtSoluong.Text = dgid_Data.Rows[rowindex].Cells[2].Value.ToString();
            txtTrongLuong.Text = dgid_Data.Rows[rowindex].Cells[4].Value.ToString();
            txtBarcode.Text = dgid_Data.Rows[rowindex].Cells[5].Value.ToString();
            cbxDonViTinh.Text = dgid_Data.Rows[rowindex].Cells[6].Value.ToString();
            cbxLoaiHang.Text = dgid_Data.Rows[rowindex].Cells[7].Value.ToString();
            cbxXuatXu.Text = dgid_Data.Rows[rowindex].Cells[8].Value.ToString();
            txtMoTa.Text = dgid_Data.Rows[rowindex].Cells[9].Value.ToString();

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckALl() == true)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ThongTinSanPham sp = new ThongTinSanPham();
                    sp.Id = _iQLCTSanPham.GetLstThongTinSanPhams().Max(c => c.Id) + 1;
                    sp.MaThongTin = "MTT" + sp.Id;
                    sp.Barcode = txtBarcode.Text;
                    sp.TrangThai = 1;
                    sp.DonGia = Convert.ToInt32(txtGiaBan.Text);
                    sp.SoLuong = Convert.ToInt32(txtSoluong.Text);
                    sp.MaDonViTinh = cbxDonViTinh.Text;
                    sp.MaLoaiHang = cbxLoaiHang.Text;
                    sp.MaXuatXu = cbxXuatXu.Text;
                    sp.MoTa = txtMoTa.Text;
                    sp.MaSanPham = "MSP1";
                    sp.TrongLuong = Convert.ToDouble(txtTrongLuong.Text);
                    _iQLCTSanPham.ThemSP(sp);
                    _iQLCTSanPham.LuuSP();
                    MessageBox.Show("Thêm Thành Công");
                    LoadData();
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        } 
        #region Camera




        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        private void Frm_ThongTinSanPham_Load(object sender, EventArgs e)
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
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame; ;
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

        private void Frm_ThongTinSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                }
            }
        }




        #endregion

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            dgid_Data.ColumnCount = 1;
            dgid_Data.Columns[0].Name = "Đơn Giá";
            dgid_Data.Rows.Clear();
            foreach (var x in _iQLCTSanPham.GetLstThongTinSanPhams().Where(c => c.Barcode.StartsWith(txtBarcode.Text)))
            {
                dgid_Data.Rows.Add(x.DonGia, x.MaSanPham);
            }
        }
        #region Thừa
        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxXuatXu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrongLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_GiaoDien gd = new Frm_GiaoDien();
            this.Hide();
            gd.Show();
        }
    }
}
