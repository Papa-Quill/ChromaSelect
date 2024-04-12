namespace ChromaSelect.Util
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.NotifBox = new Guna.UI2.WinForms.Guna2Panel();
            this.TxtNotif = new System.Windows.Forms.Label();
            this.ImgGCTIcon = new System.Windows.Forms.PictureBox();
            this.PanelNotifColor = new Guna.UI2.WinForms.Guna2Panel();
            this.NotifBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGCTIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // NotifBox
            // 
            this.NotifBox.AccessibleName = "NotifBox";
            this.NotifBox.BorderColor = global::ChromaSelect.Properties.Settings.Default.DetailColor;
            this.NotifBox.BorderThickness = 1;
            this.NotifBox.Controls.Add(this.TxtNotif);
            this.NotifBox.Controls.Add(this.ImgGCTIcon);
            this.NotifBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifBox.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::ChromaSelect.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NotifBox.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::ChromaSelect.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NotifBox.FillColor = global::ChromaSelect.Properties.Settings.Default.BGSecondary;
            this.NotifBox.Location = new System.Drawing.Point(15, 10);
            this.NotifBox.Name = "NotifBox";
            this.NotifBox.Size = new System.Drawing.Size(226, 50);
            this.NotifBox.TabIndex = 5;
            this.NotifBox.Click += new System.EventHandler(this.NotifBox_Click);
            this.NotifBox.MouseEnter += new System.EventHandler(this.NotifBox_MouseHover);
            this.NotifBox.MouseLeave += new System.EventHandler(this.NotifBox_MouseLeave);
            this.NotifBox.MouseHover += new System.EventHandler(this.NotifBox_MouseHover);
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
            this.TxtNotif.Location = new System.Drawing.Point(64, 14);
            this.TxtNotif.Name = "TxtNotif";
            this.TxtNotif.Size = new System.Drawing.Size(71, 21);
            this.TxtNotif.TabIndex = 3;
            this.TxtNotif.Text = "NotifText";
            this.TxtNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TxtNotif.Click += new System.EventHandler(this.NotifBox_Click);
            this.TxtNotif.MouseEnter += new System.EventHandler(this.NotifBox_MouseHover);
            this.TxtNotif.MouseLeave += new System.EventHandler(this.NotifBox_MouseLeave);
            this.TxtNotif.MouseHover += new System.EventHandler(this.NotifBox_MouseHover);
            // 
            // ImgGCTIcon
            // 
            this.ImgGCTIcon.AccessibleName = "ImgGCTIcon";
            this.ImgGCTIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgGCTIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImgGCTIcon.Image")));
            this.ImgGCTIcon.Location = new System.Drawing.Point(11, 1);
            this.ImgGCTIcon.Name = "ImgGCTIcon";
            this.ImgGCTIcon.Size = new System.Drawing.Size(48, 48);
            this.ImgGCTIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgGCTIcon.TabIndex = 2;
            this.ImgGCTIcon.TabStop = false;
            this.ImgGCTIcon.Click += new System.EventHandler(this.NotifBox_Click);
            this.ImgGCTIcon.MouseEnter += new System.EventHandler(this.NotifBox_MouseHover);
            this.ImgGCTIcon.MouseLeave += new System.EventHandler(this.NotifBox_MouseLeave);
            this.ImgGCTIcon.MouseHover += new System.EventHandler(this.NotifBox_MouseHover);
            // 
            // PanelNotifColor
            // 
            this.PanelNotifColor.AccessibleName = "PanelNotifColor";
            this.PanelNotifColor.BackColor = System.Drawing.Color.Red;
            this.PanelNotifColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelNotifColor.FillColor = System.Drawing.Color.Red;
            this.PanelNotifColor.Location = new System.Drawing.Point(0, 0);
            this.PanelNotifColor.Name = "PanelNotifColor";
            this.PanelNotifColor.Size = new System.Drawing.Size(5, 70);
            this.PanelNotifColor.TabIndex = 6;
            this.PanelNotifColor.Click += new System.EventHandler(this.NotifBox_Click);
            this.PanelNotifColor.MouseEnter += new System.EventHandler(this.NotifBox_MouseHover);
            this.PanelNotifColor.MouseLeave += new System.EventHandler(this.NotifBox_MouseLeave);
            this.PanelNotifColor.MouseHover += new System.EventHandler(this.NotifBox_MouseHover);
            // 
            // Notification
            // 
            this.AccessibleName = "Notification";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::ChromaSelect.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(251, 70);
            this.Controls.Add(this.PanelNotifColor);
            this.Controls.Add(this.NotifBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::ChromaSelect.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notification";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.NotifBox_Click);
            this.MouseEnter += new System.EventHandler(this.NotifBox_MouseHover);
            this.MouseLeave += new System.EventHandler(this.NotifBox_MouseLeave);
            this.MouseHover += new System.EventHandler(this.NotifBox_MouseHover);
            this.NotifBox.ResumeLayout(false);
            this.NotifBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGCTIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel NotifBox;
        private System.Windows.Forms.Label TxtNotif;
        private System.Windows.Forms.PictureBox ImgGCTIcon;
        private Guna.UI2.WinForms.Guna2Panel PanelNotifColor;
    }
}