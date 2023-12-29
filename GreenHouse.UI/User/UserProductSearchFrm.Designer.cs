
namespace GreenHouse.UI.User
{
    partial class UserProductSearchFrm
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
            this.txtUrunAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lwUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbKategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrunAra.DefaultText = "";
            this.txtUrunAra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUrunAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUrunAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUrunAra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUrunAra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUrunAra.Location = new System.Drawing.Point(12, 12);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.PasswordChar = '\0';
            this.txtUrunAra.PlaceholderText = "Ürün Ara... (Barkod Numarası ve Ürün Adı)";
            this.txtUrunAra.SelectedText = "";
            this.txtUrunAra.Size = new System.Drawing.Size(505, 36);
            this.txtUrunAra.TabIndex = 35;
            this.txtUrunAra.TextChanged += new System.EventHandler(this.txtUrunAra_TextChanged);
            // 
            // lwUrunler
            // 
            this.lwUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lwUrunler.FullRowSelect = true;
            this.lwUrunler.HideSelection = false;
            this.lwUrunler.Location = new System.Drawing.Point(12, 54);
            this.lwUrunler.MultiSelect = false;
            this.lwUrunler.Name = "lwUrunler";
            this.lwUrunler.Size = new System.Drawing.Size(761, 376);
            this.lwUrunler.TabIndex = 36;
            this.lwUrunler.UseCompatibleStateImageBehavior = false;
            this.lwUrunler.View = System.Windows.Forms.View.Details;
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
            this.cmbKategori.Location = new System.Drawing.Point(523, 12);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(250, 36);
            this.cmbKategori.TabIndex = 37;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 130;
            // 
            // UserProductSearchFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 480);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lwUrunler);
            this.Controls.Add(this.txtUrunAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProductSearchFrm";
            this.Text = "UserProductSearchFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUrunAra;
        private System.Windows.Forms.ListView lwUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKategori;
    }
}