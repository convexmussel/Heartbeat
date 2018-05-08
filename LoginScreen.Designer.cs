namespace Heartbeat_monitor
{
    partial class LoginScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password = new System.Windows.Forms.Label();
            this.Namel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Hint = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SigninB = new System.Windows.Forms.Button();
            this.SignupB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(43, 64);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Namel
            // 
            this.Namel.Location = new System.Drawing.Point(43, 34);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(100, 23);
            this.Namel.TabIndex = 2;
            this.Namel.Text = "Login name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(150, 34);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 3;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(150, 61);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(199, 20);
            this.PassBox.TabIndex = 4;
            // 
            // Hint
            // 
            this.Hint.AutoSize = true;
            this.Hint.Location = new System.Drawing.Point(19, 157);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(361, 13);
            this.Hint.TabIndex = 5;
            this.Hint.Text = "Forgot your login credentials please an administrator to retrieve them for you";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SigninB
            // 
            this.SigninB.Location = new System.Drawing.Point(273, 119);
            this.SigninB.Name = "SigninB";
            this.SigninB.Size = new System.Drawing.Size(75, 23);
            this.SigninB.TabIndex = 7;
            this.SigninB.Text = "Sign in";
            this.SigninB.UseVisualStyleBackColor = true;
            this.SigninB.Click += new System.EventHandler(this.SigninB_Click);
            // 
            // SignupB
            // 
            this.SignupB.Location = new System.Drawing.Point(46, 118);
            this.SignupB.Name = "SignupB";
            this.SignupB.Size = new System.Drawing.Size(75, 23);
            this.SignupB.TabIndex = 8;
            this.SignupB.Text = "Sign up";
            this.SignupB.UseVisualStyleBackColor = true;
            this.SignupB.Click += new System.EventHandler(this.SignupB_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SignupB);
            this.Controls.Add(this.SigninB);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(422, 191);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label   Namel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label Hint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SigninB;
        private System.Windows.Forms.Button SignupB;
    }
}
