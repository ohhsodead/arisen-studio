
namespace XDevkit.Controls
{
    partial class MemDump
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dumpMemoryButton = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.dumpStartOffsetTextBox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.dumpLengthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Please Select",
            "Physical RAM",
            "Base File / Image",
            "Allocated Data / Virtual"});
            this.comboBox2.Location = new System.Drawing.Point(4, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // dumpMemoryButton
            // 
            this.dumpMemoryButton.ForeColor = System.Drawing.Color.Black;
            this.dumpMemoryButton.Location = new System.Drawing.Point(66, 84);
            this.dumpMemoryButton.Name = "dumpMemoryButton";
            this.dumpMemoryButton.Size = new System.Drawing.Size(75, 23);
            this.dumpMemoryButton.TabIndex = 17;
            this.dumpMemoryButton.Text = "Dump";
            this.dumpMemoryButton.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(4, 61);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 13);
            this.label32.TabIndex = 21;
            this.label32.Text = "Dump Length 0x:";
            // 
            // dumpStartOffsetTextBox
            // 
            this.dumpStartOffsetTextBox.Location = new System.Drawing.Point(98, 30);
            this.dumpStartOffsetTextBox.Name = "dumpStartOffsetTextBox";
            this.dumpStartOffsetTextBox.Size = new System.Drawing.Size(102, 20);
            this.dumpStartOffsetTextBox.TabIndex = 18;
            this.dumpStartOffsetTextBox.Text = "C0000000";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(4, 33);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 13);
            this.label33.TabIndex = 20;
            this.label33.Text = "Starting Offset 0x:";
            // 
            // dumpLengthTextBox
            // 
            this.dumpLengthTextBox.Location = new System.Drawing.Point(98, 58);
            this.dumpLengthTextBox.Name = "dumpLengthTextBox";
            this.dumpLengthTextBox.Size = new System.Drawing.Size(102, 20);
            this.dumpLengthTextBox.TabIndex = 19;
            this.dumpLengthTextBox.Text = "FF";
            // 
            // MemDump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dumpMemoryButton);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.dumpStartOffsetTextBox);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.dumpLengthTextBox);
            this.MaximumSize = new System.Drawing.Size(205, 110);
            this.MinimumSize = new System.Drawing.Size(205, 110);
            this.Name = "MemDump";
            this.Size = new System.Drawing.Size(205, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button dumpMemoryButton;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox dumpStartOffsetTextBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox dumpLengthTextBox;
    }
}
