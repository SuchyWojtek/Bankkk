namespace Bankkk
{
    partial class FormTransfer
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
            this.lblWhom = new System.Windows.Forms.Label();
            this.txtWhom = new System.Windows.Forms.TextBox();
            this.lblHowMuch = new System.Windows.Forms.Label();
            this.txtHowMuch = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWhom
            // 
            this.lblWhom.AutoSize = true;
            this.lblWhom.Location = new System.Drawing.Point(9, 9);
            this.lblWhom.Name = "lblWhom";
            this.lblWhom.Size = new System.Drawing.Size(234, 17);
            this.lblWhom.TabIndex = 0;
            this.lblWhom.Text = "To whom you would like to transfer?";
            // 
            // txtWhom
            // 
            this.txtWhom.Location = new System.Drawing.Point(12, 29);
            this.txtWhom.Name = "txtWhom";
            this.txtWhom.Size = new System.Drawing.Size(301, 22);
            this.txtWhom.TabIndex = 1;
            // 
            // lblHowMuch
            // 
            this.lblHowMuch.AutoSize = true;
            this.lblHowMuch.Location = new System.Drawing.Point(9, 66);
            this.lblHowMuch.Name = "lblHowMuch";
            this.lblHowMuch.Size = new System.Drawing.Size(242, 17);
            this.lblHowMuch.TabIndex = 2;
            this.lblHowMuch.Text = "How much you would like to transfer?";
            // 
            // txtHowMuch
            // 
            this.txtHowMuch.Location = new System.Drawing.Point(12, 86);
            this.txtHowMuch.Name = "txtHowMuch";
            this.txtHowMuch.Size = new System.Drawing.Size(301, 22);
            this.txtHowMuch.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(9, 125);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(184, 17);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Please write your password.";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 145);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(301, 22);
            this.txtPass.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(12, 188);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(135, 39);
            this.btnTransfer.TabIndex = 6;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(178, 188);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 39);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 238);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtHowMuch);
            this.Controls.Add(this.lblHowMuch);
            this.Controls.Add(this.txtWhom);
            this.Controls.Add(this.lblWhom);
            this.Name = "FormTransfer";
            this.Text = "Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhom;
        private System.Windows.Forms.TextBox txtWhom;
        private System.Windows.Forms.Label lblHowMuch;
        private System.Windows.Forms.TextBox txtHowMuch;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnBack;
    }
}