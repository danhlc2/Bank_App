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
    public partial class CreditForm : Form
    {
        public CreditForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Chque");

        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");

        }

        private void CreditForm_Load(object sender, EventArgs e)
        {

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Banking_dbEntities1 context = new Banking_dbEntities1();
            newAccount acc = new newAccount();
            Deposit dp = new Deposit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DipAmount = Convert.ToDecimal(amounttxt.Text);
            context.Deposits.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b 
                        select u).FirstOrDefault();

            item.balance = item.balance + Convert.ToDecimal(amounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("Deposit Money Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banking_dbEntities1 context = new Banking_dbEntities1();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.balance);
        }
    }
}
