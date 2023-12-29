using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenHouse.UI
{
    public partial class InfoFrm : Form
    {
        private readonly string _message;

        public InfoFrm()
        {
            InitializeComponent();
        }

        public InfoFrm(string msg):this()
        {
            _message = msg;
        }

        private void InfoFrm_Load(object sender, EventArgs e)
        {
            lblMsg.Text = _message;
        }

    }
}
