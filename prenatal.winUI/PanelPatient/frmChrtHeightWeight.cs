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
    public partial class frmChrtHeightWeight : Form
    {
        public int _currentUserId { get; set; }
        APIservice _vitalSign = new APIservice("VitalSign");
        public frmChrtHeightWeight()
        {
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void frmChrtHeightWeight_Load(object sender, EventArgs e)
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

            chrtHeightWeight.DataSource = await _vitalSign.Get<List<VitalSign>>(request);

            chrtHeightWeight.Series.Clear();

            /* Height --> */
            var seriesHeight = new Series
            {
                Name = "Height",
                Color = Color.Blue,

                MarkerBorderWidth = 4,

                XValueMember = "Date",
                YValueMembers = "Height",

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

            chrtHeightWeight.Series.Add(seriesHeight);
            chrtHeightWeight.DataBind();

            /* Weight --> */
            var seriesWeight = new Series
            {
                Name = "Weight",
                Color = Color.Green,

                MarkerBorderWidth = 4,

                XValueMember = "Date",
                YValueMembers = "Weight",

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
            chrtHeightWeight.Series.Add(seriesWeight);
            chrtHeightWeight.DataBind();



            /* Mark the diagram under certian conditions! */
            for (int i = 0; i < chrtHeightWeight.Series["Height"].Points.Count; i++)
            {
                double yt = chrtHeightWeight.Series["Height"].Points[i].YValues[0];

                if (yt < 110)
                {
                    chrtHeightWeight.Series["Height"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtHeightWeight.Series["Height"].Points[i].MarkerColor = Color.Red;
                    chrtHeightWeight.Series["Height"].Points[i].MarkerSize = 14;
                    chrtHeightWeight.Series["Height"].Points[i].Color = Color.Orange;
                }
                if (yt > 210)
                {
                    chrtHeightWeight.Series["Height"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtHeightWeight.Series["Height"].Points[i].MarkerColor = Color.Red;
                    chrtHeightWeight.Series["Height"].Points[i].MarkerSize = 14;
                    chrtHeightWeight.Series["Height"].Points[i].Color = Color.Orange;
                }
            }

            for (int i = 0; i < chrtHeightWeight.Series["Weight"].Points.Count; i++)
            {
                double yt = chrtHeightWeight.Series["Weight"].Points[i].YValues[0];

                if (yt < 50)
                {
                    chrtHeightWeight.Series["Weight"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtHeightWeight.Series["Weight"].Points[i].MarkerColor = Color.Yellow;
                    chrtHeightWeight.Series["Weight"].Points[i].MarkerSize = 14;
                    chrtHeightWeight.Series["Weight"].Points[i].Color = Color.DarkRed;
                }
                if (yt > 110)
                {
                    chrtHeightWeight.Series["Weight"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtHeightWeight.Series["Weight"].Points[i].MarkerColor = Color.Red;
                    chrtHeightWeight.Series["Weight"].Points[i].MarkerSize = 14;
                    chrtHeightWeight.Series["Weight"].Points[i].Color = Color.Yellow;
                }
            }

            /* Char Area Options --> */
            chrtHeightWeight.ChartAreas[0].AxisX.IsReversed = false;
            chrtHeightWeight.ChartAreas[0].AxisY.IsReversed = false;

            chrtHeightWeight.ChartAreas[0].AxisY.Minimum = 50;
            chrtHeightWeight.ChartAreas[0].AxisY.Maximum = 150;

            chrtHeightWeight.ChartAreas[0].AxisY.LineWidth = 2;
            chrtHeightWeight.ChartAreas[0].AxisX.LineWidth = 2;
            chrtHeightWeight.ChartAreas[0].AxisY.LineColor = Color.Blue;
            chrtHeightWeight.ChartAreas[0].AxisX.LineColor = Color.Blue;

            chrtHeightWeight.ChartAreas[0].AxisY.Title = "Height & Weight -- kg ";
            chrtHeightWeight.ChartAreas[0].AxisY.TitleForeColor = Color.Blue;
            chrtHeightWeight.ChartAreas[0].AxisX.Title = "Months";
            chrtHeightWeight.ChartAreas[0].AxisX.TitleForeColor = Color.Blue;

            chrtHeightWeight.ChartAreas[0].AxisX.Interval = 1;

            chrtHeightWeight.ChartAreas[0].AxisY.Interval = 5;

            chrtHeightWeight.ChartAreas[0].AxisX.LabelStyle.Format = "MMM-dd-yyyy";
            chrtHeightWeight.ChartAreas[0].AxisY.LabelStyle.Format = "n2";

            chrtHeightWeight.ChartAreas[0].AxisY.MinorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtHeightWeight.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtHeightWeight.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chrtHeightWeight.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chrtHeightWeight.Invalidate();
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
            this.Refresh();
        }
    }
}
