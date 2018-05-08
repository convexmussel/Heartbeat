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
            this.SuspendLayout();
            // 
            // loginScreen
            // 
            this.loginScreen.Location = new System.Drawing.Point(23, 12);
            this.loginScreen.Name = "loginScreen";
            this.loginScreen.Size = new System.Drawing.Size(411, 190);
            this.loginScreen.TabIndex = 0;
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(23, 12);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(422, 191);
            this.signUp.TabIndex = 1;
            // 
            // Heartbeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginScreen);
            this.Controls.Add(this.signUp);
            this.Name = "Heartbeat";
            this.Text = "Heartbeat";
          
            this.ResumeLayout(false);

        }

        #endregion

       
        private LoginScreen loginScreen;
        private SignUp signUp;
    }
}

