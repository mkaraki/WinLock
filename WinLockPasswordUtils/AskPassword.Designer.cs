namespace WinLockPasswordUtils
{
    partial class AskPassword
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
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_deny = new System.Windows.Forms.Button();
            this.lbl_appdata = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_uid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // tbox_pass
            // 
            this.tbox_pass.Location = new System.Drawing.Point(12, 113);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.PasswordChar = '*';
            this.tbox_pass.Size = new System.Drawing.Size(453, 20);
            this.tbox_pass.TabIndex = 1;
            this.tbox_pass.TextChanged += new System.EventHandler(this.tbox_pass_TextChanged);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(390, 171);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_deny
            // 
            this.btn_deny.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_deny.Location = new System.Drawing.Point(309, 171);
            this.btn_deny.Name = "btn_deny";
            this.btn_deny.Size = new System.Drawing.Size(75, 23);
            this.btn_deny.TabIndex = 3;
            this.btn_deny.Text = "Deny";
            this.btn_deny.UseVisualStyleBackColor = true;
            this.btn_deny.Click += new System.EventHandler(this.btn_deny_Click);
            // 
            // lbl_appdata
            // 
            this.lbl_appdata.AutoSize = true;
            this.lbl_appdata.Location = new System.Drawing.Point(9, 9);
            this.lbl_appdata.Name = "lbl_appdata";
            this.lbl_appdata.Size = new System.Drawing.Size(231, 13);
            this.lbl_appdata.TabIndex = 4;
            this.lbl_appdata.Text = "Application wanted to access WinLock Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // tbox_uid
            // 
            this.tbox_uid.Location = new System.Drawing.Point(12, 52);
            this.tbox_uid.Name = "tbox_uid";
            this.tbox_uid.ReadOnly = true;
            this.tbox_uid.Size = new System.Drawing.Size(453, 20);
            this.tbox_uid.TabIndex = 6;
            // 
            // AskPassword
            // 
            this.AcceptButton = this.btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_deny;
            this.ClientSize = new System.Drawing.Size(477, 206);
            this.Controls.Add(this.tbox_uid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_appdata);
            this.Controls.Add(this.btn_deny);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AskPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLock Password Utils";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPassword_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AskPassword_FormClosed);
            this.Load += new System.EventHandler(this.AskPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_deny;
        private System.Windows.Forms.Label lbl_appdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_uid;
    }
}