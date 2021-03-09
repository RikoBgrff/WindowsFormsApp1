namespace WindowsFormsApp1
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
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.car = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTxtbx.Location = new System.Drawing.Point(82, 175);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(122, 20);
            this.usernameTxtbx.TabIndex = 0;
            this.usernameTxtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxtbx.Location = new System.Drawing.Point(82, 240);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.PasswordChar = '*';
            this.passwordTxtbx.Size = new System.Drawing.Size(122, 20);
            this.passwordTxtbx.TabIndex = 1;
            this.passwordTxtbx.TextChanged += new System.EventHandler(this.passwordTxtbx_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(112, 304);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // car
            // 
            this.car.AutoSize = true;
            this.car.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car.Location = new System.Drawing.Point(28, 100);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(237, 51);
            this.car.TabIndex = 3;
            this.car.Text = "Hippo Cars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(292, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label car;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

