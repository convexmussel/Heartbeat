namespace Heartbeat_monitor
{
    partial class Heartbeat
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
            this.userControl11 = new Heartbeat_monitor.UserControl1();
            this.loginScreen = new Heartbeat_monitor.LoginScreen();
            this.signUp = new Heartbeat_monitor.SignUp();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, -6);
            this.userControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1196, 726);
            this.userControl11.TabIndex = 2;
            // 
            // loginScreen
            // 
            this.loginScreen.Location = new System.Drawing.Point(31, 15);
            this.loginScreen.Margin = new System.Windows.Forms.Padding(5);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(548, 234);
            this.loginScreen.TabIndex = 0;
            this.loginScreen.Load += new System.EventHandler(this.loginScreen_Load);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(31, 15);
            this.signUp.Margin = new System.Windows.Forms.Padding(5);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(563, 235);
            this.signUp.TabIndex = 1;
            // 
            // Heartbeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 748);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.loginScreen);
            this.Controls.Add(this.signUp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Heartbeat";
            this.Text = "Heartbeat";
            this.ResumeLayout(false);

        }

        #endregion

       
        private LoginScreen loginScreen;
        private SignUp signUp;
        private UserControl1 userControl11;
    }
}

