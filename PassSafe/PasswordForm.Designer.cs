namespace PassSafe
{
    partial class PasswordForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txbUniversalPassword = new System.Windows.Forms.TextBox();
            this.PasswordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.ShowPasswordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMoto = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAccess = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pbxGitHub = new System.Windows.Forms.PictureBox();
            this.pbxInstagram = new System.Windows.Forms.PictureBox();
            this.pbxTwitter = new System.Windows.Forms.PictureBox();
            this.pbxFacebook = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInstagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(298, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your universal password";
            // 
            // txbUniversalPassword
            // 
            this.txbUniversalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbUniversalPassword.Location = new System.Drawing.Point(343, 202);
            this.txbUniversalPassword.MaxLength = 20;
            this.txbUniversalPassword.Name = "txbUniversalPassword";
            this.txbUniversalPassword.Size = new System.Drawing.Size(185, 24);
            this.txbUniversalPassword.TabIndex = 1;
            this.PasswordToolTip.SetToolTip(this.txbUniversalPassword, "Enter your universal password to access all your other passwords!");
            this.txbUniversalPassword.UseSystemPasswordChar = true;
            this.txbUniversalPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UniversalPasswordBox_KeyPress);
            // 
            // PasswordToolTip
            // 
            this.PasswordToolTip.AutoPopDelay = 5000;
            this.PasswordToolTip.InitialDelay = 500;
            this.PasswordToolTip.ReshowDelay = 10;
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.cbxShowPassword.Location = new System.Drawing.Point(534, 205);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(58, 23);
            this.cbxShowPassword.TabIndex = 3;
            this.cbxShowPassword.Text = "Show";
            this.ShowPasswordToolTip.SetToolTip(this.cbxShowPassword, "Show password!");
            this.cbxShowPassword.UseVisualStyleBackColor = true;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.lblName);
            this.panelLeft.Controls.Add(this.lblMoto);
            this.panelLeft.Controls.Add(this.pbxLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(294, 419);
            this.panelLeft.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Copyright © 2018 by Stefan";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(80, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 47);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "PassSafe";
            // 
            // lblMoto
            // 
            this.lblMoto.AutoSize = true;
            this.lblMoto.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMoto.Location = new System.Drawing.Point(22, 275);
            this.lblMoto.Name = "lblMoto";
            this.lblMoto.Size = new System.Drawing.Size(258, 72);
            this.lblMoto.TabIndex = 2;
            this.lblMoto.Text = "        Safe place\r\nfor all your passwords!";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackgroundImage = global::PassSafe.Properties.Resources._512;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(59, 115);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(166, 152);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.lblHelp.Location = new System.Drawing.Point(555, -1);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(25, 33);
            this.lblHelp.TabIndex = 35;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.lblX.Location = new System.Drawing.Point(582, -1);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(29, 33);
            this.lblX.TabIndex = 34;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.lblWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Location = new System.Drawing.Point(329, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(248, 84);
            this.lblWelcome.TabIndex = 33;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAccess.Location = new System.Drawing.Point(318, 297);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(274, 42);
            this.btnAccess.TabIndex = 36;
            this.btnAccess.Text = "Access";
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCheck.ForeColor = System.Drawing.Color.Red;
            this.lblCheck.Location = new System.Drawing.Point(316, 240);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(139, 28);
            this.lblCheck.TabIndex = 37;
            this.lblCheck.Text = "Check password";
            this.lblCheck.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.lblVersion.Location = new System.Drawing.Point(473, 400);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(138, 19);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.Text = "PassSafe Version: 1.0.0";
            // 
            // pbxGitHub
            // 
            this.pbxGitHub.BackgroundImage = global::PassSafe.Properties.Resources.github_logo_silhouette_in_a_square;
            this.pbxGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxGitHub.Location = new System.Drawing.Point(378, 398);
            this.pbxGitHub.Name = "pbxGitHub";
            this.pbxGitHub.Size = new System.Drawing.Size(20, 20);
            this.pbxGitHub.TabIndex = 43;
            this.pbxGitHub.TabStop = false;
            // 
            // pbxInstagram
            // 
            this.pbxInstagram.BackgroundImage = global::PassSafe.Properties.Resources.instagram;
            this.pbxInstagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxInstagram.Location = new System.Drawing.Point(352, 398);
            this.pbxInstagram.Name = "pbxInstagram";
            this.pbxInstagram.Size = new System.Drawing.Size(20, 20);
            this.pbxInstagram.TabIndex = 42;
            this.pbxInstagram.TabStop = false;
            // 
            // pbxTwitter
            // 
            this.pbxTwitter.BackgroundImage = global::PassSafe.Properties.Resources.twitter;
            this.pbxTwitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTwitter.Location = new System.Drawing.Point(326, 398);
            this.pbxTwitter.Name = "pbxTwitter";
            this.pbxTwitter.Size = new System.Drawing.Size(20, 20);
            this.pbxTwitter.TabIndex = 41;
            this.pbxTwitter.TabStop = false;
            // 
            // pbxFacebook
            // 
            this.pbxFacebook.BackgroundImage = global::PassSafe.Properties.Resources.facebook;
            this.pbxFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxFacebook.Location = new System.Drawing.Point(300, 398);
            this.pbxFacebook.Name = "pbxFacebook";
            this.pbxFacebook.Size = new System.Drawing.Size(20, 20);
            this.pbxFacebook.TabIndex = 40;
            this.pbxFacebook.TabStop = false;
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.btnAccess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 419);
            this.Controls.Add(this.pbxGitHub);
            this.Controls.Add(this.pbxInstagram);
            this.Controls.Add(this.pbxTwitter);
            this.Controls.Add(this.pbxFacebook);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.txbUniversalPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassSafe";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInstagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUniversalPassword;
        private System.Windows.Forms.ToolTip PasswordToolTip;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private System.Windows.Forms.ToolTip ShowPasswordToolTip;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMoto;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxFacebook;
        private System.Windows.Forms.PictureBox pbxTwitter;
        private System.Windows.Forms.PictureBox pbxInstagram;
        private System.Windows.Forms.PictureBox pbxGitHub;
    }
}

