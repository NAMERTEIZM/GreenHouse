namespace GreenHouse.UI.Admin
{
    partial class ProductApproveFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductApproveFrm));
            this.lwUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.cmbFiltre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAramaMetni = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lwUrunler
            // 
            this.lwUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwUrunler.FullRowSelect = true;
            this.lwUrunler.HideSelection = false;
            this.lwUrunler.Location = new System.Drawing.Point(12, 75);
            this.lwUrunler.MultiSelect = false;
            this.lwUrunler.Name = "lwUrunler";
            this.lwUrunler.Size = new System.Drawing.Size(761, 309);
            this.lwUrunler.TabIndex = 37;
            this.lwUrunler.UseCompatibleStateImageBehavior = false;
            this.lwUrunler.View = System.Windows.Forms.View.Details;
            this.lwUrunler.SelectedIndexChanged += new System.EventHandler(this.lwUrunler_SelectedIndexChanged);
            this.lwUrunler.DoubleClick += new System.EventHandler(this.lwUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Barkod Numarası";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Onay Durumu";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gönderen Kullanıcı";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Olusturulma Tarihi";
            this.columnHeader5.Width = 150;
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
            this.btnEkle.Location = new System.Drawing.Point(683, 421);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 36);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "Onayla";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.BackColor = System.Drawing.Color.Transparent;
            this.cmbFiltre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFiltre.ItemHeight = 30;
            this.cmbFiltre.Location = new System.Drawing.Point(100, 22);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(193, 36);
            this.cmbFiltre.TabIndex = 39;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Filtre Türü:";
            // 
            // txtAramaMetni
            // 
            this.txtAramaMetni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAramaMetni.DefaultText = "";
            this.txtAramaMetni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAramaMetni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAramaMetni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAramaMetni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAramaMetni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAramaMetni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAramaMetni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAramaMetni.Location = new System.Drawing.Point(323, 22);
            this.txtAramaMetni.Name = "txtAramaMetni";
            this.txtAramaMetni.PasswordChar = '\0';
            this.txtAramaMetni.PlaceholderText = "Arama Metni Giriniz";
            this.txtAramaMetni.SelectedText = "";
            this.txtAramaMetni.Size = new System.Drawing.Size(450, 36);
            this.txtAramaMetni.TabIndex = 41;
            this.txtAramaMetni.TextChanged += new System.EventHandler(this.txtAramaMetni_TextChanged);
            // 
            // ProductApproveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 480);
            this.Controls.Add(this.txtAramaMetni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lwUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductApproveFrm";
            this.Text = "ProductApproveFrm";
            this.Load += new System.EventHandler(this.ProductApproveFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltre;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtAramaMetni;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}