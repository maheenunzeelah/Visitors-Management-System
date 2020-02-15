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
    public partial class vms : Form
    {
        public vms()
        {
            InitializeComponent();
        }

        private void visitorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.visitorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void vms_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;

            // TODO: This line of code loads data into the 'dataSet1.VisitorView' table. You can move, or remove it, as needed.
            this.visitorViewTableAdapter.Fill(this.dataSet1.VisitorView);
            // TODO: This line of code loads data into the 'dataSet11.Center' table. You can move, or remove it, as needed.
            this.centerTableAdapter.Fill(this.dataSet11.Center);
            // TODO: This line of code loads data into the 'dataSet1.Visitors' table. You can move, or remove it, as needed.
            this.visitorsTableAdapter.Fill(this.dataSet1.Visitors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitorsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visitorsBindingSource.EndEdit();
            visitorsTableAdapter.Update(dataSet1.Visitors);
            dataSet1.Visitors.AcceptChanges();
            MessageBox.Show("Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visitorsBindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visitorsBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            visitorsBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            visitorsBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            label1.Text = dataSet1.VisitorView.Rows.Count.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void visitor_IdLabel1_Click(object sender, EventArgs e)
        {

        }

        private void visitor_IdLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void visitor_IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.visitorViewTableAdapter.FillByCenterName(this.dataSet1.VisitorView,"%"+ textBox1.Text+"%");
            label1.Text = dataSet1.VisitorView.Rows.Count.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.visitorsTableAdapter.FillById(this.dataSet1.Visitors,int.Parse(visitor_IdLabel1.Text));
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            visitorsBindingSource.RemoveCurrent();
            visitorsBindingSource.EndEdit();
            visitorsTableAdapter.Update(dataSet1.Visitors);
            dataSet1.Visitors.AcceptChanges();
            MessageBox.Show("Record Deleted");
        }

        private void visitorsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void visitorViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
