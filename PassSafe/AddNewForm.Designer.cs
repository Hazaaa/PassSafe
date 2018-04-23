namespace PassSafe
{
    partial class AddNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSiteName = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbURL = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPassSafeLogo = new System.Windows.Forms.Label();
            this.tltpURL = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Site Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username/E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(9, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(9, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Site URL:";
            // 
            // txbSiteName
            // 
            this.txbSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbSiteName.Location = new System.Drawing.Point(14, 102);
            this.txbSiteName.Name = "txbSiteName";
            this.txbSiteName.Size = new System.Drawing.Size(262, 22);
            this.txbSiteName.TabIndex = 4;
            this.txbSiteName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSiteName_KeyPress);
            this.txbSiteName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txbUsername
            // 
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbUsername.Location = new System.Drawing.Point(14, 156);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(262, 22);
            this.txbUsername.TabIndex = 5;
            this.txbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbPassword.Location = new System.Drawing.Point(14, 210);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(262, 22);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassword_KeyPress);
            // 
            // txbURL
            // 
            this.txbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbURL.Location = new System.Drawing.Point(14, 264);
            this.txbURL.Name = "txbURL";
            this.txbURL.Size = new System.Drawing.Size(262, 22);
            this.txbURL.TabIndex = 7;
            this.txbURL.Enter += new System.EventHandler(this.txbURL_Enter);
            this.txbURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbURL_KeyPress);
            this.txbURL.Leave += new System.EventHandler(this.txbURL_Leave);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(12, 308);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(275, 35);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(76, 34);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(155, 33);
            this.lblNewPassword.TabIndex = 36;
            this.lblNewPassword.Text = "New password";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(251, -1);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(25, 33);
            this.lblHelp.TabIndex = 38;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(273, -1);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(29, 33);
            this.lblX.TabIndex = 37;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PassSafe.Properties.Resources._512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblPassSafeLogo
            // 
            this.lblPassSafeLogo.AutoSize = true;
            this.lblPassSafeLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblPassSafeLogo.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassSafeLogo.ForeColor = System.Drawing.Color.White;
            this.lblPassSafeLogo.Location = new System.Drawing.Point(24, -1);
            this.lblPassSafeLogo.Name = "lblPassSafeLogo";
            this.lblPassSafeLogo.Size = new System.Drawing.Size(95, 33);
            this.lblPassSafeLogo.TabIndex = 39;
            this.lblPassSafeLogo.Text = "PassSafe";
            // 
            // AddNewForm
            // 
            this.AcceptButton = this.btnAddNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(299, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassSafeLogo);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txbURL);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbSiteName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewForm";
            this.Text = "New Password";
            this.Load += new System.EventHandler(this.AddNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSiteName;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbURL;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPassSafeLogo;
        private System.Windows.Forms.ToolTip tltpURL;
    }
}