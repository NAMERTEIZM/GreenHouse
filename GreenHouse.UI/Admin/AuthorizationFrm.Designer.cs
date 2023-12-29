namespace GreenHouse.UI.Admin
{
    partial class AuthorizationFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationFrm));
			this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.chkAktifMi = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstYetkiler = new System.Windows.Forms.ListBox();
			this.txtYetkiAdi = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnSil = new Guna.UI2.WinForms.Guna2Button();
			this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
			this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// guna2Separator1
			// 
			this.guna2Separator1.Location = new System.Drawing.Point(207, 49);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new System.Drawing.Size(574, 10);
			this.guna2Separator1.TabIndex = 83;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(370, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 37);
			this.label1.TabIndex = 82;
			this.label1.Text = "Yetki Ekleme Sayfası";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(407, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 17);
			this.label7.TabIndex = 81;
			this.label7.Text = "Aktif mi?";
			// 
			// chkAktifMi
			// 
			this.chkAktifMi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.chkAktifMi.CheckedState.BorderRadius = 2;
			this.chkAktifMi.CheckedState.BorderThickness = 0;
			this.chkAktifMi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.chkAktifMi.Location = new System.Drawing.Point(385, 126);
			this.chkAktifMi.Name = "chkAktifMi";
			this.chkAktifMi.Size = new System.Drawing.Size(17, 17);
			this.chkAktifMi.TabIndex = 80;
			this.chkAktifMi.Text = "guna2CustomCheckBox1";
			this.chkAktifMi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.chkAktifMi.UncheckedState.BorderRadius = 2;
			this.chkAktifMi.UncheckedState.BorderThickness = 0;
			this.chkAktifMi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(247, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 79;
			this.label2.Text = "Yetki Adı:";
			// 
			// lstYetkiler
			// 
			this.lstYetkiler.Dock = System.Windows.Forms.DockStyle.Left;
			this.lstYetkiler.FormattingEnabled = true;
			this.lstYetkiler.Location = new System.Drawing.Point(0, 0);
			this.lstYetkiler.Name = "lstYetkiler";
			this.lstYetkiler.Size = new System.Drawing.Size(160, 480);
			this.lstYetkiler.TabIndex = 75;
			this.lstYetkiler.SelectedIndexChanged += new System.EventHandler(this.lstYetkiler_SelectedIndexChanged);
			// 
			// txtYetkiAdi
			// 
			this.txtYetkiAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtYetkiAdi.DefaultText = "";
			this.txtYetkiAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtYetkiAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtYetkiAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtYetkiAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtYetkiAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtYetkiAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtYetkiAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtYetkiAdi.Location = new System.Drawing.Point(385, 79);
			this.txtYetkiAdi.Name = "txtYetkiAdi";
			this.txtYetkiAdi.PasswordChar = '\0';
			this.txtYetkiAdi.PlaceholderText = "Yetki Adı";
			this.txtYetkiAdi.SelectedText = "";
			this.txtYetkiAdi.Size = new System.Drawing.Size(257, 36);
			this.txtYetkiAdi.TabIndex = 74;
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
			this.btnSil.Location = new System.Drawing.Point(576, 164);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(65, 36);
			this.btnSil.TabIndex = 78;
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
			this.btnGuncelle.Location = new System.Drawing.Point(480, 164);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(90, 36);
			this.btnGuncelle.TabIndex = 77;
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
			this.btnEkle.Location = new System.Drawing.Point(384, 164);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(90, 36);
			this.btnEkle.TabIndex = 76;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// AuthorizationFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 480);
			this.Controls.Add(this.guna2Separator1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chkAktifMi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.lstYetkiler);
			this.Controls.Add(this.txtYetkiAdi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AuthorizationFrm";
			this.Text = "AuthorizationFrm";
			this.Load += new System.EventHandler(this.AuthorizationFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkAktifMi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private System.Windows.Forms.ListBox lstYetkiler;
        private Guna.UI2.WinForms.Guna2TextBox txtYetkiAdi;
    }
}