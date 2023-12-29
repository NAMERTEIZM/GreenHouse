namespace GreenHouse.UI.Admin
{
    partial class ProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFrm));
            this.txtUrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtBarkod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAciklama = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowBilesenler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAktifMi = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBilesenEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.flowResimler = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.flowUreticiler = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUreticiler = new System.Windows.Forms.Label();
            this.btnUreticiEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnResimEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.flowUreticiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunAdi.DefaultText = "";
            this.txtUrunAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAdi.Location = new System.Drawing.Point(314, 72);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.PlaceholderText = "Ürün Adı";
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.Size = new System.Drawing.Size(211, 36);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // cmbKategori
            // 
            this.cmbKategori.BackColor = System.Drawing.Color.Transparent;
            this.cmbKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbKategori.ItemHeight = 30;
            this.cmbKategori.Location = new System.Drawing.Point(314, 156);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(211, 36);
            this.cmbKategori.TabIndex = 2;
            // 
            // lstUrunler
            // 
            this.lstUrunler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(0, 0);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(160, 480);
            this.lstUrunler.TabIndex = 5;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarkod.DefaultText = "";
            this.txtBarkod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarkod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarkod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarkod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarkod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarkod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBarkod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarkod.Location = new System.Drawing.Point(314, 114);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.PasswordChar = '\0';
            this.txtBarkod.PlaceholderText = "Barkod";
            this.txtBarkod.SelectedText = "";
            this.txtBarkod.Size = new System.Drawing.Size(211, 36);
            this.txtBarkod.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAciklama.DefaultText = "";
            this.txtAciklama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAciklama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAciklama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAciklama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAciklama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAciklama.Location = new System.Drawing.Point(314, 198);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.PlaceholderText = "Açıklama";
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.Size = new System.Drawing.Size(211, 76);
            this.txtAciklama.TabIndex = 7;
            // 
            // flowBilesenler
            // 
            this.flowBilesenler.Location = new System.Drawing.Point(314, 290);
            this.flowBilesenler.Name = "flowBilesenler";
            this.flowBilesenler.Size = new System.Drawing.Size(211, 110);
            this.flowBilesenler.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(176, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(176, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Barkod No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(176, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(176, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(176, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Bileşenler:";
            // 
            // chkAktifMi
            // 
            this.chkAktifMi.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAktifMi.CheckedState.BorderRadius = 2;
            this.chkAktifMi.CheckedState.BorderThickness = 0;
            this.chkAktifMi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAktifMi.Location = new System.Drawing.Point(180, 383);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(17, 17);
            this.chkAktifMi.TabIndex = 23;
            this.chkAktifMi.Text = "guna2CustomCheckBox1";
            this.chkAktifMi.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAktifMi.UncheckedState.BorderRadius = 2;
            this.chkAktifMi.UncheckedState.BorderThickness = 0;
            this.chkAktifMi.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(202, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Aktif mi?";
            // 
            // btnBilesenEkle
            // 
            this.btnBilesenEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBilesenEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBilesenEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBilesenEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBilesenEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBilesenEkle.ForeColor = System.Drawing.Color.White;
            this.btnBilesenEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnBilesenEkle.Image")));
            this.btnBilesenEkle.Location = new System.Drawing.Point(279, 290);
            this.btnBilesenEkle.Name = "btnBilesenEkle";
            this.btnBilesenEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBilesenEkle.Size = new System.Drawing.Size(30, 30);
            this.btnBilesenEkle.TabIndex = 17;
            this.btnBilesenEkle.Click += new System.EventHandler(this.guna2CircleButton1_Click);
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
            this.btnSil.Location = new System.Drawing.Point(560, 418);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 36);
            this.btnSil.TabIndex = 12;
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
            this.btnGuncelle.Location = new System.Drawing.Point(435, 418);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 36);
            this.btnGuncelle.TabIndex = 11;
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
            this.btnEkle.Location = new System.Drawing.Point(314, 418);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 36);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Ekleme Sayfası";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(183, 49);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(574, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(583, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Resimler:";
            // 
            // flowResimler
            // 
            this.flowResimler.Location = new System.Drawing.Point(554, 115);
            this.flowResimler.Name = "flowResimler";
            this.flowResimler.Size = new System.Drawing.Size(203, 104);
            this.flowResimler.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(581, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Üreticiler:";
            // 
            // flowUreticiler
            // 
            this.flowUreticiler.Controls.Add(this.lblUreticiler);
            this.flowUreticiler.Location = new System.Drawing.Point(554, 290);
            this.flowUreticiler.Name = "flowUreticiler";
            this.flowUreticiler.Size = new System.Drawing.Size(203, 110);
            this.flowUreticiler.TabIndex = 28;
            // 
            // lblUreticiler
            // 
            this.lblUreticiler.AutoSize = true;
            this.lblUreticiler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiler.Location = new System.Drawing.Point(3, 0);
            this.lblUreticiler.Name = "lblUreticiler";
            this.lblUreticiler.Size = new System.Drawing.Size(0, 20);
            this.lblUreticiler.TabIndex = 0;
            // 
            // btnUreticiEkle
            // 
            this.btnUreticiEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUreticiEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUreticiEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUreticiEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUreticiEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUreticiEkle.ForeColor = System.Drawing.Color.White;
            this.btnUreticiEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUreticiEkle.Image")));
            this.btnUreticiEkle.Location = new System.Drawing.Point(552, 249);
            this.btnUreticiEkle.Name = "btnUreticiEkle";
            this.btnUreticiEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUreticiEkle.Size = new System.Drawing.Size(30, 30);
            this.btnUreticiEkle.TabIndex = 29;
            this.btnUreticiEkle.Click += new System.EventHandler(this.btnUreticiEkle_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResimEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResimEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResimEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResimEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResimEkle.ForeColor = System.Drawing.Color.White;
            this.btnResimEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnResimEkle.Image")));
            this.btnResimEkle.Location = new System.Drawing.Point(552, 64);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnResimEkle.Size = new System.Drawing.Size(30, 30);
            this.btnResimEkle.TabIndex = 30;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(584, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "2 adet resim seçiniz.";
            // 
            // ProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 480);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnUreticiEkle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flowUreticiler);
            this.Controls.Add(this.flowResimler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBilesenEkle);
            this.Controls.Add(this.flowBilesenler);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductFrm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.flowUreticiler.ResumeLayout(false);
            this.flowUreticiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtUrunAdi;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKategori;
        private System.Windows.Forms.ListBox lstUrunler;
        private Guna.UI2.WinForms.Guna2TextBox txtBarkod;
        private Guna.UI2.WinForms.Guna2TextBox txtAciklama;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private System.Windows.Forms.FlowLayoutPanel flowBilesenler;
        private Guna.UI2.WinForms.Guna2CircleButton btnBilesenEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkAktifMi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowResimler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowUreticiler;
        private System.Windows.Forms.Label lblUreticiler;
        private Guna.UI2.WinForms.Guna2CircleButton btnUreticiEkle;
        private Guna.UI2.WinForms.Guna2CircleButton btnResimEkle;
        private System.Windows.Forms.Label label11;
    }
}