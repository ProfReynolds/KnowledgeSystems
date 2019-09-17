using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge.MLNET.Demonstrator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void BtnDigits_Click(object sender, EventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
                mdiChild.Close();

            var newChild = new Digits.Demo
            {
                MdiParent = this,
            };
            newChild.Show();
            newChild.ControlBox = false;
            Application.DoEvents();
            newChild.WindowState = FormWindowState.Maximized;
        }

        private void BtnCharaters_Click(object sender, EventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
                mdiChild.Close();

            var newChild = new Characters.Demo
            {
                MdiParent = this,
            };
            newChild.Show();
            newChild.ControlBox = false;
            Application.DoEvents();
            newChild.WindowState = FormWindowState.Maximized;
        }

        private void BtnHousing_Click(object sender, EventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
                mdiChild.Close();

            var newChild = new Housing.Demo
            {
                MdiParent = this,
            };
            newChild.Show();
            newChild.ControlBox = false;
            Application.DoEvents();
            newChild.WindowState = FormWindowState.Maximized;
        }
    }
}
