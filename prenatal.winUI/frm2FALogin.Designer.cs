
namespace prenatal.winUI
{
    partial class frm2FALogin
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
            this.groupBox2FA = new System.Windows.Forms.GroupBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtBoxInputCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2FA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2FA
            // 
            this.groupBox2FA.Controls.Add(this.btnVerify);
            this.groupBox2FA.Controls.Add(this.txtBoxInputCode);
            this.groupBox2FA.Controls.Add(this.label1);
            this.groupBox2FA.Location = new System.Drawing.Point(31, 50);
            this.groupBox2FA.Name = "groupBox2FA";
            this.groupBox2FA.Size = new System.Drawing.Size(243, 108);
            this.groupBox2FA.TabIndex = 8;
            this.groupBox2FA.TabStop = false;
            this.groupBox2FA.Text = "2FA Verification";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify.Location = new System.Drawing.Point(9, 63);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(220, 29);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify Code";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtBoxInputCode
            // 
            this.txtBoxInputCode.Location = new System.Drawing.Point(9, 37);
            this.txtBoxInputCode.Name = "txtBoxInputCode";
            this.txtBoxInputCode.Size = new System.Drawing.Size(220, 20);
            this.txtBoxInputCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input Code:";
            // 
            // frm2FALogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 207);
            this.Controls.Add(this.groupBox2FA);
            this.Name = "frm2FALogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm2FALogin";
            this.Load += new System.EventHandler(this.frm2FALogin_Load);
            this.groupBox2FA.ResumeLayout(false);
            this.groupBox2FA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2FA;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtBoxInputCode;
        private System.Windows.Forms.Label label1;
    }
}