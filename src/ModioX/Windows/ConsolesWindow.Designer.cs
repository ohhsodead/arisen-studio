namespace ModioX.Windows
{
    partial class ConsolesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolesWindow));
            this.ButtonConsoleAdd = new DarkUI.Controls.DarkButton();
            this.TextBoxName = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.TextBoxAddress = new DarkUI.Controls.DarkTextBox();
            this.ButtonConsoleRemove = new DarkUI.Controls.DarkButton();
            this.ListViewConsoles = new DarkUI.Controls.DarkListView();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // ButtonConsoleAdd
            // 
            this.ButtonConsoleAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConsoleAdd.Location = new System.Drawing.Point(210, 30);
            this.ButtonConsoleAdd.Name = "ButtonConsoleAdd";
            this.ButtonConsoleAdd.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonConsoleAdd.Size = new System.Drawing.Size(65, 22);
            this.ButtonConsoleAdd.TabIndex = 1133;
            this.ButtonConsoleAdd.Text = "Add";
            this.ButtonConsoleAdd.Click += new System.EventHandler(this.ButtonConsoleAdd_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxName.Location = new System.Drawing.Point(12, 30);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(192, 22);
            this.TextBoxName.TabIndex = 1134;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 9);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(42, 15);
            this.darkLabel1.TabIndex = 1135;
            this.darkLabel1.Text = "Name:";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAddress.Font = new System.Drawing.Font("Consolas", 9F);
            this.TextBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxAddress.Location = new System.Drawing.Point(12, 79);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(192, 22);
            this.TextBoxAddress.TabIndex = 1137;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // ButtonConsoleRemove
            // 
            this.ButtonConsoleRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonConsoleRemove.Location = new System.Drawing.Point(210, 79);
            this.ButtonConsoleRemove.Name = "ButtonConsoleRemove";
            this.ButtonConsoleRemove.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonConsoleRemove.Size = new System.Drawing.Size(65, 22);
            this.ButtonConsoleRemove.TabIndex = 1136;
            this.ButtonConsoleRemove.Text = "Remove";
            this.ButtonConsoleRemove.Click += new System.EventHandler(this.ButtonConsoleRemove_Click);
            // 
            // ListViewConsoles
            // 
            this.ListViewConsoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewConsoles.Location = new System.Drawing.Point(12, 107);
            this.ListViewConsoles.Name = "ListViewConsoles";
            this.ListViewConsoles.Size = new System.Drawing.Size(263, 118);
            this.ListViewConsoles.TabIndex = 1138;
            this.ListViewConsoles.Text = "darkListView1";
            this.ListViewConsoles.SelectedIndicesChanged += new System.EventHandler(this.ListViewConsoles_SelectedIndicesChanged);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(12, 58);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(73, 15);
            this.darkLabel2.TabIndex = 1139;
            this.darkLabel2.Text = "Address (IP):";
            // 
            // ConsolesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(287, 237);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.ListViewConsoles);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.ButtonConsoleRemove);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonConsoleAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsolesWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Consoles";
            this.Load += new System.EventHandler(this.ConsolesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkButton ButtonConsoleAdd;
        private DarkUI.Controls.DarkTextBox TextBoxName;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox TextBoxAddress;
        private DarkUI.Controls.DarkButton ButtonConsoleRemove;
        private DarkUI.Controls.DarkListView ListViewConsoles;
        private DarkUI.Controls.DarkLabel darkLabel2;
    }
}