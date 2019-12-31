namespace WinLockPasswordUtils
{
    partial class PassMan
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.tbox_rpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Set new WinLock password.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password";
            // 
            // tbox_pass
            // 
            this.tbox_pass.Location = new System.Drawing.Point(12, 69);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.PasswordChar = '*';
            this.tbox_pass.Size = new System.Drawing.Size(387, 20);
            this.tbox_pass.TabIndex = 2;
            // 
            // tbox_rpass
            // 
            this.tbox_rpass.Location = new System.Drawing.Point(12, 128);
            this.tbox_rpass.Name = "tbox_rpass";
            this.tbox_rpass.PasswordChar = '*';
            this.tbox_rpass.Size = new System.Drawing.Size(387, 20);
            this.tbox_rpass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Retype New Password";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(324, 192);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // PassMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 227);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tbox_rpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassMan";
            this.ShowIcon = false;
            this.Text = "WinLock Password Utils";
            this.Load += new System.EventHandler(this.PassMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.TextBox tbox_rpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_change;
    }
}

