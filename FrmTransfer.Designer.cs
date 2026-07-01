namespace BankingManagement
{
    partial class FrmTransfer
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnSearchFrom = new System.Windows.Forms.Button();
            this.txtToAccountNo = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.txtFromAccountNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToName = new System.Windows.Forms.TextBox();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.btnSearchFromTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(385, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 46);
            this.label5.TabIndex = 34;
            this.label5.Text = "Transfer Amount";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(435, 514);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 40);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(535, 454);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 40);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(335, 454);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(140, 40);
            this.btnTransfer.TabIndex = 31;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnSearchFrom
            // 
            this.btnSearchFrom.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFrom.ForeColor = System.Drawing.Color.White;
            this.btnSearchFrom.Location = new System.Drawing.Point(709, 134);
            this.btnSearchFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchFrom.Name = "btnSearchFrom";
            this.btnSearchFrom.Size = new System.Drawing.Size(100, 35);
            this.btnSearchFrom.TabIndex = 30;
            this.btnSearchFrom.Text = "Search";
            this.btnSearchFrom.UseVisualStyleBackColor = false;
            this.btnSearchFrom.Click += new System.EventHandler(this.btnSearchFrom_Click);
            // 
            // txtToAccountNo
            // 
            this.txtToAccountNo.Location = new System.Drawing.Point(435, 293);
            this.txtToAccountNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToAccountNo.Name = "txtToAccountNo";
            this.txtToAccountNo.Size = new System.Drawing.Size(240, 30);
            this.txtToAccountNo.TabIndex = 29;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(435, 240);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(240, 30);
            this.txtBalance.TabIndex = 28;
            // 
            // txtFromName
            // 
            this.txtFromName.Location = new System.Drawing.Point(435, 190);
            this.txtFromName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.ReadOnly = true;
            this.txtFromName.Size = new System.Drawing.Size(240, 30);
            this.txtFromName.TabIndex = 27;
            // 
            // txtFromAccountNo
            // 
            this.txtFromAccountNo.Location = new System.Drawing.Point(435, 140);
            this.txtFromAccountNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFromAccountNo.Name = "txtFromAccountNo";
            this.txtFromAccountNo.Size = new System.Drawing.Size(240, 30);
            this.txtFromAccountNo.TabIndex = 26;
            this.txtFromAccountNo.TextChanged += new System.EventHandler(this.txtFromAccountNo_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "To Account No";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Balance  ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "From Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "From Account No";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "To Name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 390);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Transfer Amount";
            // 
            // txtToName
            // 
            this.txtToName.Location = new System.Drawing.Point(435, 340);
            this.txtToName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtToName.Name = "txtToName";
            this.txtToName.ReadOnly = true;
            this.txtToName.Size = new System.Drawing.Size(240, 30);
            this.txtToName.TabIndex = 37;
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(435, 390);
            this.txtTransferAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(240, 30);
            this.txtTransferAmount.TabIndex = 38;
            // 
            // btnSearchFromTo
            // 
            this.btnSearchFromTo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchFromTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFromTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFromTo.ForeColor = System.Drawing.Color.White;
            this.btnSearchFromTo.Location = new System.Drawing.Point(709, 288);
            this.btnSearchFromTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchFromTo.Name = "btnSearchFromTo";
            this.btnSearchFromTo.Size = new System.Drawing.Size(100, 35);
            this.btnSearchFromTo.TabIndex = 39;
            this.btnSearchFromTo.Text = "Search";
            this.btnSearchFromTo.UseVisualStyleBackColor = false;
            this.btnSearchFromTo.Click += new System.EventHandler(this.btnSearchFromTo_Click);
            // 
            // FrmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btnSearchFromTo);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.txtToName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnSearchFrom);
            this.Controls.Add(this.txtToAccountNo);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtFromName);
            this.Controls.Add(this.txtFromAccountNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnSearchFrom;
        private System.Windows.Forms.TextBox txtToAccountNo;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.TextBox txtFromAccountNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtToName;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Button btnSearchFromTo;
    }
}