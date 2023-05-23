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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            Banking_dbEntities1 dbe = new Banking_dbEntities1();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            nametxt.Text = item.Name;
            amounttxt.Text = Convert.ToString(item.balance);
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            Banking_dbEntities1 dbe = new Banking_dbEntities1();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();

            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbal = Convert.ToDecimal(transfertxt.Text);
            decimal transferacc = Convert.ToDecimal(desaccounttxt.Text);
            if (b1>=totalbal)
            {
                userAccount item2 = (from u in dbe.userAccounts
                                     where u.Account_No == transferacc
                                     select u).FirstOrDefault();

                item2.balance = item2.balance + totalbal;
                item.balance = item.balance - totalbal;
                //dbe.SaveChanges();
                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(fromacctxt.Text);
                transfer.ToTransfer = Convert.ToDecimal(desaccounttxt.Text);
                transfer.Date = DateTime.Now.ToString();
                transfer.Name = nametxt.Text;
                transfer.balance = Convert.ToDecimal(transfertxt.Text);

                dbe.Transfers.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Transfer money successflly");
            }
        }
    }
}
