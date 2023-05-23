namespace Banking_Application
{
    partial class TransferForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.desaccounttxt = new System.Windows.Forms.TextBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.fromacctxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transfertxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 41;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(376, 114);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(94, 20);
            this.DetailsButton.TabIndex = 40;
            this.DetailsButton.Text = "Show Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // desaccounttxt
            // 
            this.desaccounttxt.Location = new System.Drawing.Point(163, 253);
            this.desaccounttxt.Name = "desaccounttxt";
            this.desaccounttxt.Size = new System.Drawing.Size(180, 20);
            this.desaccounttxt.TabIndex = 38;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(164, 204);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(180, 20);
            this.amounttxt.TabIndex = 37;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(164, 160);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(180, 20);
            this.nametxt.TabIndex = 36;
            // 
            // fromacctxt
            // 
            this.fromacctxt.Location = new System.Drawing.Point(165, 114);
            this.fromacctxt.Name = "fromacctxt";
            this.fromacctxt.Size = new System.Drawing.Size(180, 20);
            this.fromacctxt.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Destination Account";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Current Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "From Account No.";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(196, 67);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 13);
            this.datelbl.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Current Date:";
            // 
            // transfertxt
            // 
            this.transfertxt.Location = new System.Drawing.Point(163, 344);
            this.transfertxt.Name = "transfertxt";
            this.transfertxt.Size = new System.Drawing.Size(180, 20);
            this.transfertxt.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Amount";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 528);
            this.Controls.Add(this.transfertxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.desaccounttxt);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.fromacctxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.TextBox desaccounttxt;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox fromacctxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox transfertxt;
        private System.Windows.Forms.Label label5;
    }
}