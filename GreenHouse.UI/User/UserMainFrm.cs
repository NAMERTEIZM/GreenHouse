using GreenHouse.UI.Admin;
using GreenHouse.VM.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI.User
{
    public partial class UserMainFrm : Form
    {
        public UserDetailVM _userDetailVM;
        public UserMainFrm()
        {
            InitializeComponent();
        }

        public UserMainFrm(UserDetailVM userDetailVM):this()
        {
            _userDetailVM = userDetailVM;
        }

        private void UserMainFrm_Load(object sender, EventArgs e)
        {
            this.Tag = _userDetailVM;
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfileFrm profil = new UserProfileFrm();
            if (Application.OpenForms["profil"] == null)
            {
                formgetir(profil);
            }
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProductFrm urun = new UserProductFrm();
            if (Application.OpenForms["urun"] == null)
            {
                formgetir(urun);
            }
        }

        private void formgetir(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void urunAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProductSearchFrm urunara = new UserProductSearchFrm();
            if (Application.OpenForms["urunara"] == null)
            {
                formgetir(urunara);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserLoginFrm userlogin = new UserLoginFrm();
            userlogin.Show();
            this.Close();
        }
    }
}
