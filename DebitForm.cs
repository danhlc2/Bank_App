﻿using System;
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
    public partial class DebitForm : Form
    {
        public DebitForm()
        {
            InitializeComponent();
            loaddate();
            loadcombo();
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void loadcombo()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Chque");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retrievedata();

        }

        private void savedata()
        {
            Banking_dbEntities1 dbe = new Banking_dbEntities1();
            newAccount nacc = new newAccount();
            debit dp = new debit();
            dp.Date = datelbl.Text;
            dp.AccountNo = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(amounttxt.Text);
            dbe.debits.Add(dp);
            dbe.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            item.balance = item.balance - Convert.ToDecimal(amounttxt.Text);
            dbe.SaveChanges();
            MessageBox.Show("Debit Money");
        }

        private void DebitForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {          
            savedata();

        }

        private void retrievedata()
        {
            Banking_dbEntities1 dbe = new Banking_dbEntities1();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.balance);
        }
    }
}
