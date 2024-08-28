namespace WinBankID
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAccountInfo = new Label();
            btnCreateAccount = new Button();
            btnDeposit_Click = new Button();
            btnWithdraw_Click = new Button();
            txtAccountNumber = new TextBox();
            txtInitialBalance = new TextBox();
            txtAmount = new TextBox();
            listBoxTransactions = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblAccountInfo
            // 
            lblAccountInfo.AutoSize = true;
            lblAccountInfo.Location = new Point(12, 9);
            lblAccountInfo.Name = "lblAccountInfo";
            lblAccountInfo.Size = new Size(38, 15);
            lblAccountInfo.TabIndex = 0;
            lblAccountInfo.Text = "label1";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            btnCreateAccount.Location = new Point(67, 134);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(82, 27);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "Створити";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnDeposit_Click
            // 
            btnDeposit_Click.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            btnDeposit_Click.Location = new Point(12, 279);
            btnDeposit_Click.Name = "btnDeposit_Click";
            btnDeposit_Click.Size = new Size(75, 23);
            btnDeposit_Click.TabIndex = 2;
            btnDeposit_Click.Text = "Депозит";
            btnDeposit_Click.UseVisualStyleBackColor = true;
            btnDeposit_Click.Click += btnDeposit_Click_Click;
            // 
            // btnWithdraw_Click
            // 
            btnWithdraw_Click.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            btnWithdraw_Click.Location = new Point(126, 279);
            btnWithdraw_Click.Name = "btnWithdraw_Click";
            btnWithdraw_Click.Size = new Size(75, 23);
            btnWithdraw_Click.TabIndex = 3;
            btnWithdraw_Click.Text = "Зняти";
            btnWithdraw_Click.UseVisualStyleBackColor = true;
            btnWithdraw_Click.Click += btnWithdraw_Click_Click;
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            txtAccountNumber.Location = new Point(12, 58);
            txtAccountNumber.Multiline = true;
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(189, 32);
            txtAccountNumber.TabIndex = 4;
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            txtInitialBalance.Location = new Point(12, 96);
            txtInitialBalance.Multiline = true;
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(189, 32);
            txtInitialBalance.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Times New Roman", 9.75F, FontStyle.Italic);
            txtAmount.Location = new Point(12, 239);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(189, 22);
            txtAmount.TabIndex = 6;
            // 
            // listBoxTransactions
            // 
            listBoxTransactions.Font = new Font("Times New Roman", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            listBoxTransactions.FormattingEnabled = true;
            listBoxTransactions.ItemHeight = 14;
            listBoxTransactions.Location = new Point(226, 239);
            listBoxTransactions.Name = "listBoxTransactions";
            listBoxTransactions.Size = new Size(334, 186);
            listBoxTransactions.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(129, 216, 153);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.FromArgb(1, 53, 15);
            textBox1.Location = new Point(460, 12);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(100, 28);
            textBox1.TabIndex = 8;
            textBox1.Text = "BANK ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(129, 216, 153);
            ClientSize = new Size(572, 443);
            Controls.Add(textBox1);
            Controls.Add(listBoxTransactions);
            Controls.Add(txtAmount);
            Controls.Add(txtInitialBalance);
            Controls.Add(txtAccountNumber);
            Controls.Add(btnWithdraw_Click);
            Controls.Add(btnDeposit_Click);
            Controls.Add(btnCreateAccount);
            Controls.Add(lblAccountInfo);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountInfo;
        private Button btnCreateAccount;
        private Button btnDeposit_Click;
        private Button btnWithdraw_Click;
        private TextBox txtAccountNumber;
        private TextBox txtInitialBalance;
        private TextBox txtAmount;
        private ListBox listBoxTransactions;
        private TextBox textBox1;
    }
}
