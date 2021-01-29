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
            this.HexBox = new Be.Windows.Forms.HexBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ButtonPeek = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.PeekPokeAddressTextBox = new DevExpress.XtraEditors.TextEdit();
            this.peekLengthTextBox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.AutoPeek = new System.Windows.Forms.Timer(this.components);
            this.AutoPoke = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ButtonDumpMemory = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPoke = new DevExpress.XtraEditors.SimpleButton();
            this.CheckBoxAutoPeek = new DevExpress.XtraEditors.CheckEdit();
            this.CheckBoxAutoPoke = new DevExpress.XtraEditors.CheckEdit();
            this.TextBoxSelectedAddress = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.SwitchFreezeConsole = new DevExpress.XtraEditors.ToggleSwitch();
            this.TextBoxPeekPokeFeedback = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SwitchFillMemory = new DevExpress.XtraEditors.ToggleSwitch();
            this.TextBoxFillValue = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.SwitchIsSigned = new DevExpress.XtraEditors.ToggleSwitch();
            this.NumericInt32 = new DevExpress.XtraEditors.SpinEdit();
            this.NumericInt16 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.NumericFloatTextBox = new DevExpress.XtraEditors.TextEdit();
            this.NumericInt8 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.ButtonSet = new DevExpress.XtraEditors.SimpleButton();
            this.TextBoxPasteClipboard = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PeekPokeAddressTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peekLengthTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoPeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoPoke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSelectedAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchFreezeConsole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPeekPokeFeedback.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchFillMemory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFillValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchIsSigned.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt32.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFloatTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPasteClipboard.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HexBox
            // 
            this.HexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.HexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            this.HexBox.BuiltInContextMenu.CopyMenuItemText = "";
            this.HexBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexBox.InfoForeColor = System.Drawing.Color.Empty;
            this.HexBox.LineInfoVisible = true;
            this.HexBox.Location = new System.Drawing.Point(12, 90);
            this.HexBox.Name = "HexBox";
            this.HexBox.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.HexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.HexBox.Size = new System.Drawing.Size(637, 412);
            this.HexBox.StringViewVisible = true;
            this.HexBox.TabIndex = 34;
            this.HexBox.UseFixedBytesPerLine = true;
            this.HexBox.VScrollBarVisible = true;
            this.HexBox.SelectionStartChanged += new System.EventHandler(this.HexBox_SelectionStartChanged);
            this.HexBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HexBox_KeyDown);
            this.HexBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HexBox_MouseUp);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Black";
            // 
            // ButtonPeek
            // 
            this.ButtonPeek.AllowFocus = false;
            this.ButtonPeek.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonPeek.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonPeek.Location = new System.Drawing.Point(201, 12);
            this.ButtonPeek.Name = "ButtonPeek";
            this.ButtonPeek.Size = new System.Drawing.Size(66, 24);
            this.ButtonPeek.TabIndex = 116;
            this.ButtonPeek.Text = "Peek";
            this.ButtonPeek.Click += new System.EventHandler(this.ButtonPeek_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(384, 16);
            this.labelControl1.TabIndex = 118;
            this.labelControl1.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F ";
            // 
            // ButtonNew
            // 
            this.ButtonNew.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonNew.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonNew.Location = new System.Drawing.Point(201, 42);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(66, 24);
            this.ButtonNew.TabIndex = 119;
            this.ButtonNew.Text = "New";
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // PeekPokeAddressTextBox
            // 
            this.PeekPokeAddressTextBox.EditValue = "C0000000";
            this.PeekPokeAddressTextBox.Location = new System.Drawing.Point(95, 14);
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
            this.peekLengthTextBox.Location = new System.Drawing.Point(95, 44);
            this.peekLengthTextBox.Name = "peekLengthTextBox";
            this.peekLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.peekLengthTextBox.TabIndex = 121;
            this.peekLengthTextBox.Leave += new System.EventHandler(this.FixTheAddresses);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 122;
            this.labelControl2.Text = "Address 0x:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 48);
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
            // ButtonDumpMemory
            // 
            this.ButtonDumpMemory.AllowFocus = false;
            this.ButtonDumpMemory.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDumpMemory.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDumpMemory.Location = new System.Drawing.Point(273, 42);
            this.ButtonDumpMemory.Name = "ButtonDumpMemory";
            this.ButtonDumpMemory.Size = new System.Drawing.Size(107, 24);
            this.ButtonDumpMemory.TabIndex = 126;
            this.ButtonDumpMemory.Text = "Dump Memory";
            this.ButtonDumpMemory.Click += new System.EventHandler(this.ButtonDumpMemory_Click);
            // 
            // ButtonPoke
            // 
            this.ButtonPoke.Location = new System.Drawing.Point(273, 12);
            this.ButtonPoke.Name = "ButtonPoke";
            this.ButtonPoke.Size = new System.Drawing.Size(66, 24);
            this.ButtonPoke.TabIndex = 125;
            this.ButtonPoke.Text = "Poke";
            this.ButtonPoke.Click += new System.EventHandler(this.ButtonPoke_Click);
            // 
            // CheckBoxAutoPeek
            // 
            this.CheckBoxAutoPeek.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.CheckBoxAutoPeek.Location = new System.Drawing.Point(396, 9);
            this.CheckBoxAutoPeek.Name = "CheckBoxAutoPeek";
            this.CheckBoxAutoPeek.Properties.AllowFocused = false;
            this.CheckBoxAutoPeek.Properties.Caption = "Auto Peek";
            this.CheckBoxAutoPeek.Size = new System.Drawing.Size(75, 18);
            this.CheckBoxAutoPeek.TabIndex = 127;
            // 
            // CheckBoxAutoPoke
            // 
            this.CheckBoxAutoPoke.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.CheckBoxAutoPoke.Location = new System.Drawing.Point(396, 34);
            this.CheckBoxAutoPoke.Name = "CheckBoxAutoPoke";
            this.CheckBoxAutoPoke.Properties.AllowFocused = false;
            this.CheckBoxAutoPoke.Properties.Caption = "Auto Poke";
            this.CheckBoxAutoPoke.Size = new System.Drawing.Size(75, 18);
            this.CheckBoxAutoPoke.TabIndex = 128;
            // 
            // TextBoxSelectedAddress
            // 
            this.TextBoxSelectedAddress.EditValue = "";
            this.TextBoxSelectedAddress.Location = new System.Drawing.Point(733, 8);
            this.TextBoxSelectedAddress.Name = "TextBoxSelectedAddress";
            this.TextBoxSelectedAddress.Size = new System.Drawing.Size(109, 20);
            this.TextBoxSelectedAddress.TabIndex = 129;
            this.TextBoxSelectedAddress.DoubleClick += new System.EventHandler(this.ButtonSelectedAddress_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.SwitchFreezeConsole);
            this.groupControl1.Location = new System.Drawing.Point(660, 148);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(182, 47);
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
            // SwitchFreezeConsole
            // 
            this.SwitchFreezeConsole.Location = new System.Drawing.Point(103, 24);
            this.SwitchFreezeConsole.Name = "SwitchFreezeConsole";
            this.SwitchFreezeConsole.Properties.OffText = "";
            this.SwitchFreezeConsole.Properties.OnText = "";
            this.SwitchFreezeConsole.Size = new System.Drawing.Size(69, 19);
            this.SwitchFreezeConsole.TabIndex = 132;
            this.SwitchFreezeConsole.Toggled += new System.EventHandler(this.SwitchFreezeConsole_Toggled);
            // 
            // TextBoxPeekPokeFeedback
            // 
            this.TextBoxPeekPokeFeedback.EditValue = "";
            this.TextBoxPeekPokeFeedback.Location = new System.Drawing.Point(733, 34);
            this.TextBoxPeekPokeFeedback.Name = "TextBoxPeekPokeFeedback";
            this.TextBoxPeekPokeFeedback.Size = new System.Drawing.Size(109, 20);
            this.TextBoxPeekPokeFeedback.TabIndex = 132;
            this.TextBoxPeekPokeFeedback.DoubleClick += new System.EventHandler(this.TextBoxPeekPokeFeedback_DoubleClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(621, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 13);
            this.labelControl4.TabIndex = 134;
            this.labelControl4.Text = "Peek/Poke Feedback:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(637, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 13);
            this.labelControl5.TabIndex = 133;
            this.labelControl5.Text = "Selected Address:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(660, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(126, 13);
            this.labelControl6.TabIndex = 135;
            this.labelControl6.Text = "Fill The Memory With 0x:";
            // 
            // SwitchFillMemory
            // 
            this.SwitchFillMemory.Location = new System.Drawing.Point(660, 118);
            this.SwitchFillMemory.Name = "SwitchFillMemory";
            this.SwitchFillMemory.Properties.OffText = "";
            this.SwitchFillMemory.Properties.OnText = "";
            this.SwitchFillMemory.Size = new System.Drawing.Size(69, 19);
            this.SwitchFillMemory.TabIndex = 133;
            // 
            // TextBoxFillValue
            // 
            this.TextBoxFillValue.EditValue = "";
            this.TextBoxFillValue.Location = new System.Drawing.Point(802, 96);
            this.TextBoxFillValue.Name = "TextBoxFillValue";
            this.TextBoxFillValue.Size = new System.Drawing.Size(40, 20);
            this.TextBoxFillValue.TabIndex = 136;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.SwitchIsSigned);
            this.groupControl2.Controls.Add(this.NumericInt32);
            this.groupControl2.Controls.Add(this.NumericInt16);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.NumericFloatTextBox);
            this.groupControl2.Controls.Add(this.NumericInt8);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Location = new System.Drawing.Point(660, 201);
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
            // SwitchIsSigned
            // 
            this.SwitchIsSigned.Location = new System.Drawing.Point(103, 27);
            this.SwitchIsSigned.Name = "SwitchIsSigned";
            this.SwitchIsSigned.Properties.OffText = "";
            this.SwitchIsSigned.Properties.OnText = "";
            this.SwitchIsSigned.Size = new System.Drawing.Size(69, 19);
            this.SwitchIsSigned.TabIndex = 138;
            this.SwitchIsSigned.Toggled += new System.EventHandler(this.SwitchIsSigned_Toggled);
            // 
            // NumericInt32
            // 
            this.NumericInt32.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericInt32.Location = new System.Drawing.Point(63, 123);
            this.NumericInt32.Name = "NumericInt32";
            this.NumericInt32.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumericInt32.Properties.MaskSettings.Set("mask", "");
            this.NumericInt32.Size = new System.Drawing.Size(109, 20);
            this.NumericInt32.TabIndex = 143;
            this.NumericInt32.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            this.NumericInt32.DoubleClick += new System.EventHandler(this.NumericInt32_DoubleClick);
            this.NumericInt32.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericIntKeyPress);
            // 
            // NumericInt16
            // 
            this.NumericInt16.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericInt16.Location = new System.Drawing.Point(63, 91);
            this.NumericInt16.Name = "NumericInt16";
            this.NumericInt16.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumericInt16.Size = new System.Drawing.Size(109, 20);
            this.NumericInt16.TabIndex = 142;
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
            this.NumericFloatTextBox.Size = new System.Drawing.Size(109, 20);
            this.NumericFloatTextBox.TabIndex = 139;
            this.NumericFloatTextBox.DoubleClick += new System.EventHandler(this.NumericFloatTextBox_DoubleClick);
            this.NumericFloatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericIntKeyPress);
            // 
            // NumericInt8
            // 
            this.NumericInt8.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericInt8.Location = new System.Drawing.Point(63, 59);
            this.NumericInt8.Name = "NumericInt8";
            this.NumericInt8.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumericInt8.Size = new System.Drawing.Size(109, 20);
            this.NumericInt8.TabIndex = 138;
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
            this.textEdit5.Location = new System.Drawing.Point(804, 60);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(38, 20);
            this.textEdit5.TabIndex = 139;
            this.textEdit5.Visible = false;
            // 
            // ButtonSet
            // 
            this.ButtonSet.AllowFocus = false;
            this.ButtonSet.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSet.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonSet.Location = new System.Drawing.Point(733, 60);
            this.ButtonSet.Name = "ButtonSet";
            this.ButtonSet.Size = new System.Drawing.Size(38, 20);
            this.ButtonSet.TabIndex = 140;
            this.ButtonSet.Text = "Set";
            this.ButtonSet.Visible = false;
            this.ButtonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // TextBoxPasteClipboard
            // 
            this.TextBoxPasteClipboard.EditValue = "";
            this.TextBoxPasteClipboard.Location = new System.Drawing.Point(777, 60);
            this.TextBoxPasteClipboard.Name = "TextBoxPasteClipboard";
            this.TextBoxPasteClipboard.Size = new System.Drawing.Size(21, 20);
            this.TextBoxPasteClipboard.TabIndex = 141;
            this.TextBoxPasteClipboard.Visible = false;
            // 
            // MemoryViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 514);
            this.Controls.Add(this.TextBoxPasteClipboard);
            this.Controls.Add(this.ButtonSet);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.TextBoxFillValue);
            this.Controls.Add(this.SwitchFillMemory);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TextBoxPeekPokeFeedback);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.TextBoxSelectedAddress);
            this.Controls.Add(this.CheckBoxAutoPoke);
            this.Controls.Add(this.CheckBoxAutoPeek);
            this.Controls.Add(this.ButtonDumpMemory);
            this.Controls.Add(this.ButtonPoke);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.peekLengthTextBox);
            this.Controls.Add(this.PeekPokeAddressTextBox);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ButtonPeek);
            this.Controls.Add(this.HexBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memory Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemoryViewer_FormClosing);
            this.Load += new System.EventHandler(this.MemoryViewer_Load);
            this.BackColorChanged += new System.EventHandler(this.MemoryViewer_BackColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PeekPokeAddressTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peekLengthTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoPeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBoxAutoPoke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxSelectedAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchFreezeConsole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPeekPokeFeedback.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchFillMemory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxFillValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwitchIsSigned.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt32.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericFloatTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInt8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPasteClipboard.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        public Be.Windows.Forms.HexBox HexBox;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton ButtonPeek;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonNew;
        private DevExpress.XtraEditors.TextEdit PeekPokeAddressTextBox;
        private DevExpress.XtraEditors.TextEdit peekLengthTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Timer AutoPeek;
        private System.Windows.Forms.Timer AutoPoke;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton ButtonDumpMemory;
        private DevExpress.XtraEditors.SimpleButton ButtonPoke;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoPeek;
        private DevExpress.XtraEditors.CheckEdit CheckBoxAutoPoke;
        private DevExpress.XtraEditors.TextEdit TextBoxSelectedAddress;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ToggleSwitch SwitchFreezeConsole;
        private DevExpress.XtraEditors.TextEdit TextBoxPeekPokeFeedback;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ToggleSwitch SwitchFillMemory;
        private DevExpress.XtraEditors.TextEdit TextBoxFillValue;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ToggleSwitch SwitchIsSigned;
        private DevExpress.XtraEditors.SpinEdit NumericInt32;
        private DevExpress.XtraEditors.SpinEdit NumericInt16;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit NumericFloatTextBox;
        private DevExpress.XtraEditors.SpinEdit NumericInt8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.SimpleButton ButtonSet;
        private DevExpress.XtraEditors.TextEdit TextBoxPasteClipboard;
    }
}