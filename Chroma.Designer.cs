namespace ChromaSelect
{
    partial class ChromaSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChromaSelect));
            this.LabelMadeBy = new System.Windows.Forms.Label();
            this.PanelSEEBody = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelColorPreview = new Guna.UI2.WinForms.Guna2Button();
            this.PanelOutlineBlock6 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnColorPicker = new Guna.UI2.WinForms.Guna2Button();
            this.PanelOutlineBlock5 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelOutlineBlock4 = new Guna.UI2.WinForms.Guna2Panel();
            this.TxtHexColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelOutlineBlock3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelBlue = new System.Windows.Forms.Label();
            this.PanelOutlineBlock2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelOutlineBlock1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelGreen = new System.Windows.Forms.Label();
            this.LabelRed = new System.Windows.Forms.Label();
            this.SliderBlue = new System.Windows.Forms.TrackBar();
            this.SliderGreen = new System.Windows.Forms.TrackBar();
            this.SliderRed = new System.Windows.Forms.TrackBar();
            this.TxtRGBColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelSEEHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHotKeys = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.PanelSEEBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).BeginInit();
            this.PanelSEEHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMadeBy
            // 
            this.LabelMadeBy.AccessibleName = "LabelMadeBy";
            this.LabelMadeBy.BackColor = System.Drawing.Color.Transparent;
            this.LabelMadeBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMadeBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelMadeBy.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelMadeBy.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelMadeBy.Location = new System.Drawing.Point(304, 344);
            this.LabelMadeBy.Name = "LabelMadeBy";
            this.LabelMadeBy.Size = new System.Drawing.Size(128, 17);
            this.LabelMadeBy.TabIndex = 22;
            this.LabelMadeBy.Text = "Made by Papa Quill";
            this.LabelMadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelMadeBy.Enter += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelMadeBy.MouseEnter += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelMadeBy.MouseLeave += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelMadeBy.MouseHover += new System.EventHandler(this.ChromaSelect_Enter);
            // 
            // PanelSEEBody
            // 
            this.PanelSEEBody.AccessibleName = "PanelSEEBody";
            this.PanelSEEBody.BackColor = System.Drawing.Color.Transparent;
            this.PanelSEEBody.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.PanelSEEBody.BorderRadius = global::ChromaSelect.Properties.Settings.Default.BorderRadius;
            this.PanelSEEBody.BorderThickness = 1;
            this.PanelSEEBody.Controls.Add(this.PanelColorPreview);
            this.PanelSEEBody.Controls.Add(this.PanelOutlineBlock6);
            this.PanelSEEBody.Controls.Add(this.BtnColorPicker);
            this.PanelSEEBody.Controls.Add(this.PanelOutlineBlock5);
            this.PanelSEEBody.Controls.Add(this.PanelOutlineBlock4);
            this.PanelSEEBody.Controls.Add(this.TxtHexColor);
            this.PanelSEEBody.Controls.Add(this.PanelOutlineBlock3);
            this.PanelSEEBody.Controls.Add(this.LabelBlue);
            this.PanelSEEBody.Controls.Add(this.PanelOutlineBlock2);
            this.PanelSEEBody.Controls.Add(this.PanelOutlineBlock1);
            this.PanelSEEBody.Controls.Add(this.LabelGreen);
            this.PanelSEEBody.Controls.Add(this.LabelRed);
            this.PanelSEEBody.Controls.Add(this.SliderBlue);
            this.PanelSEEBody.Controls.Add(this.SliderGreen);
            this.PanelSEEBody.Controls.Add(this.SliderRed);
            this.PanelSEEBody.Controls.Add(this.TxtRGBColor);
            this.PanelSEEBody.CustomizableEdges.TopLeft = false;
            this.PanelSEEBody.CustomizableEdges.TopRight = false;
            this.PanelSEEBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::ChromaSelect.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEBody.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEBody.FillColor = global::ChromaSelect.Properties.Settings.Default.BGSecondary;
            this.PanelSEEBody.Location = new System.Drawing.Point(10, 69);
            this.PanelSEEBody.Name = "PanelSEEBody";
            this.PanelSEEBody.Size = new System.Drawing.Size(417, 273);
            this.PanelSEEBody.TabIndex = 19;
            this.PanelSEEBody.Enter += new System.EventHandler(this.ChromaSelect_Enter);
            this.PanelSEEBody.MouseEnter += new System.EventHandler(this.ChromaSelect_Enter);
            // 
            // PanelColorPreview
            // 
            this.PanelColorPreview.AccessibleName = "PanelColorPreview";
            this.PanelColorPreview.Animated = true;
            this.PanelColorPreview.BackColor = System.Drawing.Color.Transparent;
            this.PanelColorPreview.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.PanelColorPreview.BorderThickness = 1;
            this.PanelColorPreview.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.PanelColorPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelColorPreview.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelColorPreview.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelColorPreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelColorPreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PanelColorPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PanelColorPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PanelColorPreview.Font = new System.Drawing.Font("Gadugi", 10F);
            this.PanelColorPreview.ForeColor = System.Drawing.Color.White;
            this.PanelColorPreview.ImageSize = new System.Drawing.Size(16, 16);
            this.PanelColorPreview.Location = new System.Drawing.Point(117, 219);
            this.PanelColorPreview.Name = "PanelColorPreview";
            this.PanelColorPreview.PressedColor = System.Drawing.Color.Empty;
            this.PanelColorPreview.Size = new System.Drawing.Size(182, 45);
            this.PanelColorPreview.TabIndex = 16;
            // 
            // PanelOutlineBlock6
            // 
            this.PanelOutlineBlock6.AccessibleName = "PanelOutlineBlock6";
            this.PanelOutlineBlock6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock6.Location = new System.Drawing.Point(97, 7);
            this.PanelOutlineBlock6.Name = "PanelOutlineBlock6";
            this.PanelOutlineBlock6.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock6.TabIndex = 15;
            // 
            // BtnColorPicker
            // 
            this.BtnColorPicker.AccessibleName = "BtnColorPicker";
            this.BtnColorPicker.Animated = true;
            this.BtnColorPicker.BorderColor = System.Drawing.Color.White;
            this.BtnColorPicker.BorderThickness = 1;
            this.BtnColorPicker.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnColorPicker.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorPicker.FillColor = System.Drawing.Color.Empty;
            this.BtnColorPicker.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnColorPicker.ForeColor = System.Drawing.Color.White;
            this.BtnColorPicker.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("BtnColorPicker.Image")));
            this.BtnColorPicker.Location = new System.Drawing.Point(77, 226);
            this.BtnColorPicker.Name = "BtnColorPicker";
            this.BtnColorPicker.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnColorPicker.Size = new System.Drawing.Size(30, 30);
            this.BtnColorPicker.TabIndex = 4;
            this.BtnColorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColorPicker_MouseDown);
            this.BtnColorPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnColorPicker_MouseUp);
            // 
            // PanelOutlineBlock5
            // 
            this.PanelOutlineBlock5.AccessibleName = "PanelOutlineBlock5";
            this.PanelOutlineBlock5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock5.Location = new System.Drawing.Point(97, 40);
            this.PanelOutlineBlock5.Name = "PanelOutlineBlock5";
            this.PanelOutlineBlock5.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock5.TabIndex = 15;
            // 
            // PanelOutlineBlock4
            // 
            this.PanelOutlineBlock4.AccessibleName = "PanelOutlineBlock4";
            this.PanelOutlineBlock4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock4.Location = new System.Drawing.Point(97, 74);
            this.PanelOutlineBlock4.Name = "PanelOutlineBlock4";
            this.PanelOutlineBlock4.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock4.TabIndex = 15;
            // 
            // TxtHexColor
            // 
            this.TxtHexColor.AccessibleName = "TxtHexColor";
            this.TxtHexColor.Animated = true;
            this.TxtHexColor.BackColor = System.Drawing.Color.Transparent;
            this.TxtHexColor.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.TxtHexColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::ChromaSelect.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DefaultText = "";
            this.TxtHexColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtHexColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtHexColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtHexColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtHexColor.FillColor = global::ChromaSelect.Properties.Settings.Default.BGButton;
            this.TxtHexColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtHexColor.Font = new System.Drawing.Font("Gadugi", 10F);
            this.TxtHexColor.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.TxtHexColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtHexColor.Location = new System.Drawing.Point(117, 119);
            this.TxtHexColor.MaxLength = 255;
            this.TxtHexColor.Name = "TxtHexColor";
            this.TxtHexColor.PasswordChar = '\0';
            this.TxtHexColor.PlaceholderForeColor = global::ChromaSelect.Properties.Settings.Default.PlaceholderColor;
            this.TxtHexColor.PlaceholderText = "Hex Color";
            this.TxtHexColor.SelectedText = "";
            this.TxtHexColor.Size = new System.Drawing.Size(182, 41);
            this.TxtHexColor.TabIndex = 4;
            this.TxtHexColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtHexColor.Leave += new System.EventHandler(this.TxtHexColor_Leave);
            // 
            // PanelOutlineBlock3
            // 
            this.PanelOutlineBlock3.AccessibleName = "PanelOutlineBlock3";
            this.PanelOutlineBlock3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock3.Location = new System.Drawing.Point(97, 125);
            this.PanelOutlineBlock3.Name = "PanelOutlineBlock3";
            this.PanelOutlineBlock3.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock3.TabIndex = 15;
            // 
            // LabelBlue
            // 
            this.LabelBlue.AccessibleName = "LabelBlue";
            this.LabelBlue.AutoSize = true;
            this.LabelBlue.BackColor = System.Drawing.Color.Transparent;
            this.LabelBlue.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelBlue.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelBlue.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelBlue.Location = new System.Drawing.Point(70, 82);
            this.LabelBlue.Name = "LabelBlue";
            this.LabelBlue.Size = new System.Drawing.Size(16, 17);
            this.LabelBlue.TabIndex = 15;
            this.LabelBlue.Text = "B";
            this.LabelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelOutlineBlock2
            // 
            this.PanelOutlineBlock2.AccessibleName = "PanelOutlineBlock2";
            this.PanelOutlineBlock2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock2.Location = new System.Drawing.Point(93, 5);
            this.PanelOutlineBlock2.Name = "PanelOutlineBlock2";
            this.PanelOutlineBlock2.Size = new System.Drawing.Size(10, 130);
            this.PanelOutlineBlock2.TabIndex = 15;
            // 
            // PanelOutlineBlock1
            // 
            this.PanelOutlineBlock1.AccessibleName = "PanelOutlineBlock1";
            this.PanelOutlineBlock1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock1.Location = new System.Drawing.Point(316, 5);
            this.PanelOutlineBlock1.Name = "PanelOutlineBlock1";
            this.PanelOutlineBlock1.Size = new System.Drawing.Size(10, 128);
            this.PanelOutlineBlock1.TabIndex = 15;
            // 
            // LabelGreen
            // 
            this.LabelGreen.AccessibleName = "LabelGreen";
            this.LabelGreen.AutoSize = true;
            this.LabelGreen.BackColor = System.Drawing.Color.Transparent;
            this.LabelGreen.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelGreen.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelGreen.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelGreen.Location = new System.Drawing.Point(69, 48);
            this.LabelGreen.Name = "LabelGreen";
            this.LabelGreen.Size = new System.Drawing.Size(18, 17);
            this.LabelGreen.TabIndex = 15;
            this.LabelGreen.Text = "G";
            this.LabelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelRed
            // 
            this.LabelRed.AccessibleName = "LabelRed";
            this.LabelRed.AutoSize = true;
            this.LabelRed.BackColor = System.Drawing.Color.Transparent;
            this.LabelRed.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelRed.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelRed.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelRed.Location = new System.Drawing.Point(70, 14);
            this.LabelRed.Name = "LabelRed";
            this.LabelRed.Size = new System.Drawing.Size(16, 17);
            this.LabelRed.TabIndex = 15;
            this.LabelRed.Text = "R";
            this.LabelRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SliderBlue
            // 
            this.SliderBlue.AccessibleName = "SliderBlue";
            this.SliderBlue.BackColor = global::ChromaSelect.Properties.Settings.Default.BGSecondary;
            this.SliderBlue.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ChromaSelect.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SliderBlue.Location = new System.Drawing.Point(100, 82);
            this.SliderBlue.Maximum = 255;
            this.SliderBlue.Name = "SliderBlue";
            this.SliderBlue.Size = new System.Drawing.Size(217, 45);
            this.SliderBlue.SmallChange = 5;
            this.SliderBlue.TabIndex = 5;
            this.SliderBlue.TickFrequency = 17;
            this.SliderBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderBlue.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // SliderGreen
            // 
            this.SliderGreen.AccessibleName = "SliderGreen";
            this.SliderGreen.BackColor = global::ChromaSelect.Properties.Settings.Default.BGSecondary;
            this.SliderGreen.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ChromaSelect.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SliderGreen.Location = new System.Drawing.Point(100, 48);
            this.SliderGreen.Maximum = 255;
            this.SliderGreen.Name = "SliderGreen";
            this.SliderGreen.Size = new System.Drawing.Size(217, 45);
            this.SliderGreen.SmallChange = 5;
            this.SliderGreen.TabIndex = 5;
            this.SliderGreen.TickFrequency = 17;
            this.SliderGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderGreen.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // SliderRed
            // 
            this.SliderRed.AccessibleName = "SliderRed";
            this.SliderRed.BackColor = global::ChromaSelect.Properties.Settings.Default.BGSecondary;
            this.SliderRed.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ChromaSelect.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SliderRed.Location = new System.Drawing.Point(100, 14);
            this.SliderRed.Maximum = 255;
            this.SliderRed.Name = "SliderRed";
            this.SliderRed.Size = new System.Drawing.Size(217, 45);
            this.SliderRed.SmallChange = 5;
            this.SliderRed.TabIndex = 5;
            this.SliderRed.TickFrequency = 17;
            this.SliderRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderRed.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // TxtRGBColor
            // 
            this.TxtRGBColor.AccessibleName = "TxtRGBColor";
            this.TxtRGBColor.Animated = true;
            this.TxtRGBColor.BackColor = System.Drawing.Color.Transparent;
            this.TxtRGBColor.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.TxtRGBColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGButton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::ChromaSelect.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DefaultText = "";
            this.TxtRGBColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRGBColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRGBColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRGBColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRGBColor.FillColor = global::ChromaSelect.Properties.Settings.Default.BGButton;
            this.TxtRGBColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtRGBColor.Font = new System.Drawing.Font("Gadugi", 10F);
            this.TxtRGBColor.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.TxtRGBColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtRGBColor.Location = new System.Drawing.Point(117, 170);
            this.TxtRGBColor.MaxLength = 255;
            this.TxtRGBColor.Name = "TxtRGBColor";
            this.TxtRGBColor.PasswordChar = '\0';
            this.TxtRGBColor.PlaceholderForeColor = global::ChromaSelect.Properties.Settings.Default.PlaceholderColor;
            this.TxtRGBColor.PlaceholderText = "RGB Color";
            this.TxtRGBColor.SelectedText = "";
            this.TxtRGBColor.Size = new System.Drawing.Size(182, 41);
            this.TxtRGBColor.TabIndex = 4;
            this.TxtRGBColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRGBColor.Leave += new System.EventHandler(this.TxtRGBColor_Leave);
            // 
            // PanelSEEHeader
            // 
            this.PanelSEEHeader.AccessibleName = "PanelSEEHeader";
            this.PanelSEEHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelSEEHeader.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.PanelSEEHeader.BorderRadius = global::ChromaSelect.Properties.Settings.Default.BorderRadius;
            this.PanelSEEHeader.BorderThickness = 1;
            this.PanelSEEHeader.Controls.Add(this.BtnClose);
            this.PanelSEEHeader.Controls.Add(this.BtnHotKeys);
            this.PanelSEEHeader.Controls.Add(this.BtnMinimize);
            this.PanelSEEHeader.Controls.Add(this.LabelTitle);
            this.PanelSEEHeader.CustomizableEdges.BottomLeft = false;
            this.PanelSEEHeader.CustomizableEdges.BottomRight = false;
            this.PanelSEEHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::ChromaSelect.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEHeader.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEHeader.FillColor = global::ChromaSelect.Properties.Settings.Default.BGTertiary;
            this.PanelSEEHeader.Location = new System.Drawing.Point(10, 10);
            this.PanelSEEHeader.Name = "PanelSEEHeader";
            this.PanelSEEHeader.Size = new System.Drawing.Size(417, 60);
            this.PanelSEEHeader.TabIndex = 20;
            this.PanelSEEHeader.Enter += new System.EventHandler(this.ChromaSelect_Enter);
            this.PanelSEEHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.PanelSEEHeader.MouseEnter += new System.EventHandler(this.ChromaSelect_Enter);
            this.PanelSEEHeader.MouseLeave += new System.EventHandler(this.ChromaSelect_Enter);
            this.PanelSEEHeader.MouseHover += new System.EventHandler(this.ChromaSelect_Enter);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleName = "BtnClose";
            this.BtnClose.Animated = true;
            this.BtnClose.BorderColor = System.Drawing.Color.White;
            this.BtnClose.BorderThickness = 1;
            this.BtnClose.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnClose.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FillColor = System.Drawing.Color.Empty;
            this.BtnClose.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(371, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnHotKeys
            // 
            this.BtnHotKeys.AccessibleName = "BtnHotKeys";
            this.BtnHotKeys.Animated = true;
            this.BtnHotKeys.BorderColor = System.Drawing.Color.White;
            this.BtnHotKeys.BorderThickness = 1;
            this.BtnHotKeys.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnHotKeys.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHotKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHotKeys.FillColor = System.Drawing.Color.Empty;
            this.BtnHotKeys.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnHotKeys.ForeColor = System.Drawing.Color.White;
            this.BtnHotKeys.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnHotKeys.Location = new System.Drawing.Point(281, 15);
            this.BtnHotKeys.Name = "BtnHotKeys";
            this.BtnHotKeys.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnHotKeys.Size = new System.Drawing.Size(30, 30);
            this.BtnHotKeys.TabIndex = 4;
            this.BtnHotKeys.Text = "?";
            this.BtnHotKeys.Click += new System.EventHandler(this.BtnHotKeys_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.AccessibleName = "BtnMinimize";
            this.BtnMinimize.Animated = true;
            this.BtnMinimize.BorderColor = System.Drawing.Color.White;
            this.BtnMinimize.BorderThickness = 1;
            this.BtnMinimize.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnMinimize.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FillColor = System.Drawing.Color.Empty;
            this.BtnMinimize.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(326, 15);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AccessibleName = "LabelTitle";
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelTitle.Location = new System.Drawing.Point(4, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(214, 40);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "Chroma Select";
            this.LabelTitle.Enter += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.LabelTitle.MouseEnter += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelTitle.MouseLeave += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelTitle.MouseHover += new System.EventHandler(this.ChromaSelect_Enter);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AccessibleName = "LabelVersion";
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ChromaSelect.Properties.Settings.Default, "Version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelVersion.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelVersion.Location = new System.Drawing.Point(8, 344);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(45, 17);
            this.LabelVersion.TabIndex = 21;
            this.LabelVersion.Text = global::ChromaSelect.Properties.Settings.Default.Version;
            this.LabelVersion.Enter += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.LabelVersion.MouseEnter += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelVersion.MouseLeave += new System.EventHandler(this.ChromaSelect_Enter);
            this.LabelVersion.MouseHover += new System.EventHandler(this.ChromaSelect_Enter);
            // 
            // ChromaSelect
            // 
            this.AccessibleName = "ChromaSelect";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(437, 364);
            this.Controls.Add(this.LabelMadeBy);
            this.Controls.Add(this.PanelSEEBody);
            this.Controls.Add(this.PanelSEEHeader);
            this.Controls.Add(this.LabelVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChromaSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chroma Select";
            this.TopMost = true;
            this.Enter += new System.EventHandler(this.ChromaSelect_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.MouseEnter += new System.EventHandler(this.ChromaSelect_Enter);
            this.MouseLeave += new System.EventHandler(this.ChromaSelect_Enter);
            this.MouseHover += new System.EventHandler(this.ChromaSelect_Enter);
            this.PanelSEEBody.ResumeLayout(false);
            this.PanelSEEBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).EndInit();
            this.PanelSEEHeader.ResumeLayout(false);
            this.PanelSEEHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMadeBy;
        private Guna.UI2.WinForms.Guna2Panel PanelSEEBody;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock6;
        private Guna.UI2.WinForms.Guna2Button BtnColorPicker;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock5;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock4;
        private Guna.UI2.WinForms.Guna2TextBox TxtHexColor;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock3;
        private System.Windows.Forms.Label LabelBlue;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock2;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock1;
        private System.Windows.Forms.Label LabelGreen;
        private System.Windows.Forms.Label LabelRed;
        private System.Windows.Forms.TrackBar SliderBlue;
        private System.Windows.Forms.TrackBar SliderGreen;
        private System.Windows.Forms.TrackBar SliderRed;
        private Guna.UI2.WinForms.Guna2TextBox TxtRGBColor;
        private Guna.UI2.WinForms.Guna2Panel PanelSEEHeader;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnMinimize;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelVersion;
        private Guna.UI2.WinForms.Guna2Button PanelColorPreview;
        private Guna.UI2.WinForms.Guna2Button BtnHotKeys;
    }
}

