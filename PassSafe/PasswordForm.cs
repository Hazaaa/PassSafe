using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;

namespace PassSafe
{
    public partial class PasswordForm : Form
    {
        private int _tries;

        #region Constructor

        public PasswordForm()
        {
            InitializeComponent();
            _tries = 0;
            txbUniversalPassword.Focus();
        }

        #endregion

        #region Methods

        //Making form draggable because it doesn't have borders
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        //

        #endregion

        #region Events Implementation

        private void UniversalPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '@')
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked == true)
            {
                txbUniversalPassword.UseSystemPasswordChar = false;
                txbUniversalPassword.Focus();
            }
            else
            {
                txbUniversalPassword.UseSystemPasswordChar = true;
                txbUniversalPassword.Focus();
            }
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (txbUniversalPassword.Text.Equals(""))
            {
                MessageBox.Show("You have to enter a password!", "Need Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbUniversalPassword.Focus();
                return;
            }

            //Cheking hashed password
            String enteredPassword = txbUniversalPassword.Text;
            String filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe\\dump.txt";
            String salt = "~ps$sf~";
            String saltAndPwd = String.Concat(enteredPassword, salt);
            Encoding encoder = Encoding.ASCII;
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(saltAndPwd));
            String hashedPassword = Encoding.ASCII.GetString(hashedDataBytes);

            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe\\dump.txt";
            byte[] comparePassword = File.ReadAllBytes(filepath);
            String comprPassword = Encoding.ASCII.GetString(comparePassword);
            //

            //FIRST TRY WITH ENCRYPTION
            ////Getting encrypted password
            //String filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe\\dump.txt";
            //byte[] password = null;
            //password = File.ReadAllBytes(filePath);
            ////

            ////Decrypting universal password
            //byte[] originalPassword = ProtectedData.Unprotect(password, null, DataProtectionScope.CurrentUser);
            //String decryptedPassword = Encoding.ASCII.GetString(originalPassword);
            ////

            if (hashedPassword.Equals(comprPassword))
            {
                this.Hide();
                var x = new MainForm();
                x.ShowDialog();
                this.Close();
            }
            else
            {
                _tries++;
                if (_tries >= 3)
                {
                    MessageBox.Show("Incorrect password! You lost all your tries! App is closing!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    lblCheck.Text = "       Incorrect password!\nYou have " + (3 - _tries) + " tries before closing!";
                    btnAccess.Location = new Point(318, 305);
                    lblCheck.Visible = true;
                    txbUniversalPassword.Focus();
                }
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your universal password helps you access all your other passwords!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //Closing app with closing all other forms that are open
            if (MessageBox.Show("Are you sure you want to close app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Fade in when form is appering
        private void PasswordForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (double i = 0; i <= 1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
        }

        #endregion
    }
}
