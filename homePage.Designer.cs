
namespace RadiantDental
{
    partial class home
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
            this.top = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Label();
            this.copyrights = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.top.Controls.Add(this.Logo);
            this.top.Location = new System.Drawing.Point(1, 4);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(854, 52);
            this.top.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.Brown;
            this.Logo.Location = new System.Drawing.Point(3, 16);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(377, 25);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Radiant Smile Dental Practice";
            // 
            // copyrights
            // 
            this.copyrights.AutoSize = true;
            this.copyrights.BackColor = System.Drawing.Color.Transparent;
            this.copyrights.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrights.Location = new System.Drawing.Point(234, 523);
            this.copyrights.Name = "copyrights";
            this.copyrights.Size = new System.Drawing.Size(381, 16);
            this.copyrights.TabIndex = 1;
            this.copyrights.Text = " Radiant Smile Dental Practice: All Rights Reserved 2020";
            this.copyrights.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(179, 163);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(485, 25);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome to Radiant Smile Dental Practice";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.Brown;
            this.btnLogin.Location = new System.Drawing.Point(268, 270);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRegister.ForeColor = System.Drawing.Color.Brown;
            this.btnRegister.Location = new System.Drawing.Point(461, 270);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 42);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RadiantDental.Properties.Resources.homePage;
            this.ClientSize = new System.Drawing.Size(854, 548);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.copyrights);
            this.Controls.Add(this.top);
            this.Name = "home";
            this.Text = "HomePage";
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label copyrights;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}

