using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassSafe
{
    public partial class FirstTimeForm : Form
    {

        #region Constructor

        public FirstTimeForm()
        {
            InitializeComponent();
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

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '@')
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '@')
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cxbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cxbShow.Checked == true)
            {
                txbConfirm.UseSystemPasswordChar = false;
                txbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbConfirm.UseSystemPasswordChar = true;
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbConfirm_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbPassword.Text.Equals(txbConfirm.Text))
            {
                lblCheckPassword.Text = "     Passwords match!";
                lblCheckPassword.ForeColor = Color.Green;
                lblCheckPassword.Visible = true;
            }
            else
            {
                lblCheckPassword.Text = "X Passwords don't match!";
                lblCheckPassword.ForeColor = Color.Red;
                lblCheckPassword.Visible = true;
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //Closing app with closing all other forms that are open
            if (MessageBox.Show("Are you sure you want to close app?\nYou have to set universal password if you want to use app!", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to set your universal password first.\nYou will use that password to access all your other passwords,\nso please set password that you'll always remember,\nbecause you can't change it later!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txbPassword.Text.Equals(txbConfirm.Text) || txbPassword.Text.Equals(""))
            {
                MessageBox.Show("Passwords don't match or password is empty!", "Check password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            //Hashing password
            String userPassword = txbPassword.Text;
            String salt = "~ps$sf~";

            String saltAndPwd = String.Concat(userPassword, salt);
            Encoding encoder = Encoding.ASCII;
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(saltAndPwd));
            String hashedPassword = Encoding.ASCII.GetString(hashedDataBytes);

            //Creating folder where password will be saved
            String folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe";
            System.IO.Directory.CreateDirectory(folderPath);
            //

            using (BinaryWriter bw = new BinaryWriter(new FileStream(folderPath + "\\dump.txt", FileMode.Create)))
            {
                bw.Write(hashedDataBytes);
            }
            //

            //FIRST TRY WITH ENCRYPTION
            ////Encrypting password
            //byte[] passwordBytes = Encoding.ASCII.GetBytes(userPassword);

            //byte[] encryptedPassword = ProtectedData.Protect(passwordBytes, null, DataProtectionScope.CurrentUser);
            ////

            ////Creating folder where password will be saved
            //String folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe";
            //System.IO.Directory.CreateDirectory(folderPath);
            ////

            ////Saving encrypted password
            //using (BinaryWriter bw = new BinaryWriter(new FileStream(folderPath + "\\dump.txt", FileMode.Create)))
            //{
            //    bw.Write(encryptedPassword);
            //}
            ////

            this.Hide();
            var x = new PasswordForm();
            x.ShowDialog();
            this.Close();
        }

        //Adding fade in when app is oppening
        private void FirstTimeForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (double i = 0; i <= 1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
        }
        //
        #endregion
    }
}
