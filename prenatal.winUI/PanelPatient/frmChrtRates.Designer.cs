
namespace prenatal.winUI.PanelPatient
{
    partial class frmChrtRates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtRates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightAndWeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chrtRates)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtRates
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtRates.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtRates.Legends.Add(legend1);
            this.chrtRates.Location = new System.Drawing.Point(12, 27);
            this.chrtRates.Name = "chrtRates";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtRates.Series.Add(series1);
            this.chrtRates.Size = new System.Drawing.Size(776, 411);
            this.chrtRates.TabIndex = 0;
            this.chrtRates.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myChartsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myChartsToolStripMenuItem
            // 
            this.myChartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureToolStripMenuItem,
            this.pressureToolStripMenuItem,
            this.ratesToolStripMenuItem,
            this.heightAndWeightToolStripMenuItem});
            this.myChartsToolStripMenuItem.Name = "myChartsToolStripMenuItem";
            this.myChartsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.myChartsToolStripMenuItem.Text = "My Charts";
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // pressureToolStripMenuItem
            // 
            this.pressureToolStripMenuItem.Name = "pressureToolStripMenuItem";
            this.pressureToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pressureToolStripMenuItem.Text = "Pressure";
            this.pressureToolStripMenuItem.Click += new System.EventHandler(this.pressureToolStripMenuItem_Click);
            // 
            // ratesToolStripMenuItem
            // 
            this.ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            this.ratesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.ratesToolStripMenuItem.Text = "Heart and Respiratory Rates";
            this.ratesToolStripMenuItem.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // heightAndWeightToolStripMenuItem
            // 
            this.heightAndWeightToolStripMenuItem.Name = "heightAndWeightToolStripMenuItem";
            this.heightAndWeightToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.heightAndWeightToolStripMenuItem.Text = "Height and Weight";
            this.heightAndWeightToolStripMenuItem.Click += new System.EventHandler(this.heightAndWeightToolStripMenuItem_Click);
            // 
            // frmChrtRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chrtRates);
            this.Name = "frmChrtRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChrtRates";
            this.Load += new System.EventHandler(this.frmChrtRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtRates)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtRates;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myChartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pressureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heightAndWeightToolStripMenuItem;
    }
}