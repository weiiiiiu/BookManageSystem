﻿namespace BookManageSystem
{
    partial class FormUpdatePwd_Admin
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
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOkPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(183, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldPwd.Location = new System.Drawing.Point(383, 154);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(339, 50);
            this.txtOldPwd.TabIndex = 1;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNewPwd.Location = new System.Drawing.Point(383, 242);
            this.txtNewPwd.MaxLength = 6;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(339, 50);
            this.txtNewPwd.TabIndex = 3;
            this.txtNewPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(183, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // txtOkPwd
            // 
            this.txtOkPwd.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOkPwd.Location = new System.Drawing.Point(383, 336);
            this.txtOkPwd.MaxLength = 6;
            this.txtOkPwd.Name = "txtOkPwd";
            this.txtOkPwd.Size = new System.Drawing.Size(339, 50);
            this.txtOkPwd.TabIndex = 5;
            this.txtOkPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(183, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(190, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 82);
            this.button1.TabIndex = 6;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("霞鹜文楷等宽 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(526, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 82);
            this.button2.TabIndex = 7;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormUpdatePwd_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 745);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOkPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUpdatePwd_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUpdatePwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOkPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}