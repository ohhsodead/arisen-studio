using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace XDevkit
{
    partial class xex_value
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
            this.components = new System.ComponentModel.Container();
            this.Address = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.Poke = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.revertValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(24, 5);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(33, 13);
            this.Address.TabIndex = 0;
            this.Address.Text = "offset";
            this.Address.Click += new System.EventHandler(this.label1_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(164, 3);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(154, 20);
            this.Value.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(324, 5);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(27, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "type";
            // 
            // Poke
            // 
            this.Poke.Location = new System.Drawing.Point(357, 1);
            this.Poke.Name = "Poke";
            this.Poke.Size = new System.Drawing.Size(40, 20);
            this.Poke.TabIndex = 3;
            this.Poke.Text = "Poke";
            this.Poke.UseVisualStyleBackColor = true;
            this.Poke.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revertValueToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            // 
            // revertValueToolStripMenuItem
            // 
            this.revertValueToolStripMenuItem.Name = "revertValueToolStripMenuItem";
            this.revertValueToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.revertValueToolStripMenuItem.Text = "Revert Value";
            this.revertValueToolStripMenuItem.Click += new System.EventHandler(this.revertValueToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(143, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // xex_value
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Poke);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Address);
            this.Name = "xex_value";
            this.Size = new System.Drawing.Size(400, 25);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Poke;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem revertValueToolStripMenuItem;
        private TextBox Value;
        private Label Address;
        private Label Type;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
