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
using AForge.Video.DirectShow;
using ZXing;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_ThongTinSanPham : Form
    {
        private IServiceQLCTSanPham _iQLCTSanPham;
        private IServiceQLLoaiHang _iServiceQLLoaiHang;
        public Frm_ThongTinSanPham()
        {
            _iQLCTSanPham = new ServiceQLTTSanPham();
            _iServiceQLLoaiHang = new ServiceLoaiHang();
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

        void LoadData()
        {
            dgid_Data.ColumnCount = 10;
            dgid_Data.Columns[0].Name = "Mã Sản Phẩm";
            dgid_Data.Columns[1].Name = "Dơn Giá";
            dgid_Data.Columns[2].Name = "Sô Lượng";
            dgid_Data.Columns[3].Name = "Trạng Thái";
            dgid_Data.Columns[4].Name = "BarCode";
            dgid_Data.Columns[5].Name = "Mã Đơn Vị Tính";
            dgid_Data.Columns[6].Name = "Mã Loại Hàng";
            dgid_Data.Columns[7].Name = "Mã Xuất Xứ";
            dgid_Data.Columns[8].Name = "Trọng Lượng";
            dgid_Data.Columns[9].Name = "Mô Tả";
            dgid_Data.Rows.Clear();
            foreach (var x in _iQLCTSanPham.GetLstThongTinSanPhams())
            {
                dgid_Data.Rows.Add(x.MaThongTin, x.DonGia, x.SoLuong,
                    x.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Đông", x.Barcode, x.MaDonViTinh, x.MaLoaiHang,
                    x.MaXuatXu,x.TrongLuong, x.MoTa);
            }
        }
        private void dgid_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (rowindex >= _iQLCTSanPham.GetLstThongTinSanPhams().Count || rowindex < 0) return;
            txtMaSanPham.Text = dgid_Data.Rows[rowindex].Cells[0].Value.ToString();
            txtGiaBan.Text = dgid_Data.Rows[rowindex].Cells[1].Value.ToString();
            txtSoluong.Text = dgid_Data.Rows[rowindex].Cells[2].Value.ToString();
            txtBarcode.Text = dgid_Data.Rows[rowindex].Cells[4].Value.ToString();
            cbxDonViTinh.Text = dgid_Data.Rows[rowindex].Cells[5].Value.ToString();
            cbxXuatXu.Text = dgid_Data.Rows[rowindex].Cells[7].Value.ToString();
            cbxLoaiHang.Text = dgid_Data.Rows[rowindex].Cells[6].Value.ToString();
            txtTrongLuong.Text = dgid_Data.Rows[rowindex].Cells[8].Value.ToString();
            txtMoTa.Text = dgid_Data.Rows[rowindex].Cells[9].Value.ToString();

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThongTinSanPham sp = new ThongTinSanPham();
            sp.Id = _iQLCTSanPham.GetLstThongTinSanPhams().Max(c => c.Id) + 1;
            sp.MaThongTin = "MTTSP" + sp.Id;
            sp.Barcode = txtBarcode.Text;
            sp.TrangThai = 1;
            sp.DonGia = Convert.ToInt32(txtGiaBan.Text);
            sp.SoLuong = Convert.ToInt32(txtSoluong.Text);
            sp.MaDonViTinh = cbxDonViTinh.Text;
            sp.MaLoaiHang = cbxLoaiHang.Text;
            sp.MaXuatXu = cbxXuatXu.Text;
            sp.MoTa = txtMoTa.Text;
            sp.MaSanPham = "SP1";
            sp.TrongLuong = Convert.ToDouble(txtTrongLuong.Text);
            _iQLCTSanPham.ThemSP(sp);
            _iQLCTSanPham.LuuSP();
            MessageBox.Show("Thêm Thành Công");

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

       
    }
}
