namespace Bankkk
{
    partial class FormWithdraw
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
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.txtHowMuch = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(12, 9);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(213, 17);
            this.lblWithdraw.TabIndex = 0;
            this.lblWithdraw.Text = "How much you wish to withdraw?";
            // 
            // txtHowMuch
            // 
            this.txtHowMuch.Location = new System.Drawing.Point(12, 46);
            this.txtHowMuch.Name = "txtHowMuch";
            this.txtHowMuch.Size = new System.Drawing.Size(290, 22);
            this.txtHowMuch.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(12, 86);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(135, 39);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(167, 86);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 137);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtHowMuch);
            this.Controls.Add(this.lblWithdraw);
            this.Name = "FormWithdraw";
            this.Text = "Withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.TextBox txtHowMuch;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnBack;
    }
}