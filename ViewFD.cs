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
    public partial class ViewFD : Form
    {
        BindingList<FD> bl;
        Banking_dbEntities1 dbe;
        public ViewFD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl = new BindingList<FD>();
            dbe = new Banking_dbEntities1();
            string date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            MessageBox.Show(date);
            var item = dbe.FDs.Where(a => a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList(); 
        }
    }
}
