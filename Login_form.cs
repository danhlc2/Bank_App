using Banking_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Application
{
    public partial class Login_form : Form
    {
        private BankingDanhLC2Context dbContext;

        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usrtxt.Text != string.Empty || passtxt.Text != string.Empty)
            {
                var user1 = dbContext.UserTable.FirstOrDefault(user => user.UserName == usrtxt.Text);
                if (user1 != null)
                {
                    AesManaged aes = new AesManaged();
                    aes.Key = Convert.FromBase64String("AAECAwQFBgcICQoLDA0ODw==");
                    aes.IV = Convert.FromBase64String("AAECAwQFBgcICQoLDA0ODw==");
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    MemoryStream memoryStream = new MemoryStream();

                    using (CryptoStream cs = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(passtxt.Text);
                        var encrypted = memoryStream.ToArray();
                        var encryptedPass = Convert.ToBase64String(encrypted);

                        if (user1.Password.Equals(encryptedPass))
                        {
                            Menu m1 = new Menu();
                            m1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Password incorrect");
                        }
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new BankingDanhLC2Context();

            this.dbContext.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }
    }
}
