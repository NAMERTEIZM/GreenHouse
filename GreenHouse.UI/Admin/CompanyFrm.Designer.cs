namespace GreenHouse.UI.Admin
{
    partial class CompanyFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyFrm));
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.chkAktifMi = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSil = new Guna.UI2.WinForms.Guna2Button();
			this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
			this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
			this.txtAdres = new Guna.UI2.WinForms.Guna2TextBox();
			this.lstUreticiler = new System.Windows.Forms.ListBox();
			this.txtUreticiAdi = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtTelefonNumarasi = new Guna.UI2.WinForms.Guna2TextBox();
			this.SuspendLayout();
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Location = new System.Drawing.Point(195, 49);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(574, 10);
			this.guna2Separator1.TabIndex = 59;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(347, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(299, 37);
			this.label1.TabIndex = 58;
			this.label1.Text = "Üretici Ekleme Sayfası";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(395, 259);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 17);
			this.label7.TabIndex = 57;
			this.label7.Text = "Aktif mi?";
			// 
			// chkAktifMi
			// 
			this.chkAktifMi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.chkAktifMi.CheckedState.BorderRadius = 2;
			this.chkAktifMi.CheckedState.BorderThickness = 0;
			this.chkAktifMi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.chkAktifMi.Location = new System.Drawing.Point(373, 259);
			this.chkAktifMi.Name = "chkAktifMi";
			this.chkAktifMi.Size = new System.Drawing.Size(17, 17);
			this.chkAktifMi.TabIndex = 56;
			this.chkAktifMi.Text = "guna2CustomCheckBox1";
			this.chkAktifMi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.chkAktifMi.UncheckedState.BorderRadius = 2;
			this.chkAktifMi.UncheckedState.BorderThickness = 0;
			this.chkAktifMi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(235, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 20);
			this.label5.TabIndex = 55;
			this.label5.Text = "Adres:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(235, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 20);
			this.label4.TabIndex = 54;
			this.label4.Text = "Telefon Numarası:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(235, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 20);
			this.label2.TabIndex = 53;
			this.label2.Text = "Üretici Adı:";
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.Transparent;
			this.btnSil.BorderRadius = 4;
			this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSil.FillColor = System.Drawing.Color.DarkRed;
			this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSil.ForeColor = System.Drawing.Color.White;
			this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
			this.btnSil.Location = new System.Drawing.Point(564, 297);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(65, 36);
			this.btnSil.TabIndex = 52;
			this.btnSil.Text = "Sil";
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BorderRadius = 4;
			this.btnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnGuncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnGuncelle.ForeColor = System.Drawing.Color.White;
			this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
			this.btnGuncelle.Location = new System.Drawing.Point(468, 297);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(90, 36);
			this.btnGuncelle.TabIndex = 51;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.BorderRadius = 4;
			this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEkle.FillColor = System.Drawing.Color.Green;
			this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnEkle.ForeColor = System.Drawing.Color.White;
			this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
			this.btnEkle.Location = new System.Drawing.Point(372, 297);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(90, 36);
			this.btnEkle.TabIndex = 50;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtAdres
			// 
			this.txtAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAdres.DefaultText = "";
			this.txtAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtAdres.Location = new System.Drawing.Point(373, 167);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.PasswordChar = '\0';
			this.txtAdres.PlaceholderText = "Adres";
			this.txtAdres.SelectedText = "";
			this.txtAdres.Size = new System.Drawing.Size(257, 76);
			this.txtAdres.TabIndex = 49;
			// 
			// lstUreticiler
			// 
			this.lstUreticiler.Dock = System.Windows.Forms.DockStyle.Left;
			this.lstUreticiler.FormattingEnabled = true;
			this.lstUreticiler.Location = new System.Drawing.Point(0, 0);
			this.lstUreticiler.Name = "lstUreticiler";
			this.lstUreticiler.Size = new System.Drawing.Size(160, 480);
			this.lstUreticiler.TabIndex = 48;
			this.lstUreticiler.SelectedIndexChanged += new System.EventHandler(this.lstUreticiler_SelectedIndexChanged);
			// 
			// txtUreticiAdi
			// 
			this.txtUreticiAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUreticiAdi.DefaultText = "";
			this.txtUreticiAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtUreticiAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtUreticiAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUreticiAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtUreticiAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUreticiAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtUreticiAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtUreticiAdi.Location = new System.Drawing.Point(373, 79);
			this.txtUreticiAdi.Name = "txtUreticiAdi";
			this.txtUreticiAdi.PasswordChar = '\0';
			this.txtUreticiAdi.PlaceholderText = "Üretici Adı";
			this.txtUreticiAdi.SelectedText = "";
			this.txtUreticiAdi.Size = new System.Drawing.Size(257, 36);
			this.txtUreticiAdi.TabIndex = 46;
			// 
			// txtTelefonNumarasi
			// 
			this.txtTelefonNumarasi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTelefonNumarasi.DefaultText = "";
			this.txtTelefonNumarasi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTelefonNumarasi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTelefonNumarasi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTelefonNumarasi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTelefonNumarasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTelefonNumarasi.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTelefonNumarasi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTelefonNumarasi.Location = new System.Drawing.Point(373, 122);
			this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
			this.txtTelefonNumarasi.PasswordChar = '\0';
			this.txtTelefonNumarasi.PlaceholderText = "Telefon Numarası";
			this.txtTelefonNumarasi.SelectedText = "";
			this.txtTelefonNumarasi.Size = new System.Drawing.Size(257, 36);
			this.txtTelefonNumarasi.TabIndex = 60;
			// 
			// CompanyFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 480);
			this.Controls.Add(this.txtTelefonNumarasi);
			this.Controls.Add(this.guna2Separator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chkAktifMi);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.lstUreticiler);
			this.Controls.Add(this.txtUreticiAdi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CompanyFrm";
			this.Text = "CompanyFrm";
			this.Load += new System.EventHandler(this.CompanyFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkAktifMi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2TextBox txtAdres;
        private System.Windows.Forms.ListBox lstUreticiler;
        private Guna.UI2.WinForms.Guna2TextBox txtUreticiAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefonNumarasi;
    }
}