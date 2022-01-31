using prenatal.model;
using prenatal.model.Requests;
using System;
using System.Collections;
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
    public partial class frmChrtTemperature : Form
    {
        public int _currentUserId { get; set; }
        APIservice _vitalSign = new APIservice("VitalSign");
        public frmChrtTemperature()
        {
            APIservice.Username = AuthService.Username;
            APIservice.Password = AuthService.Password;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void frmCharts_Load(object sender, EventArgs e)
        {
            //this.MdiParent.StartPosition = FormStartPosition.CenterScreen;
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
            
            chrtVitalSigns.DataSource = await _vitalSign.Get<List<VitalSign>>(request);
           
            chrtVitalSigns.Series.Clear();
            var seriesTemp = new Series
            {
                Name = "Temperature",
                Color = Color.Blue,
                
                MarkerBorderWidth = 4,
                
                XValueMember = "Date",
                YValueMembers = "Temperature",

                IsVisibleInLegend = true,
                IsXValueIndexed = true,

                ChartType = SeriesChartType.Line,
                
                XValueType = ChartValueType.Date,
                YValueType=ChartValueType.Double,
                
                XAxisType=AxisType.Primary,
                YAxisType=AxisType.Primary,

                BackImageWrapMode =ChartImageWrapMode.Scaled,
                
                IsValueShownAsLabel = true
                
            };

            chrtVitalSigns.ChartAreas[0].AxisX.IsReversed = false;
            chrtVitalSigns.ChartAreas[0].AxisY.IsReversed = false;
            
            chrtVitalSigns.ChartAreas[0].AxisY.Minimum = 36.2;
            chrtVitalSigns.ChartAreas[0].AxisY.Maximum = 42.2;
            
            chrtVitalSigns.ChartAreas[0].AxisY.LineWidth = 2;
            chrtVitalSigns.ChartAreas[0].AxisX.LineWidth = 2;
            chrtVitalSigns.ChartAreas[0].AxisY.LineColor = Color.Blue;
            chrtVitalSigns.ChartAreas[0].AxisX.LineColor = Color.Blue;
            
            chrtVitalSigns.ChartAreas[0].AxisY.Title = "Temperature -- °C";
            chrtVitalSigns.ChartAreas[0].AxisY.TitleForeColor = Color.Blue;
            chrtVitalSigns.ChartAreas[0].AxisX.Title = "Months";
            chrtVitalSigns.ChartAreas[0].AxisX.TitleForeColor = Color.Blue;
           
            chrtVitalSigns.ChartAreas[0].AxisX.Interval = 1;
            
            chrtVitalSigns.ChartAreas[0].AxisY.Interval = 1;

            //chrtVitalSigns.ChartAreas[0].AxisX.ToolTip = "#VALY";
            chrtVitalSigns.ChartAreas[0].AxisX.LabelStyle.Format = "MMM-dd-yyyy";
            chrtVitalSigns.ChartAreas[0].AxisY.LabelStyle.Format = "n2";
            
            chrtVitalSigns.ChartAreas[0].AxisY.MinorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtVitalSigns.ChartAreas[0].AxisY.MajorTickMark.TickMarkStyle = TickMarkStyle.InsideArea;
            chrtVitalSigns.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chrtVitalSigns.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            
            chrtVitalSigns.Series.Add(seriesTemp);
            chrtVitalSigns.DataBind();
            
            for (int i = 0; i < chrtVitalSigns.Series["Temperature"].Points.Count; i++)
            {
                double yt = chrtVitalSigns.Series["Temperature"].Points[i].YValues[0];
     
                if (yt >= 36.7)
                {
                    chrtVitalSigns.Series["Temperature"].Points[i].MarkerStyle = MarkerStyle.Star6;
                    chrtVitalSigns.Series["Temperature"].Points[i].MarkerColor = Color.Red;
                    chrtVitalSigns.Series["Temperature"].Points[i].MarkerSize = 12;
                }
                if (yt >= 37.7)
                {
                    chrtVitalSigns.Series["Temperature"].Points[i].MarkerStyle = MarkerStyle.Star10;
                    chrtVitalSigns.Series["Temperature"].Points[i].MarkerColor = Color.Red;
                    chrtVitalSigns.Series["Temperature"].Points[i].MarkerSize = 14;
                    chrtVitalSigns.Series["Temperature"].Points[i].Color = Color.DarkRed;
                }
            }

            chrtVitalSigns.Invalidate();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void pressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtPressure frm = new frmChrtPressure();
            frm._currentUserId = this._currentUserId;
            //frm.WindowState = FormWindowState.Maximized;
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
            //frm.WindowState = FormWindowState.Maximized;

            frm.Show();
            this.Close();
            this.Dispose();
        }

        private void heightAndWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._currentUserId == -1) return;

            frmChrtHeightWeight frm = new frmChrtHeightWeight();
            frm._currentUserId = this._currentUserId;
            //frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this.MdiParent;

            frm.Show();
            this.Close();
            this.Dispose();
        }
    }
}
