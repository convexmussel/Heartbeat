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
            this.loginScreen = new Heartbeat_monitor.LoginScreen();
            this.signUp = new Heartbeat_monitor.SignUp();
            this.userControl11 = new Heartbeat_monitor.UserControl1();
            this.SuspendLayout();
            // 
            // loginScreen
            // 
            this.loginScreen.Location = new System.Drawing.Point(23, 12);
            this.loginScreen.Margin = new System.Windows.Forms.Padding(4);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(411, 190);
            this.loginScreen.TabIndex = 0;
            this.loginScreen.Load += new System.EventHandler(this.loginScreen_Load);
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(23, 12);
            this.signUp.Margin = new System.Windows.Forms.Padding(4);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(422, 191);
            this.signUp.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(23, 11);
            this.userControl11.Margin = new System.Windows.Forms.Padding(2);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(523, 518);
            this.userControl11.TabIndex = 2;
            // 
            // Heartbeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 474);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.loginScreen);
            this.Controls.Add(this.signUp);
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

