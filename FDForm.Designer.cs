namespace Banking_Application
{
    partial class FDForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rupeestxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.interesttxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Period(day)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interest(%)";
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(183, 128);
            this.accnotxt.Margin = new System.Windows.Forms.Padding(4);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(263, 22);
            this.accnotxt.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // rupeestxt
            // 
            this.rupeestxt.Location = new System.Drawing.Point(183, 267);
            this.rupeestxt.Margin = new System.Windows.Forms.Padding(4);
            this.rupeestxt.Name = "rupeestxt";
            this.rupeestxt.Size = new System.Drawing.Size(263, 22);
            this.rupeestxt.TabIndex = 8;
            // 
            // periodtxt
            // 
            this.periodtxt.Location = new System.Drawing.Point(183, 342);
            this.periodtxt.Margin = new System.Windows.Forms.Padding(4);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(263, 22);
            this.periodtxt.TabIndex = 9;
            // 
            // interesttxt
            // 
            this.interesttxt.Location = new System.Drawing.Point(183, 430);
            this.interesttxt.Margin = new System.Windows.Forms.Padding(4);
            this.interesttxt.Name = "interesttxt";
            this.interesttxt.Size = new System.Drawing.Size(263, 22);
            this.interesttxt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 512);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 69);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(621, 65);
            this.datelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(0, 16);
            this.datelbl.TabIndex = 12;
            // 
            // FDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 708);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.interesttxt);
            this.Controls.Add(this.periodtxt);
            this.Controls.Add(this.rupeestxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDForm";
            this.Text = "FDForm";
            this.Load += new System.EventHandler(this.FDForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox rupeestxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox interesttxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label datelbl;
    }
}