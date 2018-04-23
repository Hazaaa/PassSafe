namespace PassSafe
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvPasswords = new System.Windows.Forms.DataGridView();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblPassSafe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.panelExport = new System.Windows.Forms.Panel();
            this.btnToExcelFile = new System.Windows.Forms.Button();
            this.btnToWordFile = new System.Windows.Forms.Button();
            this.btnToPdfFile = new System.Windows.Forms.Button();
            this.btnToTxtFile = new System.Windows.Forms.Button();
            this.timerPanel = new System.Windows.Forms.Timer(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPasswords
            // 
            this.dgvPasswords.AllowUserToAddRows = false;
            this.dgvPasswords.AllowUserToDeleteRows = false;
            this.dgvPasswords.AllowUserToResizeRows = false;
            this.dgvPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasswords.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPasswords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPasswords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPasswords.Location = new System.Drawing.Point(12, 70);
            this.dgvPasswords.MultiSelect = false;
            this.dgvPasswords.Name = "dgvPasswords";
            this.dgvPasswords.ReadOnly = true;
            this.dgvPasswords.RowHeadersVisible = false;
            this.dgvPasswords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPasswords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasswords.Size = new System.Drawing.Size(513, 314);
            this.dgvPasswords.TabIndex = 0;
            this.dgvPasswords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSifre_CellDoubleClick);
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(481, -1);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(25, 33);
            this.lblHelp.TabIndex = 34;
            this.lblHelp.Text = "?";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(508, -1);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(29, 33);
            this.lblX.TabIndex = 33;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // lblPassSafe
            // 
            this.lblPassSafe.AutoSize = true;
            this.lblPassSafe.BackColor = System.Drawing.Color.Transparent;
            this.lblPassSafe.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassSafe.ForeColor = System.Drawing.Color.White;
            this.lblPassSafe.Location = new System.Drawing.Point(27, -1);
            this.lblPassSafe.Name = "lblPassSafe";
            this.lblPassSafe.Size = new System.Drawing.Size(95, 33);
            this.lblPassSafe.TabIndex = 35;
            this.lblPassSafe.Text = "PassSafe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PassSafe.Properties.Resources._512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "_________________________________________________________________________________" +
    "______________________________________________";
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFind.AutoSize = true;
            this.lblFind.BackColor = System.Drawing.Color.Transparent;
            this.lblFind.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFind.ForeColor = System.Drawing.Color.White;
            this.lblFind.Location = new System.Drawing.Point(353, 38);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(45, 26);
            this.lblFind.TabIndex = 40;
            this.lblFind.Text = "Find";
            // 
            // txbFind
            // 
            this.txbFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbFind.Location = new System.Drawing.Point(404, 43);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(121, 20);
            this.txbFind.TabIndex = 42;
            this.txbFind.TextChanged += new System.EventHandler(this.txbFind_TextChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNew.Location = new System.Drawing.Point(12, 33);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(92, 36);
            this.btnAddNew.TabIndex = 43;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(108, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 36);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(257, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 36);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(400, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "PassSafe Version: 1.0.0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(-1, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Copyright © 2018 by Stefan";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "*Double click on site name to open site";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(180, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(74, 36);
            this.btnExport.TabIndex = 49;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.MouseLeave += new System.EventHandler(this.btnExport_MouseLeave);
            this.btnExport.MouseHover += new System.EventHandler(this.btnExport_MouseHover);
            // 
            // panelExport
            // 
            this.panelExport.Controls.Add(this.btnToExcelFile);
            this.panelExport.Controls.Add(this.btnToWordFile);
            this.panelExport.Controls.Add(this.btnToPdfFile);
            this.panelExport.Controls.Add(this.btnToTxtFile);
            this.panelExport.Location = new System.Drawing.Point(180, 70);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(153, 145);
            this.panelExport.TabIndex = 50;
            // 
            // btnToExcelFile
            // 
            this.btnToExcelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToExcelFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToExcelFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToExcelFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToExcelFile.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToExcelFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToExcelFile.Location = new System.Drawing.Point(1, 108);
            this.btnToExcelFile.Name = "btnToExcelFile";
            this.btnToExcelFile.Size = new System.Drawing.Size(151, 36);
            this.btnToExcelFile.TabIndex = 54;
            this.btnToExcelFile.Text = "-> To Excel File";
            this.btnToExcelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToExcelFile.UseVisualStyleBackColor = false;
            this.btnToExcelFile.Click += new System.EventHandler(this.btnToExcelFile_Click);
            // 
            // btnToWordFile
            // 
            this.btnToWordFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToWordFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToWordFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToWordFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToWordFile.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToWordFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToWordFile.Location = new System.Drawing.Point(1, 73);
            this.btnToWordFile.Name = "btnToWordFile";
            this.btnToWordFile.Size = new System.Drawing.Size(151, 36);
            this.btnToWordFile.TabIndex = 53;
            this.btnToWordFile.Text = "-> To Word File";
            this.btnToWordFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToWordFile.UseVisualStyleBackColor = false;
            this.btnToWordFile.Click += new System.EventHandler(this.btnToWordFile_Click);
            // 
            // btnToPdfFile
            // 
            this.btnToPdfFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToPdfFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToPdfFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToPdfFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToPdfFile.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToPdfFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToPdfFile.Location = new System.Drawing.Point(1, 37);
            this.btnToPdfFile.Name = "btnToPdfFile";
            this.btnToPdfFile.Size = new System.Drawing.Size(151, 37);
            this.btnToPdfFile.TabIndex = 52;
            this.btnToPdfFile.Text = "-> To PDF File";
            this.btnToPdfFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToPdfFile.UseVisualStyleBackColor = false;
            this.btnToPdfFile.Click += new System.EventHandler(this.btnToPdfFile_Click);
            // 
            // btnToTxtFile
            // 
            this.btnToTxtFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToTxtFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToTxtFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.btnToTxtFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToTxtFile.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnToTxtFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToTxtFile.Location = new System.Drawing.Point(1, 1);
            this.btnToTxtFile.Name = "btnToTxtFile";
            this.btnToTxtFile.Size = new System.Drawing.Size(151, 37);
            this.btnToTxtFile.TabIndex = 51;
            this.btnToTxtFile.Text = "-> To Text File";
            this.btnToTxtFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToTxtFile.UseVisualStyleBackColor = false;
            this.btnToTxtFile.Click += new System.EventHandler(this.btnToTxtFile_Click);
            // 
            // timerPanel
            // 
            this.timerPanel.Interval = 18;
            this.timerPanel.Tick += new System.EventHandler(this.timerPanel_Tick);
            // 
            // sfdExport
            // 
            this.sfdExport.Title = "Export file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(537, 428);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txbFind);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPassSafe);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelExport);
            this.Controls.Add(this.dgvPasswords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassSafe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelExport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasswords;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblPassSafe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txbFind;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panelExport;
        private System.Windows.Forms.Button btnToTxtFile;
        private System.Windows.Forms.Button btnToWordFile;
        private System.Windows.Forms.Button btnToPdfFile;
        private System.Windows.Forms.Timer timerPanel;
        private System.Windows.Forms.Button btnToExcelFile;
        private System.Windows.Forms.SaveFileDialog sfdExport;
    }
}