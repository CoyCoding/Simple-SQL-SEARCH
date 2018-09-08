using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDemo
{
    public partial class SQLDemoUI : Form
    {

        List<Customer> customer = new List<Customer>();

        public SQLDemoUI()
        {
            InitializeComponent();

            UpdateList();

        }

 

        private void SearchLastNameBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            customer = db.GetCustomers(LastNameTextBox.Text);

            UpdateList();

        }

        private void UpdateList()
        {
            CustomerListBox.DataSource = customer;
            CustomerListBox.DisplayMember = "FullInfo";
        }
    }
}
