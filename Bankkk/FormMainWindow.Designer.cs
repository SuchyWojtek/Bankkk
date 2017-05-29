namespace Bankkk
{
    partial class FormMainWindow
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnGetYourInfo = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(12, 12);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(368, 38);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(12, 56);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(368, 38);
            this.btnSaldo.TabIndex = 1;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnGetYourInfo
            // 
            this.btnGetYourInfo.Location = new System.Drawing.Point(12, 100);
            this.btnGetYourInfo.Name = "btnGetYourInfo";
            this.btnGetYourInfo.Size = new System.Drawing.Size(368, 38);
            this.btnGetYourInfo.TabIndex = 2;
            this.btnGetYourInfo.Text = "Get your info";
            this.btnGetYourInfo.UseVisualStyleBackColor = true;
            this.btnGetYourInfo.Click += new System.EventHandler(this.btnGetYourInfo_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(12, 144);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(368, 38);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 188);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(368, 38);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Location = new System.Drawing.Point(12, 232);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(368, 38);
            this.btnLogOff.TabIndex = 5;
            this.btnLogOff.Text = "Log off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(368, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(12, 276);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(368, 38);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 368);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnGetYourInfo);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.btnWithdraw);
            this.Name = "FormMainWindow";
            this.Text = "Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnGetYourInfo;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteAccount;
    }
}