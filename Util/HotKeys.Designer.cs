namespace ChromaSelect.Util
{
    partial class HotKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotKeys));
            this.PanelNotifColor = new Guna.UI2.WinForms.Guna2Panel();
            this.NotifBox = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TxtNotif = new System.Windows.Forms.Label();
            this.NotifBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelNotifColor
            // 
            this.PanelNotifColor.AccessibleName = "PanelNotifColor";
            this.PanelNotifColor.BackColor = System.Drawing.Color.White;
            this.PanelNotifColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelNotifColor.FillColor = System.Drawing.Color.White;
            this.PanelNotifColor.Location = new System.Drawing.Point(0, -3);
            this.PanelNotifColor.Name = "PanelNotifColor";
            this.PanelNotifColor.Size = new System.Drawing.Size(5, 144);
            this.PanelNotifColor.TabIndex = 7;
            this.PanelNotifColor.Click += new System.EventHandler(this.HotKeys_Click);
            // 
            // NotifBox
            // 
            this.NotifBox.AccessibleName = "NotifBox";
            this.NotifBox.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.NotifBox.BorderThickness = 1;
            this.NotifBox.Controls.Add(this.LabelTitle);
            this.NotifBox.Controls.Add(this.TxtNotif);
            this.NotifBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifBox.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NotifBox.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NotifBox.FillColor = global::ChromaSelect.Properties.Settings.Default.BGSecondary;
            this.NotifBox.Location = new System.Drawing.Point(15, 10);
            this.NotifBox.Name = "NotifBox";
            this.NotifBox.Size = new System.Drawing.Size(223, 124);
            this.NotifBox.TabIndex = 8;
            this.NotifBox.Click += new System.EventHandler(this.HotKeys_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AccessibleName = "LabelTitle";
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.LabelTitle.Location = new System.Drawing.Point(10, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(186, 21);
            this.LabelTitle.TabIndex = 3;
            this.LabelTitle.Text = "Hotkeys - ChromaSelect";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelTitle.Click += new System.EventHandler(this.HotKeys_Click);
            // 
            // TxtNotif
            // 
            this.TxtNotif.AccessibleName = "TxtNotif";
            this.TxtNotif.AutoSize = true;
            this.TxtNotif.BackColor = System.Drawing.Color.Transparent;
            this.TxtNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNotif.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::ChromaSelect.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtNotif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtNotif.ForeColor = global::ChromaSelect.Properties.Settings.Default.TextColor;
            this.TxtNotif.Location = new System.Drawing.Point(10, 30);
            this.TxtNotif.Name = "TxtNotif";
            this.TxtNotif.Size = new System.Drawing.Size(204, 84);
            this.TxtNotif.TabIndex = 3;
            this.TxtNotif.Text = "Escape = Close Window\r\nCtrl + W = Close Window\r\nCtrl + C = Copy Hex\r\nCtrl + Shift" +
    " + C = Copy RGB";
            this.TxtNotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtNotif.Click += new System.EventHandler(this.HotKeys_Click);
            // 
            // HotKeys
            // 
            this.AccessibleName = "HotKeys";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::ChromaSelect.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(248, 144);
            this.Controls.Add(this.PanelNotifColor);
            this.Controls.Add(this.NotifBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ChromaSelect.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotKeys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HotKeys";
            this.Click += new System.EventHandler(this.HotKeys_Click);
            this.NotifBox.ResumeLayout(false);
            this.NotifBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelNotifColor;
        private Guna.UI2.WinForms.Guna2Panel NotifBox;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label TxtNotif;
    }
}