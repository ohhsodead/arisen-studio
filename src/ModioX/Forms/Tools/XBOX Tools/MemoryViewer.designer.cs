using System;

namespace ModioX.Forms.Tools.XBOX_Tools
{
    partial class MemoryViewer
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
            this.components = new System.ComponentModel.Container();
            this.hexBox = new Be.Windows.Forms.HexBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.PeekB = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.New = new DevExpress.XtraEditors.SimpleButton();
            this.PeekPokeAddressTextBox = new DevExpress.XtraEditors.TextEdit();
            this.peekLengthTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.AutoPeek = new System.Windows.Forms.Timer(this.components);
            this.AutoPoke = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Dumpmem = new DevExpress.XtraEditors.SimpleButton();
            this.PokeB = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.SelAddress = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch2 = new DevExpress.XtraEditors.ToggleSwitch();
            this.peekPokeFeedBackTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.FilltoggleSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.fillValueTextBox = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.isSigned = new DevExpress.XtraEditors.ToggleSwitch();
            this.NumericInt32 = new System.Windows.Forms.NumericUpDown();
            this.NumericInt16 = new System.Windows.Forms.NumericUpDown();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.NumericFloatTextBox = new DevExpress.XtraEditors.TextEdit();
            this.NumericInt8 = new System.Windows.Forms.NumericUpDown();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPaste = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PeekPokeAddressTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peekLengthTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peekPokeFeedBackTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilltoggleSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillValueTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isSigned.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFloatTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaste.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hexBox
            // 
            this.hexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.hexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            this.hexBox.BuiltInContextMenu.CopyMenuItemText = "";
            this.hexBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.InfoForeColor = System.Drawing.Color.Empty;
            this.hexBox.LineInfoVisible = true;
            this.hexBox.Location = new System.Drawing.Point(2, 97);
            this.hexBox.Name = "hexBox";
            this.hexBox.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(637, 412);
            this.hexBox.StringViewVisible = true;
            this.hexBox.TabIndex = 34;
            this.hexBox.UseFixedBytesPerLine = true;
            this.hexBox.VScrollBarVisible = true;
            this.hexBox.SelectionStartChanged += new System.EventHandler(this.hexBox_SelectionStartChanged);
            this.hexBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hexBox_KeyDown);
            this.hexBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hexBox_MouseUp);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // PeekB
            // 
            this.PeekB.AllowFocus = false;
            this.PeekB.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.PeekB.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.PeekB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PeekB.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.PeekB.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PeekB.Appearance.Options.UseBackColor = true;
            this.PeekB.Appearance.Options.UseForeColor = true;
            this.PeekB.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.PeekB.Location = new System.Drawing.Point(191, 19);
            this.PeekB.Name = "PeekB";
            this.PeekB.Size = new System.Drawing.Size(76, 24);
            this.PeekB.TabIndex = 116;
            this.PeekB.Text = "Peek";
            this.PeekB.Click += new System.EventHandler(this.PeekPokeAddressTextBox_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(384, 16);
            this.labelControl1.TabIndex = 118;
            this.labelControl1.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F ";
            // 
            // New
            // 
            this.New.AllowFocus = false;
            this.New.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.New.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.New.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.New.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.New.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.New.Appearance.Options.UseBackColor = true;
            this.New.Appearance.Options.UseForeColor = true;
            this.New.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.New.Location = new System.Drawing.Point(191, 49);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(76, 24);
            this.New.TabIndex = 119;
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // PeekPokeAddressTextBox
            // 
            this.PeekPokeAddressTextBox.EditValue = "C0000000";
            this.PeekPokeAddressTextBox.Location = new System.Drawing.Point(85, 21);
            this.PeekPokeAddressTextBox.Name = "PeekPokeAddressTextBox";
            this.PeekPokeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.PeekPokeAddressTextBox.TabIndex = 120;
            this.PeekPokeAddressTextBox.Click += new System.EventHandler(this.PeekPokeAddressTextBox_Click_1);
            this.PeekPokeAddressTextBox.DoubleClick += new System.EventHandler(this.PeekPokeAddressTextBox_DoubleClick);
            this.PeekPokeAddressTextBox.Leave += new System.EventHandler(this.FixTheAddresses);
            // 
            // peekLengthTextBox
            // 
            this.peekLengthTextBox.EditValue = "FFFF";
            this.peekLengthTextBox.Location = new System.Drawing.Point(85, 51);
            this.peekLengthTextBox.Name = "peekLengthTextBox";
            this.peekLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.peekLengthTextBox.TabIndex = 121;
            this.peekLengthTextBox.Leave += new System.EventHandler(this.FixTheAddresses);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 122;
            this.labelControl2.Text = "Address 0x:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 123;
            this.labelControl3.Text = "Length 0x:";
            // 
            // AutoPeek
            // 
            this.AutoPeek.Interval = 3000;
            this.AutoPeek.Tick += new System.EventHandler(this.AutoPeek_Tick);
            // 
            // AutoPoke
            // 
            this.AutoPoke.Interval = 3000;
            this.AutoPoke.Tick += new System.EventHandler(this.AutoPoke_Tick);
            // 
            // Dumpmem
            // 
            this.Dumpmem.AllowFocus = false;
            this.Dumpmem.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.Dumpmem.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.Dumpmem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Dumpmem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Dumpmem.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Dumpmem.Appearance.Options.UseBackColor = true;
            this.Dumpmem.Appearance.Options.UseForeColor = true;
            this.Dumpmem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.Dumpmem.Location = new System.Drawing.Point(273, 49);
            this.Dumpmem.Name = "Dumpmem";
            this.Dumpmem.Size = new System.Drawing.Size(76, 24);
            this.Dumpmem.TabIndex = 126;
            this.Dumpmem.Text = "Dump Memory";
            this.Dumpmem.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // PokeB
            // 
            this.PokeB.AllowFocus = false;
            this.PokeB.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.PokeB.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.PokeB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PokeB.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.PokeB.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PokeB.Appearance.Options.UseBackColor = true;
            this.PokeB.Appearance.Options.UseForeColor = true;
            this.PokeB.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.PokeB.Location = new System.Drawing.Point(273, 19);
            this.PokeB.Name = "PokeB";
            this.PokeB.Size = new System.Drawing.Size(76, 24);
            this.PokeB.TabIndex = 125;
            this.PokeB.Text = "Poke";
            this.PokeB.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.checkEdit1.Location = new System.Drawing.Point(355, 16);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.AllowFocused = false;
            this.checkEdit1.Properties.Caption = "Auto Peek";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 127;
            // 
            // checkEdit2
            // 
            this.checkEdit2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.checkEdit2.Location = new System.Drawing.Point(355, 41);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.AllowFocused = false;
            this.checkEdit2.Properties.Caption = "Auto Poke";
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 128;
            // 
            // SelAddress
            // 
            this.SelAddress.EditValue = "";
            this.SelAddress.Location = new System.Drawing.Point(718, 6);
            this.SelAddress.Name = "SelAddress";
            this.SelAddress.Size = new System.Drawing.Size(108, 20);
            this.SelAddress.TabIndex = 129;
            this.SelAddress.DoubleClick += new System.EventHandler(this.SelAddress_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.toggleSwitch2);
            this.groupControl1.Location = new System.Drawing.Point(645, 146);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(181, 47);
            this.groupControl1.TabIndex = 130;
            this.groupControl1.Text = "Debug Commands";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(78, 13);
            this.labelControl7.TabIndex = 137;
            this.labelControl7.Text = "Freeze Console";
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.Location = new System.Drawing.Point(103, 20);
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.Properties.OffText = "";
            this.toggleSwitch2.Properties.OnText = "";
            this.toggleSwitch2.Size = new System.Drawing.Size(69, 25);
            this.toggleSwitch2.TabIndex = 132;
            this.toggleSwitch2.Toggled += new System.EventHandler(this.toggleSwitch2_Toggled);
            // 
            // peekPokeFeedBackTextBox
            // 
            this.peekPokeFeedBackTextBox.EditValue = "";
            this.peekPokeFeedBackTextBox.Location = new System.Drawing.Point(718, 32);
            this.peekPokeFeedBackTextBox.Name = "peekPokeFeedBackTextBox";
            this.peekPokeFeedBackTextBox.Size = new System.Drawing.Size(108, 20);
            this.peekPokeFeedBackTextBox.TabIndex = 132;
            this.peekPokeFeedBackTextBox.DoubleClick += new System.EventHandler(this.peekPokeFeedBackTextBox_DoubleClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(609, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 13);
            this.labelControl4.TabIndex = 134;
            this.labelControl4.Text = "Peek/Poke Feedback:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(625, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 133;
            this.labelControl5.Text = "Selected Address:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(645, 97);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(126, 13);
            this.labelControl6.TabIndex = 135;
            this.labelControl6.Text = "Fill The Memory With 0x:";
            // 
            // FilltoggleSwitch
            // 
            this.FilltoggleSwitch.Location = new System.Drawing.Point(645, 116);
            this.FilltoggleSwitch.Name = "FilltoggleSwitch";
            this.FilltoggleSwitch.Properties.OffText = "";
            this.FilltoggleSwitch.Properties.OnText = "";
            this.FilltoggleSwitch.Size = new System.Drawing.Size(69, 25);
            this.FilltoggleSwitch.TabIndex = 133;
            // 
            // fillValueTextBox
            // 
            this.fillValueTextBox.EditValue = "";
            this.fillValueTextBox.Location = new System.Drawing.Point(786, 93);
            this.fillValueTextBox.Name = "fillValueTextBox";
            this.fillValueTextBox.Size = new System.Drawing.Size(40, 20);
            this.fillValueTextBox.TabIndex = 136;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.isSigned);
            this.groupControl2.Controls.Add(this.NumericInt32);
            this.groupControl2.Controls.Add(this.NumericInt16);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.NumericFloatTextBox);
            this.groupControl2.Controls.Add(this.NumericInt8);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Location = new System.Drawing.Point(645, 199);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(182, 196);
            this.groupControl2.TabIndex = 138;
            this.groupControl2.Text = "Debug Commands";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(27, 158);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(26, 14);
            this.labelControl12.TabIndex = 144;
            this.labelControl12.Text = "Float";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(5, 29);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(73, 13);
            this.labelControl11.TabIndex = 139;
            this.labelControl11.Text = "Signed Values";
            // 
            // isSigned
            // 
            this.isSigned.Location = new System.Drawing.Point(103, 23);
            this.isSigned.Name = "isSigned";
            this.isSigned.Properties.OffText = "";
            this.isSigned.Properties.OnText = "";
            this.isSigned.Size = new System.Drawing.Size(69, 25);
            this.isSigned.TabIndex = 138;
            this.isSigned.Toggled += new System.EventHandler(this.isSigned_Toggled);
            // 
            // NumericInt32
            // 
            this.NumericInt32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericInt32.Location = new System.Drawing.Point(63, 123);
            this.NumericInt32.Name = "NumericInt32";
            this.NumericInt32.Size = new System.Drawing.Size(109, 18);
            this.NumericInt32.TabIndex = 143;
            this.NumericInt32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericInt32.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NumericInt32.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            this.NumericInt32.DoubleClick += new System.EventHandler(this.NumericInt32_DoubleClick);
            this.NumericInt32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericIntKeyPress);
            // 
            // NumericInt16
            // 
            this.NumericInt16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericInt16.Location = new System.Drawing.Point(63, 91);
            this.NumericInt16.Name = "NumericInt16";
            this.NumericInt16.Size = new System.Drawing.Size(109, 18);
            this.NumericInt16.TabIndex = 142;
            this.NumericInt16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericInt16.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NumericInt16.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            this.NumericInt16.DoubleClick += new System.EventHandler(this.NumericInt16_DoubleClick);
            this.NumericInt16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericIntKeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(5, 124);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 14);
            this.labelControl10.TabIndex = 141;
            this.labelControl10.Text = "(U)Int32";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 92);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 140;
            this.labelControl9.Text = "(U)Int16";
            // 
            // NumericFloatTextBox
            // 
            this.NumericFloatTextBox.EditValue = "";
            this.NumericFloatTextBox.Location = new System.Drawing.Point(63, 155);
            this.NumericFloatTextBox.Name = "NumericFloatTextBox";
            this.NumericFloatTextBox.Properties.Appearance.Options.UseTextOptions = true;
            this.NumericFloatTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumericFloatTextBox.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.NumericFloatTextBox.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumericFloatTextBox.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.NumericFloatTextBox.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumericFloatTextBox.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.NumericFloatTextBox.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumericFloatTextBox.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.NumericFloatTextBox.Size = new System.Drawing.Size(108, 20);
            this.NumericFloatTextBox.TabIndex = 139;
            this.NumericFloatTextBox.DoubleClick += new System.EventHandler(this.NumericFloatTextBox_DoubleClick);
            this.NumericFloatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericIntKeyPress);
            // 
            // NumericInt8
            // 
            this.NumericInt8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumericInt8.Location = new System.Drawing.Point(63, 59);
            this.NumericInt8.Name = "NumericInt8";
            this.NumericInt8.Size = new System.Drawing.Size(109, 18);
            this.NumericInt8.TabIndex = 138;
            this.NumericInt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericInt8.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NumericInt8.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            this.NumericInt8.Click += new System.EventHandler(this.NumericInt8_Click);
            this.NumericInt8.DoubleClick += new System.EventHandler(this.NumericInt8_DoubleClick);
            this.NumericInt8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericIntKeyPress);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(5, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 14);
            this.labelControl8.TabIndex = 137;
            this.labelControl8.Text = "(U)Int8";
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "2000";
            this.textEdit5.Location = new System.Drawing.Point(789, 59);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(38, 20);
            this.textEdit5.TabIndex = 139;
            this.textEdit5.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Location = new System.Drawing.Point(718, 59);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 20);
            this.simpleButton1.TabIndex = 140;
            this.simpleButton1.Text = "Set";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPaste
            // 
            this.txtPaste.EditValue = "";
            this.txtPaste.Location = new System.Drawing.Point(762, 59);
            this.txtPaste.Name = "txtPaste";
            this.txtPaste.Size = new System.Drawing.Size(21, 20);
            this.txtPaste.TabIndex = 141;
            this.txtPaste.Visible = false;
            // 
            // MemoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 520);
            this.Controls.Add(this.txtPaste);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.fillValueTextBox);
            this.Controls.Add(this.FilltoggleSwitch);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.peekPokeFeedBackTextBox);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.SelAddress);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.Dumpmem);
            this.Controls.Add(this.PokeB);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.peekLengthTextBox);
            this.Controls.Add(this.PeekPokeAddressTextBox);
            this.Controls.Add(this.New);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PeekB);
            this.Controls.Add(this.hexBox);
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximumSize = new System.Drawing.Size(862, 568);
            this.MinimumSize = new System.Drawing.Size(862, 568);
            this.Name = "MemoryViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SocketStress - Memory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemoryViewer_FormClosing);
            this.Load += new System.EventHandler(this.MemoryViewer_Load);
            this.BackColorChanged += new System.EventHandler(this.MemoryViewer_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PeekPokeAddressTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peekLengthTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peekPokeFeedBackTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilltoggleSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillValueTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isSigned.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFloatTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaste.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public Be.Windows.Forms.HexBox hexBox;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton PeekB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton New;
        private DevExpress.XtraEditors.TextEdit PeekPokeAddressTextBox;
        private DevExpress.XtraEditors.TextEdit peekLengthTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Timer AutoPeek;
        private System.Windows.Forms.Timer AutoPoke;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton Dumpmem;
        private DevExpress.XtraEditors.SimpleButton PokeB;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.TextEdit SelAddress;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch2;
        private DevExpress.XtraEditors.TextEdit peekPokeFeedBackTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ToggleSwitch FilltoggleSwitch;
        private DevExpress.XtraEditors.TextEdit fillValueTextBox;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ToggleSwitch isSigned;
        private System.Windows.Forms.NumericUpDown NumericInt32;
        private System.Windows.Forms.NumericUpDown NumericInt16;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit NumericFloatTextBox;
        private System.Windows.Forms.NumericUpDown NumericInt8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtPaste;
    }
}