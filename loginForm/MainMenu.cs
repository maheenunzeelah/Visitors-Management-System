using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void visitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vms f2 = new vms();
            f2.MdiParent = this;
            f2.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ReportForm rpt = new ReportForm();
            rpt.MdiParent=this;
            rpt.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
