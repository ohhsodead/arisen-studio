
using System.Drawing;

namespace ModioX
{
    partial class Buttons
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonExtra = new System.Windows.Forms.Panel();
            this.ButtonText1 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonYes = new System.Windows.Forms.Panel();
            this.ButtonText2 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonNo = new System.Windows.Forms.Panel();
            this.ButtonText3 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonExtra.SuspendLayout();
            this.ButtonYes.SuspendLayout();
            this.ButtonNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonExtra
            // 
            this.ButtonExtra.BackColor = System.Drawing.Color.Transparent;
            this.ButtonExtra.Controls.Add(this.ButtonText1);
            this.ButtonExtra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonExtra.Location = new System.Drawing.Point(0, 0);
            this.ButtonExtra.Name = "ButtonExtra";
            this.ButtonExtra.Size = new System.Drawing.Size(695, 51);
            this.ButtonExtra.TabIndex = 6;
            this.ButtonExtra.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonExtra_Paint);
            this.ButtonExtra.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.ButtonExtra.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // ButtonText1
            // 
            this.ButtonText1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ButtonText1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonText1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ButtonText1.Appearance.Options.UseBackColor = true;
            this.ButtonText1.Appearance.Options.UseFont = true;
            this.ButtonText1.Appearance.Options.UseForeColor = true;
            this.ButtonText1.Location = new System.Drawing.Point(29, 13);
            this.ButtonText1.Name = "ButtonText1";
            this.ButtonText1.Size = new System.Drawing.Size(52, 25);
            this.ButtonText1.TabIndex = 1;
            this.ButtonText1.Text = "Abort";
            this.ButtonText1.MouseLeave += new System.EventHandler(this.ButtonText_MouseLeave);
            this.ButtonText1.MouseHover += new System.EventHandler(this.ButtonText_MouseHover);
            // 
            // ButtonYes
            // 
            this.ButtonYes.BackColor = System.Drawing.Color.Transparent;
            this.ButtonYes.Controls.Add(this.ButtonText2);
            this.ButtonYes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonYes.Location = new System.Drawing.Point(0, 51);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(695, 51);
            this.ButtonYes.TabIndex = 5;
            this.ButtonYes.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonYes_Paint);
            this.ButtonYes.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.ButtonYes.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // ButtonText2
            // 
            this.ButtonText2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ButtonText2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonText2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ButtonText2.Appearance.Options.UseBackColor = true;
            this.ButtonText2.Appearance.Options.UseFont = true;
            this.ButtonText2.Appearance.Options.UseForeColor = true;
            this.ButtonText2.Location = new System.Drawing.Point(29, 12);
            this.ButtonText2.Name = "ButtonText2";
            this.ButtonText2.Size = new System.Drawing.Size(30, 25);
            this.ButtonText2.TabIndex = 1;
            this.ButtonText2.Text = "Yes";
            this.ButtonText2.MouseLeave += new System.EventHandler(this.ButtonText_MouseLeave);
            this.ButtonText2.MouseHover += new System.EventHandler(this.ButtonText_MouseHover);
            // 
            // ButtonNo
            // 
            this.ButtonNo.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNo.Controls.Add(this.ButtonText3);
            this.ButtonNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonNo.Location = new System.Drawing.Point(0, 102);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(695, 51);
            this.ButtonNo.TabIndex = 4;
            this.ButtonNo.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonNo_Paint);
            this.ButtonNo.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.ButtonNo.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // ButtonText3
            // 
            this.ButtonText3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ButtonText3.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonText3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ButtonText3.Appearance.Options.UseBackColor = true;
            this.ButtonText3.Appearance.Options.UseFont = true;
            this.ButtonText3.Appearance.Options.UseForeColor = true;
            this.ButtonText3.Location = new System.Drawing.Point(29, 12);
            this.ButtonText3.Name = "ButtonText3";
            this.ButtonText3.Size = new System.Drawing.Size(27, 25);
            this.ButtonText3.TabIndex = 1;
            this.ButtonText3.Text = "No";
            this.ButtonText3.MouseLeave += new System.EventHandler(this.ButtonText_MouseLeave);
            this.ButtonText3.MouseHover += new System.EventHandler(this.ButtonText_MouseHover);
            // 
            // Buttons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonExtra);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.ButtonNo);
            this.Name = "Buttons";
            this.Size = new System.Drawing.Size(695, 153);
            this.ButtonExtra.ResumeLayout(false);
            this.ButtonExtra.PerformLayout();
            this.ButtonYes.ResumeLayout(false);
            this.ButtonYes.PerformLayout();
            this.ButtonNo.ResumeLayout(false);
            this.ButtonNo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonExtra;
        private DevExpress.XtraEditors.LabelControl ButtonText1;
        private System.Windows.Forms.Panel ButtonYes;
        private DevExpress.XtraEditors.LabelControl ButtonText2;
        private System.Windows.Forms.Panel ButtonNo;
        private DevExpress.XtraEditors.LabelControl ButtonText3;
    }
}
