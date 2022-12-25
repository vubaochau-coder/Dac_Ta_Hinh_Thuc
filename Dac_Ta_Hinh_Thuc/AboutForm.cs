using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dac_Ta_Hinh_Thuc
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            Color a = Color.Gainsboro;
            panel1.BackColor = Color.FromArgb(200, a);
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
