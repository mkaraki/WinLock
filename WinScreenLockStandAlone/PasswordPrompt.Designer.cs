namespace WinLockStandAlone
{
    partial class PasswordPrompt
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pwask = new System.Windows.Forms.Label();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_pwask, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbox_pass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_unlock, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_pwask
            // 
            this.lbl_pwask.AutoSize = true;
            this.lbl_pwask.Location = new System.Drawing.Point(3, 15);
            this.lbl_pwask.Name = "lbl_pwask";
            this.lbl_pwask.Size = new System.Drawing.Size(54, 12);
            this.lbl_pwask.TabIndex = 0;
            this.lbl_pwask.Text = "Password";
            // 
            // tbox_pass
            // 
            this.tbox_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_pass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbox_pass.Location = new System.Drawing.Point(3, 33);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.PasswordChar = '*';
            this.tbox_pass.Size = new System.Drawing.Size(383, 19);
            this.tbox_pass.TabIndex = 1;
            this.tbox_pass.UseSystemPasswordChar = true;
            this.tbox_pass.WordWrap = false;
            // 
            // btn_unlock
            // 
            this.btn_unlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_unlock.Location = new System.Drawing.Point(3, 98);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(383, 24);
            this.btn_unlock.TabIndex = 2;
            this.btn_unlock.Text = "Unlock";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // PasswordPrompt
            // 
            this.AcceptButton = this.btn_unlock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 125);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordPrompt";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinLock";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_pwask;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Button btn_unlock;
    }
}