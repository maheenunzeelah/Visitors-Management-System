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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.User' table. You can move, or remove it, as needed.
           // this.userTableAdapter.Fill(this.dataSet1.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.userTableAdapter.FillByUserId(this.dataSet1.User, user_NameTextBox.Text, user_PassTextBox.Text);
            int noofrec = 0;
            noofrec = dataSet1.User.Rows.Count;
            if (noofrec > 0)
            {
                MainMenu f1 = new MainMenu();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }

        }

        private void user_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
