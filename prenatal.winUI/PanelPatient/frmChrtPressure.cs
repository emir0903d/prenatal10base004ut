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
    public partial class frmChrtPressure : Form
    {
        public int _currentUserId { get; set; }
        APIservice _vitalSign = new APIservice("VitalSign");
        public frmChrtPressure()
        {
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void frmChrtPressure_Load(object sender, EventArgs e)
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

            chrtPressure.DataSource = await _vitalSign.Get<List<VitalSign>>(request);

            chrtPressure.Series.Clear();


            /* Systolic Pressure --> */
            var seriesSystolicPressure = new Series
            {
                Name = "SystolicPressure",
                Color = Color.Blue,

                MarkerBorderWidth = 4,

                XValueMember = "Date",
                YValueMembers = "SystolicPressure",

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

            chrtPressure.Series.Add(seriesSystolicPressure);
            chrtPressure.DataBind();        

            /* Diastolic Pressure --> */
            var seriesDiastolicPressure = new Series
            {
                Name = "DiastolicPressure",
                Color = Color.Green,

                MarkerBorderWidth = 4,

                XValueMember = "Date",
                YValueMembers = "DiastolicPressure",

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
            chrtPressure.Series.Add(seriesDiastolicPressure);
            chrtPressure.DataBind();



            /* Mark the diagram under certian conditions! */
            for (int i = 0; i < chrtPressure.Series["SystolicPressure"].Points.Count; i++)
            {
                double yt = chrtPressure.Series["SystolicPressure"].Points[i].YValues[0];

                if (yt < 60)
                {
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerSize = 14;
                    chrtPressure.Series["SystolicPressure"].Points[i].Color = Color.DarkRed;
                }
                if (yt >= 60 && yt <= 120)
                {
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star4;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerSize = 10;
                    chrtPressure.Series["SystolicPressure"].Points[i].Color = Color.DarkBlue;
                }
                if (yt > 120 && yt <= 130)
                {
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star5;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerSize = 11;
                    chrtPressure.Series["SystolicPressure"].Points[i].Color = Color.DarkRed;
                }
                if (yt > 130 && yt <= 140)
                {
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star6;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerSize = 12;
                    chrtPressure.Series["SystolicPressure"].Points[i].Color = Color.DarkRed;
                }
                if (yt > 140)
                {
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["SystolicPressure"].Points[i].MarkerSize = 14;
                    chrtPressure.Series["SystolicPressure"].Points[i].Color = Color.DarkRed;
                }
            }

            for (int i = 0; i < chrtPressure.Series["DiastolicPressure"].Points.Count; i++)
            {
                double yt = chrtPressure.Series["DiastolicPressure"].Points[i].YValues[0];

                if (yt <=80)
                {
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerSize = 14;
                    chrtPressure.Series["DiastolicPressure"].Points[i].Color = Color.DarkRed;
                }
                if (yt > 80 && yt <= 90)
                {
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star5;
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerSize = 10;
                    chrtPressure.Series["DiastolicPressure"].Points[i].Color = Color.Green;
                }
                if (yt > 90)
                {
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerColor = Color.Red;
                    chrtPressure.Series["DiastolicPressure"].Points[i].MarkerSize = 14;
                    chrtPressure.Series["DiastolicPressure"].Points[i].Color = Color.DarkRed;
                }
            }

            /* Char Area Options --> */
            chrtPressure.ChartAreas[0].AxisX.IsReversed = false;
            chrtPressure.ChartAreas[0].AxisY.IsReversed = false;

            chrtPressure.ChartAreas[0].AxisY.Minimum = 39;
            chrtPressure.ChartAreas[0].AxisY.Maximum = 211;

            chrtPressure.ChartAreas[0].AxisY.LineWidth = 2;
            chrtPressure.ChartAreas[0].AxisX.LineWidth = 2;
            chrtPressure.ChartAreas[0].AxisY.LineColor = Color.Blue;
            chrtPressure.ChartAreas[0].AxisX.LineColor = Color.Blue;

            chrtPressure.ChartAreas[0].AxisY.Title = "SystolicPressure & DiastolicPressure -- mm/Hg";
            chrtPressure.ChartAreas[0].AxisY.TitleForeColor = Color.Blue;
            chrtPressure.ChartAreas[0].AxisX.Title = "Months";
            chrtPressure.ChartAreas[0].AxisX.TitleForeColor = Color.Blue;

            chrtPressure.ChartAreas[0].AxisX.Interval = 1;

            chrtPressure.ChartAreas[0].AxisY.Interval = 40;

            chrtPressure.ChartAreas[0].AxisX.LabelStyle.Format = "MMM-dd-yyyy";
            chrtPressure.ChartAreas[0].AxisY.LabelStyle.Format = "n2";

            chrtPressure.ChartAreas[0].AxisY.MinorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtPressure.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtPressure.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrtPressure.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chrtPressure.Invalidate();
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
            this.Refresh();
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtRates frm = new frmChrtRates();
            frm._currentUserId = this._currentUserId;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
            this.Dispose();
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
