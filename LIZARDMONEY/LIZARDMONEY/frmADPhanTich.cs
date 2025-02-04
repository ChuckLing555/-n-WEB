using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LIZARDMONEY
{
    public partial class frmADPhanTich : Form
    {
        public frmADPhanTich()
        {
            InitializeComponent();
        }

        private static string soLanFile = "soLanLogin.txt";

        private static Dictionary<string, int> soLanLogin()
        {
            var loginCounts = new Dictionary<string, int>();
            if (File.Exists(soLanFile))
            {
                var lines = File.ReadAllLines(soLanFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        var date = parts[0];
                        var count = int.Parse(parts[1]);
                        loginCounts[date] = count;
                    }
                }
            }
            return loginCounts;
        }

        private void frmADPhanTich_Load(object sender, EventArgs e)
        {
            var loginCounts = soLanLogin();
            var sortedLoginCounts = loginCounts.OrderBy(kvp => DateTime.Parse(kvp.Key));

            chart1.Series.Clear();
            var series = new Series("Số lượt đăng nhập")
            {
                ChartType = SeriesChartType.Column
            };
            chart1.Series.Add(series);

            foreach (var kvp in sortedLoginCounts)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            // Cấu hình trục y để hiển thị số nguyên
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0";  // Định dạng nhãn trục y thành số nguyên
            chart1.ChartAreas[0].AxisY.Minimum = 0;  // Đảm bảo trục y bắt đầu từ 0

            // Hiển thị số lượt đăng nhập hôm nay
            var today = DateTime.Now.ToString("yyyy-MM-dd");
            if (loginCounts.ContainsKey(today))
            {
                lbDangNhapNgay.Text = loginCounts[today].ToString();
            }
            else
            {
                lbDangNhapNgay.Text = "0";
            }
        }
    }
}
