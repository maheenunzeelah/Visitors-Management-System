using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.ReportSource;

using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;


namespace loginForm
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        
            CrystalReport3 rep = new CrystalReport3();
            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.VisitorViewTableAdapter vis = new DataSet1TableAdapters.VisitorViewTableAdapter();
            DataSet1.VisitorViewDataTable tab = vis.GetData();
            vis.Fill(ds.VisitorView);
            rep.SetDataSource(tab.DefaultView);
            crystalReportViewer1.ReportSource = rep;
            crystalReportViewer1.Refresh();
        }
    }
}
