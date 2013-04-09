namespace Amelie
{
    partial class FrmSendMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendMail));
            this.BtnSendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.CbUseCredentials = new System.Windows.Forms.CheckBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSendMail
            // 
            this.BtnSendMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendMail.Location = new System.Drawing.Point(15, 211);
            this.BtnSendMail.Name = "BtnSendMail";
            this.BtnSendMail.Size = new System.Drawing.Size(351, 39);
            this.BtnSendMail.TabIndex = 0;
            this.BtnSendMail.Text = "&Send Mail";
            this.BtnSendMail.UseVisualStyleBackColor = true;
            this.BtnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // TxtFrom
            // 
            this.TxtFrom.Location = new System.Drawing.Point(92, 6);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(274, 20);
            this.TxtFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(92, 32);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(274, 20);
            this.TxtTo.TabIndex = 4;
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(92, 58);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(146, 20);
            this.TxtHost.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(276, 58);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(90, 20);
            this.TxtPort.TabIndex = 8;
            this.TxtPort.Text = "25";
            // 
            // CbUseCredentials
            // 
            this.CbUseCredentials.AutoSize = true;
            this.CbUseCredentials.Checked = true;
            this.CbUseCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbUseCredentials.Location = new System.Drawing.Point(92, 84);
            this.CbUseCredentials.Name = "CbUseCredentials";
            this.CbUseCredentials.Size = new System.Drawing.Size(106, 17);
            this.CbUseCredentials.TabIndex = 9;
            this.CbUseCredentials.Text = "Use Credentials?";
            this.CbUseCredentials.UseVisualStyleBackColor = true;
            this.CbUseCredentials.CheckedChanged += new System.EventHandler(this.CbUseCredentials_CheckedChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(92, 107);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(274, 20);
            this.TxtUsername.TabIndex = 11;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(12, 110);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(55, 13);
            this.LbUsername.TabIndex = 10;
            this.LbUsername.Text = "Username";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(92, 133);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(274, 20);
            this.TxtPassword.TabIndex = 13;
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(12, 136);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(53, 13);
            this.LbPassword.TabIndex = 12;
            this.LbPassword.Text = "Password";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(92, 159);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(274, 20);
            this.TxtSubject.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Subject";
            // 
            // TxtBody
            // 
            this.TxtBody.Location = new System.Drawing.Point(92, 185);
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.Size = new System.Drawing.Size(274, 20);
            this.TxtBody.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Message";
            // 
            // FrmSendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 262);
            this.Controls.Add(this.TxtBody);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.CbUseCredentials);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSendMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSendMail";
            this.Text = "Amélie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSendMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.CheckBox CbUseCredentials;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBody;
        private System.Windows.Forms.Label label8;
    }
}

