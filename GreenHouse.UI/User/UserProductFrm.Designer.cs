namespace GreenHouse.UI.User
{
    partial class UserProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProductFrm));
            this.label9 = new System.Windows.Forms.Label();
            this.flowUreticiler = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUreticiler = new System.Windows.Forms.Label();
            this.flowResimler = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkGozukmeDurumu = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowBilesenler = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBarkod = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtUrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResimEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnUreticiEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnBilesenEkle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnGonder = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.flowUreticiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(501, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Üreticiler:";
            // 
            // flowUreticiler
            // 
            this.flowUreticiler.Controls.Add(this.lblUreticiler);
            this.flowUreticiler.Location = new System.Drawing.Point(474, 298);
            this.flowUreticiler.Name = "flowUreticiler";
            this.flowUreticiler.Size = new System.Drawing.Size(203, 110);
            this.flowUreticiler.TabIndex = 52;
            // 
            // lblUreticiler
            // 
            this.lblUreticiler.AutoSize = true;
            this.lblUreticiler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUreticiler.Location = new System.Drawing.Point(3, 0);
            this.lblUreticiler.Name = "lblUreticiler";
            this.lblUreticiler.Size = new System.Drawing.Size(12, 20);
            this.lblUreticiler.TabIndex = 0;
            this.lblUreticiler.Text = ".";
            // 
            // flowResimler
            // 
            this.flowResimler.Location = new System.Drawing.Point(474, 121);
            this.flowResimler.Name = "flowResimler";
            this.flowResimler.Size = new System.Drawing.Size(203, 104);
            this.flowResimler.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(503, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Resimler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(257, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 34);
            this.label7.TabIndex = 49;
            this.label7.Text = "Gönderdiğim ürünün sayfasında kullanıcı \r\nadımın görüntülenmesini onaylıyorum.";
            // 
            // chkGozukmeDurumu
            // 
            this.chkGozukmeDurumu.Checked = true;
            this.chkGozukmeDurumu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGozukmeDurumu.CheckedState.BorderRadius = 2;
            this.chkGozukmeDurumu.CheckedState.BorderThickness = 0;
            this.chkGozukmeDurumu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGozukmeDurumu.Location = new System.Drawing.Point(234, 429);
            this.chkGozukmeDurumu.Name = "chkGozukmeDurumu";
            this.chkGozukmeDurumu.Size = new System.Drawing.Size(17, 17);
            this.chkGozukmeDurumu.TabIndex = 48;
            this.chkGozukmeDurumu.Text = "guna2CustomCheckBox1";
            this.chkGozukmeDurumu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkGozukmeDurumu.UncheckedState.BorderRadius = 2;
            this.chkGozukmeDurumu.UncheckedState.BorderThickness = 0;
            this.chkGozukmeDurumu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(96, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Bileşenler:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(96, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(96, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ürün Adı:";
            // 
            // flowBilesenler
            // 
            this.flowBilesenler.Location = new System.Drawing.Point(234, 298);
            this.flowBilesenler.Name = "flowBilesenler";
            this.flowBilesenler.Size = new System.Drawing.Size(211, 110);
            this.flowBilesenler.TabIndex = 41;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(42, 57);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(688, 10);
            this.guna2Separator1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(339, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ürün Ekle";
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
            this.txtAciklama.Location = new System.Drawing.Point(234, 206);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.PlaceholderText = "Açıklama";
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.Size = new System.Drawing.Size(211, 76);
            this.txtAciklama.TabIndex = 35;
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
            this.txtBarkod.Location = new System.Drawing.Point(234, 76);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.PasswordChar = '\0';
            this.txtBarkod.PlaceholderText = "Barkod";
            this.txtBarkod.SelectedText = "";
            this.txtBarkod.Size = new System.Drawing.Size(211, 36);
            this.txtBarkod.TabIndex = 34;
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
            this.cmbKategori.Location = new System.Drawing.Point(234, 164);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(211, 36);
            this.cmbKategori.TabIndex = 33;
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
            this.txtUrunAdi.Location = new System.Drawing.Point(234, 121);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.PasswordChar = '\0';
            this.txtUrunAdi.PlaceholderText = "Ürün Adı";
            this.txtUrunAdi.SelectedText = "";
            this.txtUrunAdi.Size = new System.Drawing.Size(211, 36);
            this.txtUrunAdi.TabIndex = 32;
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
            this.btnResimEkle.Location = new System.Drawing.Point(472, 72);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnResimEkle.Size = new System.Drawing.Size(30, 30);
            this.btnResimEkle.TabIndex = 55;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
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
            this.btnUreticiEkle.Location = new System.Drawing.Point(472, 257);
            this.btnUreticiEkle.Name = "btnUreticiEkle";
            this.btnUreticiEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUreticiEkle.Size = new System.Drawing.Size(30, 30);
            this.btnUreticiEkle.TabIndex = 54;
            this.btnUreticiEkle.Click += new System.EventHandler(this.btnUreticiEkle_Click);
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
            this.btnBilesenEkle.Location = new System.Drawing.Point(199, 298);
            this.btnBilesenEkle.Name = "btnBilesenEkle";
            this.btnBilesenEkle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBilesenEkle.Size = new System.Drawing.Size(30, 30);
            this.btnBilesenEkle.TabIndex = 42;
            this.btnBilesenEkle.Click += new System.EventHandler(this.btnBilesenEkle_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.BorderRadius = 4;
            this.btnGonder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGonder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGonder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGonder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGonder.FillColor = System.Drawing.Color.Green;
            this.btnGonder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Image = ((System.Drawing.Image)(resources.GetObject("btnGonder.Image")));
            this.btnGonder.Location = new System.Drawing.Point(547, 427);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(130, 36);
            this.btnGonder.TabIndex = 36;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(503, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "2 adet resim seçiniz.";
            // 
            // UserProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 480);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.btnUreticiEkle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.flowUreticiler);
            this.Controls.Add(this.flowResimler);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkGozukmeDurumu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBilesenEkle);
            this.Controls.Add(this.flowBilesenler);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProductFrm";
            this.Text = "UserProductFrm";
            this.Load += new System.EventHandler(this.UserProductFrm_Load);
            this.flowUreticiler.ResumeLayout(false);
            this.flowUreticiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnResimEkle;
        private Guna.UI2.WinForms.Guna2CircleButton btnUreticiEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowUreticiler;
        private System.Windows.Forms.Label lblUreticiler;
        private System.Windows.Forms.FlowLayoutPanel flowResimler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkGozukmeDurumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnBilesenEkle;
        private System.Windows.Forms.FlowLayoutPanel flowBilesenler;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGonder;
        private Guna.UI2.WinForms.Guna2TextBox txtAciklama;
        private Guna.UI2.WinForms.Guna2TextBox txtBarkod;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKategori;
        private Guna.UI2.WinForms.Guna2TextBox txtUrunAdi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
    }
}