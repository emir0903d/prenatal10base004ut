using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace prenatal.winUI.PanelPatient
{
    public partial class frmChrtRates : Form
    {
        public int _currentUserId { get; set; }
        APIservice _vitalSign = new APIservice("VitalSign");
        public frmChrtRates()
        {
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void frmChrtRates_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();

            this.menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            this.menuStrip1.Padding = Padding.Empty;
            this.menuStrip1.Margin = Padding.Empty;
            this.menuStrip1.Stretch = false;

            VitalSignSearchRequest request = new VitalSignSearchRequest();
            request.MedicalRecordId = _currentUserId;

            chrtRates.DataSource = await _vitalSign.Get<List<VitalSign>>(request);

            chrtRates.Series.Clear();

            /* Heart Beats --> */
            var seriesHeartBeats = new Series
            {
                Name = "HeartBeats",
                Color = Color.Blue,

                MarkerBorderWidth = 4,

                XValueMember = "Date",
                YValueMembers = "HeartBeats",

                IsVisibleInLegend = true,
                IsXValueIndexed = true,

                ChartType = SeriesChartType.Line,

                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Int32,

                XAxisType = AxisType.Primary,
                YAxisType = AxisType.Primary,

                //BackImageWrapMode = ChartImageWrapMode.Scaled,

                IsValueShownAsLabel = true

            };

            chrtRates.Series.Add(seriesHeartBeats);
            chrtRates.DataBind();

            /* Respiratory Rate --> */
            var seriesRespiratoryRate = new Series
            {
                Name = "RespiratoryRate",
                Color = Color.Green,

                MarkerBorderWidth = 4,

                XValueMember = "Date",
                YValueMembers = "RespiratoryRate",

                IsVisibleInLegend = true,
                IsXValueIndexed = true,

                ChartType = SeriesChartType.Line,

                XValueType = ChartValueType.Date,
                YValueType = ChartValueType.Int32,

                XAxisType = AxisType.Primary,
                YAxisType = AxisType.Primary,

                BackImageWrapMode = ChartImageWrapMode.Scaled,

                IsValueShownAsLabel = true

            };
            chrtRates.Series.Add(seriesRespiratoryRate);
            chrtRates.DataBind();



            /* Mark the diagram under certian conditions! */
            for (int i = 0; i < chrtRates.Series["HeartBeats"].Points.Count; i++)
            {
                double yt = chrtRates.Series["HeartBeats"].Points[i].YValues[0];

                if (yt < 60)
                {
                    chrtRates.Series["HeartBeats"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtRates.Series["HeartBeats"].Points[i].MarkerColor = Color.Red;
                    chrtRates.Series["HeartBeats"].Points[i].MarkerSize = 14;
                    chrtRates.Series["HeartBeats"].Points[i].Color = Color.Orange;
                }
                if (yt > 90)
                {
                    chrtRates.Series["HeartBeats"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtRates.Series["HeartBeats"].Points[i].MarkerColor = Color.Red;
                    chrtRates.Series["HeartBeats"].Points[i].MarkerSize = 14;
                    chrtRates.Series["HeartBeats"].Points[i].Color = Color.Orange;
                }
            }

            for (int i = 0; i < chrtRates.Series["RespiratoryRate"].Points.Count; i++)
            {
                double yt = chrtRates.Series["RespiratoryRate"].Points[i].YValues[0];

                if (yt < 13)
                {
                    chrtRates.Series["RespiratoryRate"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtRates.Series["RespiratoryRate"].Points[i].MarkerColor = Color.Yellow;
                    chrtRates.Series["RespiratoryRate"].Points[i].MarkerSize = 14;
                    chrtRates.Series["RespiratoryRate"].Points[i].Color = Color.DarkRed;
                }
                if (yt > 19)
                {
                    chrtRates.Series["RespiratoryRate"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtRates.Series["RespiratoryRate"].Points[i].MarkerColor = Color.Red;
                    chrtRates.Series["RespiratoryRate"].Points[i].MarkerSize = 14;
                    chrtRates.Series["RespiratoryRate"].Points[i].Color = Color.Yellow;
                }
            }

            /* Char Area Options --> */
            chrtRates.ChartAreas[0].AxisX.IsReversed = false;
            chrtRates.ChartAreas[0].AxisY.IsReversed = false;

            chrtRates.ChartAreas[0].AxisY.Minimum = 10;
            chrtRates.ChartAreas[0].AxisY.Maximum = 200;

            chrtRates.ChartAreas[0].AxisY.LineWidth = 2;
            chrtRates.ChartAreas[0].AxisX.LineWidth = 2;
            chrtRates.ChartAreas[0].AxisY.LineColor = Color.Blue;
            chrtRates.ChartAreas[0].AxisX.LineColor = Color.Blue;

            chrtRates.ChartAreas[0].AxisY.Title = "Heart & Respiratory Rates -- per minute";
            chrtRates.ChartAreas[0].AxisY.TitleForeColor = Color.Blue;
            chrtRates.ChartAreas[0].AxisX.Title = "Months";
            chrtRates.ChartAreas[0].AxisX.TitleForeColor = Color.Blue;

            chrtRates.ChartAreas[0].AxisX.Interval = 1;

            chrtRates.ChartAreas[0].AxisY.Interval = 20;

            chrtRates.ChartAreas[0].AxisX.LabelStyle.Format = "MMM-dd-yyyy";
            chrtRates.ChartAreas[0].AxisY.LabelStyle.Format = "n2";

            chrtRates.ChartAreas[0].AxisY.MinorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtRates.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtRates.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrtRates.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chrtRates.Invalidate();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtTemperature frm = new frmChrtTemperature();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void pressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtPressure frm = new frmChrtPressure();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void heightAndWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtHeightWeight frm = new frmChrtHeightWeight();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
        }
    }
}
