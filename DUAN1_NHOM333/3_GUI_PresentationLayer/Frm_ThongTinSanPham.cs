using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;
using AForge.Video.DirectShow;
using ZXing;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_ThongTinSanPham : Form
    {
        private IServiceQLCTSanPham _iQLCTSanPham;
        public Frm_ThongTinSanPham()
        {
            _iQLCTSanPham = new ServiceQLTTSanPham();
            InitializeComponent();
            LoadData();
        }

        void LoadCMBLoaiHang()
        {
            
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
                    x.TrongLuong, x.MoTa);
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
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
