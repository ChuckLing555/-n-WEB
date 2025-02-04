using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using System.Windows.Forms.DataVisualization.Charting;

namespace LIZARDMONEY
{
    public partial class frmThongKe : Form
    {
        private ThongKeBUS thongKeBUS;
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            //Chi ngày
            // Khởi tạo đối tượng BUS
            thongKeBUS = new ThongKeBUS();

            DateTime ngayHienTai = DateTime.Now.Date;
            List<ChiTietGiaoDichDTO> danhSachGiaoDich = thongKeBUS.layDSBUS();

            List<ChiTietGiaoDichDTO> danhSachGiaoDichTrongNgay = danhSachGiaoDich
            .Where(gd => gd.ngayGD.Date == ngayHienTai)
            .ToList();
            // Tính tổng số tiền
            float tongTien = 0;
            foreach (var giaoDich in danhSachGiaoDichTrongNgay)
            {
                tongTien += giaoDich.soTien;
            }

            // Hiển thị tổng số tiền lên label
            lbTongNgay.Text = $"{tongTien}";


            //Chi tuần
            DateTime ngayBatDauTuan = ngayHienTai.AddDays(-(int)ngayHienTai.DayOfWeek); // Ngày đầu tuần (Thứ 2)
            DateTime ngayKetThucTuan = ngayBatDauTuan.AddDays(6); // Ngày cuối tuần (Chủ nhật)


            // Lọc danh sách giao dịch theo khoảng thời gian của tuần
            List<ChiTietGiaoDichDTO> danhSachGiaoDichTrongTuan = danhSachGiaoDich
                .Where(gd => gd.ngayGD >= ngayBatDauTuan && gd.ngayGD <= ngayKetThucTuan)
                .ToList();

            // Tính tổng số tiền trong tuần
            float tongTienTuan = 0;
            foreach (var giaoDich in danhSachGiaoDichTrongTuan)
            {
                tongTienTuan += giaoDich.soTien;
            }

            // Hiển thị tổng số tiền lên label
            lbTongTuan.Text = $"{tongTienTuan}";


            //Chi tháng
            DateTime ngayDauThang = new DateTime(ngayHienTai.Year, ngayHienTai.Month, 1);
            DateTime ngayCuoiThang = ngayDauThang.AddMonths(1).AddDays(-1);

            // Lọc danh sách giao dịch để chỉ lấy ra những giao dịch diễn ra trong tháng hiện tại
            List<ChiTietGiaoDichDTO> danhSachGiaoDichTrongThang = danhSachGiaoDich
                .Where(gd => gd.ngayGD.Date >= ngayDauThang && gd.ngayGD.Date <= ngayCuoiThang)
                .ToList();

            // Tính tổng số tiền trong tháng
            float tongTienThang = 0;
            foreach (var giaoDich in danhSachGiaoDichTrongThang)
            {
                tongTienThang += giaoDich.soTien;
            }

            // Hiển thị tổng số tiền lên label
            lbTongThang.Text = $"{tongTienThang}";

            HienThiBieuDoNgay();
        }
        private void HienThiBieuDoNgay()
        {
            // Xóa dữ liệu cũ trên biểu đồ
            chart1.Series["Thống kê tuần"].Points.Clear();
            chart1.Series["Thống kê tháng"].Points.Clear();

            List<ChiTietGiaoDichDTO> danhSachGiaoDich = thongKeBUS.layDSBUS();
            List<float> tongTienNgay = new List<float>();

            DateTime ngayHienTai = DateTime.Now.Date;

            float tongTienTrongNgay = TinhTongTienTrongNgay(danhSachGiaoDich, ngayHienTai);

            tongTienNgay.Add(tongTienTrongNgay);

            // Thiết lập dữ liệu cho biểu đồ
            chart1.Series["Thống kê ngày"].Points.Clear();
            chart1.Series["Thống kê ngày"].Points.AddXY(ngayHienTai.ToString("dd/MM"), tongTienTrongNgay);

            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Số tiền";
        }

