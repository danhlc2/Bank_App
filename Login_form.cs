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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking_dbEntities1 dbe = new Banking_dbEntities1();
            if (usrtxt.Text!=string.Empty || passtxt.Text!=string.Empty )
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if(user1!=null)
                {
                    if(user1.Password.Equals(passtxt.Text)) 
                    {
                        Menu m1= new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect");
                    }

                }
                else
                {
                    MessageBox.Show("Null value");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password!");
            }
        }
    }
}
