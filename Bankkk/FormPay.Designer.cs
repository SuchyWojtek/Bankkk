namespace Bankkk
{
    partial class FormPay
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtHowMuch = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(172, 87);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 39);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(17, 87);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(135, 39);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtHowMuch
            // 
            this.txtHowMuch.Location = new System.Drawing.Point(17, 47);
            this.txtHowMuch.Name = "txtHowMuch";
            this.txtHowMuch.Size = new System.Drawing.Size(290, 22);
            this.txtHowMuch.TabIndex = 5;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(17, 10);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(182, 17);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "How much you wish to pay?";
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 137);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtHowMuch);
            this.Controls.Add(this.lblPay);
            this.Name = "FormPay";
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.FormPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtHowMuch;
        private System.Windows.Forms.Label lblPay;
    }
}