using System.Drawing;
using System.Windows.Forms;

namespace BaiTapLonC_Winform
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.submitBtn = new System.Windows.Forms.Button();
            this.editPass = new System.Windows.Forms.TextBox();
            this.editMssv = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelMssv = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitle.Location = new System.Drawing.Point(105, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(246, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ĐĂNG NHẬP";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.submitBtn);
            this.panelLogin.Controls.Add(this.editPass);
            this.panelLogin.Controls.Add(this.editMssv);
            this.panelLogin.Controls.Add(this.labelPass);
            this.panelLogin.Controls.Add(this.labelMssv);
            this.panelLogin.Controls.Add(this.labelTitle);
            this.panelLogin.Location = new System.Drawing.Point(180, 70);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(500, 360);
            this.panelLogin.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(54, 290);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(380, 45);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Đăng Nhập";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // editPass
            // 
            this.editPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.editPass.Location = new System.Drawing.Point(54, 230);
            this.editPass.Name = "editPass";
            this.editPass.PasswordChar = '●';
            this.editPass.Size = new System.Drawing.Size(380, 32);
            this.editPass.TabIndex = 4;
            // 
            // editMssv
            // 
            this.editMssv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editMssv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.editMssv.Location = new System.Drawing.Point(54, 150);
            this.editMssv.Name = "editMssv";
            this.editMssv.Size = new System.Drawing.Size(380, 32);
            this.editMssv.TabIndex = 2;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelPass.Location = new System.Drawing.Point(50, 200);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(86, 23);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Mật khẩu";
            // 
            // labelMssv
            // 
            this.labelMssv.AutoSize = true;
            this.labelMssv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelMssv.Location = new System.Drawing.Point(50, 120);
            this.labelMssv.Name = "labelMssv";
            this.labelMssv.Size = new System.Drawing.Size(110, 23);
            this.labelMssv.TabIndex = 1;
            this.labelMssv.Text = "Mã sinh viên";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(882, 513);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Sinh Viên";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelTitle;
        private Panel panelLogin;
        private Button submitBtn;
        private TextBox editPass;
        private TextBox editMssv;
        private Label labelPass;
        private Label labelMssv;
    }
}