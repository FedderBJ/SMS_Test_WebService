namespace SMS_Test
{
    partial class Form1
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
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbToPhoneNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(566, 231);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(75, 23);
            this.btnSendSMS.TabIndex = 0;
            this.btnSendSMS.Text = "Send SMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(12, 8);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(126, 20);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "balance";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(144, 8);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(126, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "cifavuvu";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(13, 34);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(628, 191);
            this.tbMessage.TabIndex = 3;
            // 
            // tbToPhoneNo
            // 
            this.tbToPhoneNo.Location = new System.Drawing.Point(541, 12);
            this.tbToPhoneNo.Name = "tbToPhoneNo";
            this.tbToPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.tbToPhoneNo.TabIndex = 4;
            this.tbToPhoneNo.Text = "+4520444516";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 266);
            this.Controls.Add(this.tbToPhoneNo);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btnSendSMS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendSMS;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbToPhoneNo;
    }
}

