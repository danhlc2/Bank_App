using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Application
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            bindgrid();
        }
        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            Banking_dbEntities1 bs = new Banking_dbEntities1();
            var item = bs.userAccounts.ToList();
            dataGridView1.DataSource= item;
        }

    }
}
