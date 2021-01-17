
using System;
using System.Drawing;
using System.Windows.Forms;

namespace XDevkit
{
    partial class xex_slider
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
            label1 = new Label();
            trackBar1 = new TrackBar();
            trackBar1.BeginInit();
            base.SuspendLayout();
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(0x21, 13);
            label1.TabIndex = 0;
            label1.Text = "name";
            trackBar1.Location = new Point(0xcc, 7);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(0x144, 0x2d);
            trackBar1.TabIndex = 1;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Scroll += new EventHandler(trackBar1_Scroll);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.Controls.Add(trackBar1);
            base.Controls.Add(label1);
            base.Name = "xex_slider";
            base.Size = new Size(0x213, 0x23);
            trackBar1.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private Label label1;
        private TrackBar trackBar1;
    }
}
