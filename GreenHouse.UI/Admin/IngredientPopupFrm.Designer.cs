namespace GreenHouse.UI.Admin
{
    partial class IngredientPopupFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientPopupFrm));
            this.lstBilesenler = new System.Windows.Forms.CheckedListBox();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.txtBilesenAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAciklama = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbRiskTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnKaydet = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lstBilesenler
            // 
            this.lstBilesenler.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstBilesenler.FormattingEnabled = true;
            this.lstBilesenler.Location = new System.Drawing.Point(0, 0);
            this.lstBilesenler.Name = "lstBilesenler";
            this.lstBilesenler.Size = new System.Drawing.Size(131, 277);
            this.lstBilesenler.TabIndex = 0;
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
            this.btnEkle.Location = new System.Drawing.Point(153, 221);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(81, 35);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtBilesenAdi
            // 
            this.txtBilesenAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBilesenAdi.DefaultText = "";
            this.txtBilesenAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBilesenAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBilesenAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBilesenAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBilesenAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBilesenAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBilesenAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBilesenAdi.Location = new System.Drawing.Point(153, 49);
            this.txtBilesenAdi.Name = "txtBilesenAdi";
            this.txtBilesenAdi.PasswordChar = '\0';
            this.txtBilesenAdi.PlaceholderText = "Bileşen Adı";
            this.txtBilesenAdi.SelectedText = "";
            this.txtBilesenAdi.Size = new System.Drawing.Size(186, 36);
            this.txtBilesenAdi.TabIndex = 14;
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
            this.txtAciklama.Location = new System.Drawing.Point(153, 91);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.PlaceholderText = "Açıklama";
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.Size = new System.Drawing.Size(186, 66);
            this.txtAciklama.TabIndex = 16;
            // 
            // cmbRiskTuru
            // 
            this.cmbRiskTuru.BackColor = System.Drawing.Color.Transparent;
            this.cmbRiskTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRiskTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRiskTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRiskTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRiskTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRiskTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRiskTuru.ItemHeight = 30;
            this.cmbRiskTuru.Items.AddRange(new object[] {
            "Risk Türü"});
            this.cmbRiskTuru.Location = new System.Drawing.Point(153, 163);
            this.cmbRiskTuru.Name = "cmbRiskTuru";
            this.cmbRiskTuru.Size = new System.Drawing.Size(186, 36);
            this.cmbRiskTuru.StartIndex = 0;
            this.cmbRiskTuru.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bileşen Ekle";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(146, 33);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(202, 10);
            this.guna2Separator1.TabIndex = 19;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BorderRadius = 4;
            this.btnKaydet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaydet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaydet.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(258, 221);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(81, 35);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // IngredientPopupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 277);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRiskTuru);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBilesenAdi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstBilesenler);
            this.Name = "IngredientPopupFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngredientPopupFrm";
            this.Load += new System.EventHandler(this.IngredientPopupFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstBilesenler;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2TextBox txtBilesenAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtAciklama;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRiskTuru;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnKaydet;
    }
}