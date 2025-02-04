using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace LIZARDMONEY
{
    public partial class frmXemBaoCao : Form
    {
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        userTaiKhoanBUS viTien = new userTaiKhoanBUS();
        userReportBUS reportBUS = new userReportBUS();
        public int idNguoiDung;
        public string tenNguoiDung;
        public int nhom;

        public void BCViTien()
        {
            List<TaiKhoanDTO> dsViTien = viTien.dsTaiKhoanBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCViTien.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSViTien", dsViTien));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.RefreshReport();
        }

        public void BCChiTieu()
        {
            List<ReportGiaoDichDTO> dsChiTieu = reportBUS.dsChiTieuBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGiaoDich.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSChiTietGiaoDich", dsChiTieu));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "CHI TIÊU"));
            this.repBaoCao.RefreshReport();
        }

        public void BCThuNhap()
        {
            List<ReportGiaoDichDTO> dsThuNhap = reportBUS.dsThuNhapBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGiaoDich.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSChiTietGiaoDich", dsThuNhap));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "THU NHẬP"));
            this.repBaoCao.RefreshReport();
        }

        public void BCKhoanVay()
        {
            List<ReportVayTraDTO> dsCKhoanVay = reportBUS.dsKhoanChoVayBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCKhoanVayTra.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSKhoanVayTra", dsCKhoanVay));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoi", "Người Vay"));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pVayTra", "KHOẢN VAY"));
            this.repBaoCao.RefreshReport();
        }

        public void BCKhoanNo()
        {
            List<ReportVayTraDTO> dsKhoanNo = reportBUS.dsKhoanBiNoBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCKhoanVayTra.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSKhoanVayTra", dsKhoanNo));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoi", "Người Mượn Nợ"));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pVayTra", "KHOẢN NỢ"));
            this.repBaoCao.RefreshReport();
        }

        public void BCGiaoDichTheoLoaiGD_CT(LoaiChiTieuDTO giaoDich)
        {
            List<ReportGiaoDichDTO> dsChiTieuTheoLoaiCT = reportBUS.dsChiTieuTheoLoaiCTBUS(idNguoiDung, giaoDich.maLoai);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGDTheoLoaiGD.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSGDTheoLoaiGD", dsChiTieuTheoLoaiCT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pLoaiGiaoDich", giaoDich.tenChiTieu));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "CHI TIÊU"));

            this.repBaoCao.RefreshReport();
        }

        public void BCGiaoDichTheoLoaiGD_TN(LoaiThuNhapDTO giaoDich)
        {
            List<ReportGiaoDichDTO> dsThuNhapTheoLoaiTN = reportBUS.dsThuNhapTheoLoaiTNBUS(idNguoiDung, giaoDich.maLoai);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGDTheoLoaiGD.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSGDTheoLoaiGD", dsThuNhapTheoLoaiTN));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pLoaiGiaoDich", giaoDich.tenThuNhap));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "THU NHẬP"));

            this.repBaoCao.RefreshReport();
        }

        public void BCGiaoDichTheoLoaiVT_TN(TaiKhoanDTO giaoDich)
        {
            List<ReportGiaoDichDTO> dsThuNhapTheoLoaiVT = reportBUS.dsThuNhapTheoLoaiVTBUS(idNguoiDung, giaoDich.maTaiKhoan);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGDTheoLoaiVT.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSGDTheoLoaiVT", dsThuNhapTheoLoaiVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pLoaiVT", giaoDich.tenTaiKhoan));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "THU NHẬP"));

            this.repBaoCao.RefreshReport();
        }

        public void BCGiaoDichTheoLoaiVT_CT(TaiKhoanDTO giaoDich)
        {
            List<ReportGiaoDichDTO> dsChiTieuTheoLoaiVT = reportBUS.dsChiTieuTheoLoaiVTBUS(idNguoiDung, giaoDich.maTaiKhoan);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGDTheoLoaiVT.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSGDTheoLoaiVT", dsChiTieuTheoLoaiVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pLoaiVT", giaoDich.tenTaiKhoan));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "CHI TIÊU"));

            this.repBaoCao.RefreshReport();
        }

        public void BCKhoanVayTheoLoaiVT(TaiKhoanDTO giaoDich)
        {
            List<ReportVayTraDTO> dsCKhoanVayTheoLoaiVT = reportBUS.dsKhoanChoVayTheoLoaiVTBUS(idNguoiDung, giaoDich.maTaiKhoan);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCKVTheoLoaiVT.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSKVTheoLoaiVT", dsCKhoanVayTheoLoaiVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoi", "Người Vay"));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pViTien", giaoDich.tenTaiKhoan));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pKVT", "KHOẢN VAY"));
            this.repBaoCao.RefreshReport();
        }

        public void BCKhoanNoTheoLoaiVT(TaiKhoanDTO giaoDich)
        {
            List<ReportVayTraDTO> dsKhoanNoTheoLoaiVT = reportBUS.dsKhoanBiNoTheoLoaiVTBUS(idNguoiDung, giaoDich.maTaiKhoan);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCKVTheoLoaiVT.rdlc";
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSKVTheoLoaiVT", dsKhoanNoTheoLoaiVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoi", "Người Mượn Nợ"));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pViTien", giaoDich.tenTaiKhoan));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pKVT", "KHOẢN NỢ"));
            this.repBaoCao.RefreshReport();
        }

        public void BCChiTieuTheoNhomVT()
        {
            List<TaiKhoanDTO> dsChiTieuTheoNhomVT = viTien.dsTaiKhoanBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGDTheoNhomVT.rdlc";
            this.repBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSGDNhomTheoVT", dsChiTieuTheoNhomVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "CHI TIÊU"));
            this.repBaoCao.RefreshReport();
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            //throw new NotImplementedException();

            int maVT = int.Parse(e.Parameters["pMaLoaiVT"].Values[0]);
            switch (nhom)
            {
                case 1:
                    e.DataSources.Add(new ReportDataSource("DSGDNhomTheoVTsub", reportBUS.dsChiTieuTheoLoaiVTBUS(idNguoiDung, maVT)));
                    break;
                case 2:
                    e.DataSources.Add(new ReportDataSource("DSGDNhomTheoVTsub", reportBUS.dsThuNhapTheoLoaiVTBUS(idNguoiDung, maVT)));
                    break;
                case 3:
                    e.DataSources.Add(new ReportDataSource("DSKVTTheoNhomVTsub", reportBUS.dsKhoanChoVayTheoLoaiVTBUS(idNguoiDung, maVT)));
                    break;
                case 4:
                    e.DataSources.Add(new ReportDataSource("DSKVTTheoNhomVTsub", reportBUS.dsKhoanBiNoTheoLoaiVTBUS(idNguoiDung, maVT)));
                    break;
            }
        }

        public void BCThuNhapTheoNhomVT()
        {
            List<TaiKhoanDTO> dsThuNhapTheoNhomVT = viTien.dsTaiKhoanBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCGDTheoNhomVT.rdlc";
            this.repBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSGDNhomTheoVT", dsThuNhapTheoNhomVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pGiaoDich", "THU NHẬP"));
            this.repBaoCao.RefreshReport();
        }

        public void BCKhoanVayTheoNhomVT()
        {
            List<TaiKhoanDTO> dsKhoanVayTheoNhomVT = viTien.dsTaiKhoanBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCKVTTheoNhomVT.rdlc";
            this.repBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSKVTTheoNhomVT", dsKhoanVayTheoNhomVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pKVT", "KHOẢN VAY"));
            this.repBaoCao.RefreshReport();
        }

        public void BCKhoanNoTheoNhomVT()
        {
            List<TaiKhoanDTO> dsKhoanNoTheoNhomVT = viTien.dsTaiKhoanBUS(idNguoiDung);
            this.repBaoCao.LocalReport.ReportPath = @"..\..\rpBCKVTTheoNhomVT.rdlc";
            this.repBaoCao.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
            this.repBaoCao.LocalReport.DataSources.Add(new ReportDataSource("DSKVTTheoNhomVT", dsKhoanNoTheoNhomVT));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pNgayLap", DateTime.Now.ToString()));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pTenNguoiDung", tenNguoiDung));
            this.repBaoCao.LocalReport.SetParameters(new ReportParameter("pKVT", "KHOẢN NỢ"));
            this.repBaoCao.RefreshReport();
        }
    }
}
