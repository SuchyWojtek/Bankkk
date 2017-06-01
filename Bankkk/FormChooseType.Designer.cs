namespace Bankkk
{
    partial class FormChooseType
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
            this.radBtnPriv = new System.Windows.Forms.RadioButton();
            this.radBtnFirm = new System.Windows.Forms.RadioButton();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radBtnPriv
            // 
            this.radBtnPriv.AutoSize = true;
            this.radBtnPriv.Location = new System.Drawing.Point(13, 13);
            this.radBtnPriv.Name = "radBtnPriv";
            this.radBtnPriv.Size = new System.Drawing.Size(100, 17);
            this.radBtnPriv.TabIndex = 0;
            this.radBtnPriv.TabStop = true;
            this.radBtnPriv.Text = "Private account";
            this.radBtnPriv.UseVisualStyleBackColor = true;
            // 
            // radBtnFirm
            // 
            this.radBtnFirm.AutoSize = true;
            this.radBtnFirm.Location = new System.Drawing.Point(114, 13);
            this.radBtnFirm.Name = "radBtnFirm";
            this.radBtnFirm.Size = new System.Drawing.Size(86, 17);
            this.radBtnFirm.TabIndex = 1;
            this.radBtnFirm.TabStop = true;
            this.radBtnFirm.Text = "Firm account";
            this.radBtnFirm.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(66, 42);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Confirm";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // FormChooseType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(211, 77);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.radBtnFirm);
            this.Controls.Add(this.radBtnPriv);
            this.Name = "FormChooseType";
            this.Text = "FormChooseType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBtnPriv;
        private System.Windows.Forms.RadioButton radBtnFirm;
        private System.Windows.Forms.Button btnChoose;
    }
}