        private void HienThiBieuDoTuan()
        {
            chart1.Series["Thống kê ngày"].Points.Clear();
            chart1.Series["Thống kê tháng"].Points.Clear();

            List<ChiTietGiaoDichDTO> danhSachGiaoDich = thongKeBUS.layDSBUS();
            DateTime ngayHienTai = DateTime.Now.Date;

            DateTime ngayDauTuan = ngayHienTai.AddDays(-(int)ngayHienTai.DayOfWeek);
            DateTime ngayCuoiTuan = ngayDauTuan.AddDays(6);

            var giaoDichTrongTuan = danhSachGiaoDich.Where(gd => gd.ngayGD >= ngayDauTuan && gd.ngayGD <= ngayCuoiTuan).ToList();
            List<float> tongTienNgay = new List<float>();

            for (DateTime ngay = ngayDauTuan; ngay <= ngayCuoiTuan; ngay = ngay.AddDays(1))
            {
                float tongTienTrongNgay = TinhTongTienTrongNgay(giaoDichTrongTuan, ngay);

                // Thêm tổng số tiền vào danh sách
                tongTienNgay.Add(tongTienTrongNgay);
            }

            // Thiết lập dữ liệu cho biểu đồ
            for (int i = 0; i < tongTienNgay.Count; i++)
            {
                string ngayHienThi = ngayDauTuan.AddDays(i).ToString("dd/MM");
                chart1.Series["Thống kê ngày"].Points.AddXY(ngayHienThi, tongTienNgay[i]);
            }

            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Số tiền";
        }

        private void HienThiBieuDoThang()
        {
            // Xóa dữ liệu cũ trên biểu đồ
            chart1.Series["Thống kê ngày"].Points.Clear();
            chart1.Series["Thống kê tuần"].Points.Clear();

            List<ChiTietGiaoDichDTO> danhSachGiaoDich = thongKeBUS.layDSBUS();
            DateTime ngayHienTai = DateTime.Now.Date;

            int soNgayTrongThang = DateTime.DaysInMonth(ngayHienTai.Year, ngayHienTai.Month);
            for (int i = 1; i <= soNgayTrongThang; i++)
            {
                DateTime ngayCanTinh = new DateTime(ngayHienTai.Year, ngayHienTai.Month, i);

                float tongTienTrongNgay = TinhTongTienTrongNgay(danhSachGiaoDich, ngayCanTinh);

                string ngayHienThi = new DateTime(ngayHienTai.Year, ngayHienTai.Month, i).ToString("dd/MM");
                chart1.Series["Thống kê tháng"].Points.AddXY(ngayHienThi, tongTienTrongNgay);
            }

            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Số tiền";
        }



        private float TinhTongTienTrongNgay(List<ChiTietGiaoDichDTO> danhSachGiaoDich, DateTime ngayCanTinh)
        {
            // Lọc danh sách giao dịch để chỉ lấy ra những giao dịch diễn ra trong ngày cần kiểm tra
            List<ChiTietGiaoDichDTO> giaoDichTrongNgay = danhSachGiaoDich
                .Where(gd => gd.ngayGD.Date == ngayCanTinh)
                .ToList();

            // Tính tổng số tiền từ danh sách giao dịch đã lọc
            float tongTien = 0;
            foreach (var giaoDich in giaoDichTrongNgay)
            {
                tongTien += giaoDich.soTien;
            }

            return tongTien;
        }
        private float TinhTongTienTrongTuan(List<ChiTietGiaoDichDTO> danhSachGiaoDich, DateTime ngayCanTinh)
        {
            // Lọc danh sách giao dịch để chỉ lấy ra những giao dịch diễn ra trong tuần cần kiểm tra
            List<ChiTietGiaoDichDTO> giaoDichTrongTuan = danhSachGiaoDich
                .Where(gd => gd.ngayGD.Date >= ngayCanTinh.Date.AddDays(-6) && gd.ngayGD.Date <= ngayCanTinh.Date)
                .ToList();

            // Tính tổng số tiền từ danh sách giao dịch đã lọc
            float tongTien = 0;
            foreach (var giaoDich in giaoDichTrongTuan)
            {
                tongTien += giaoDich.soTien;
            }

            return tongTien;
        }

        private float TinhTongTienTrongThang(List<ChiTietGiaoDichDTO> danhSachGiaoDich, DateTime ngayCanTinh)
        {
            // Lọc danh sách giao dịch để chỉ lấy ra những giao dịch diễn ra trong tháng cần kiểm tra
            List<ChiTietGiaoDichDTO> giaoDichTrongThang = danhSachGiaoDich
                .Where(gd => gd.ngayGD.Year == ngayCanTinh.Year && gd.ngayGD.Month == ngayCanTinh.Month)
                .ToList();

            // Tính tổng số tiền từ danh sách giao dịch đã lọc
            float tongTien = 0;
            foreach (var giaoDich in giaoDichTrongThang)
            {
                tongTien += giaoDich.soTien;
            }

            return tongTien;
        }

        private void rdoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNgay.Checked)
            {
                HienThiBieuDoNgay();
            }
        }

        private void rdoTuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTuan.Checked)
            {
                HienThiBieuDoTuan();
            }
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThang.Checked)
            {
                HienThiBieuDoThang();
            }

        }

    }
}
