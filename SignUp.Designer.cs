namespace Heartbeat_monitor
{
    partial class SignUp
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
            this.SignUpB = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Namel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AuthenticationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignUpB
            // 
            this.SignUpB.Location = new System.Drawing.Point(270, 118);
            this.SignUpB.Name = "SignUpB";
            this.SignUpB.Size = new System.Drawing.Size(75, 23);
            this.SignUpB.TabIndex = 0;
            this.SignUpB.Text = "Sign up";
            this.SignUpB.UseVisualStyleBackColor = true;
            this.SignUpB.Click += new System.EventHandler(this.SignUpB_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(117, 43);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(199, 20);
            this.PassBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(117, 16);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(199, 20);
            this.nameBox.TabIndex = 9;
            // 
            // Namel
            // 
            this.Namel.Location = new System.Drawing.Point(6, 16);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(100, 23);
            this.Namel.TabIndex = 8;
            this.Namel.Text = "Login name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(6, 43);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AuthenticationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.PassBox);
            this.groupBox1.Controls.Add(this.Namel);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AuthenticationBox
            // 
            this.AuthenticationBox.Location = new System.Drawing.Point(117, 69);
            this.AuthenticationBox.Name = "AuthenticationBox";
            this.AuthenticationBox.Size = new System.Drawing.Size(199, 20);
            this.AuthenticationBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "autenthencation key";
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(38, 118);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 12;
            this.backB.Text = "back";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SignUpB);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(422, 191);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignUpB;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AuthenticationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backB;
    }
}
