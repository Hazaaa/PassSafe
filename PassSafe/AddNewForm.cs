using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassSafe
{
    public partial class AddNewForm : Form
    {
        private Password _newSifra;
        internal Password NewSifra { get => _newSifra; set => _newSifra = value; }

        bool _edit = false;
        public Password _editPassword;

        #region Constructors

        public AddNewForm()
        {
            InitializeComponent();
            txbSiteName.Focus();
        }

        public AddNewForm(Password passwordForEdit)
        {
            InitializeComponent();
            _edit = true;
            lblNewPassword.Text = "Edit your password";
            lblNewPassword.Location = new Point(53, 34);
            btnAddNew.Text = "Save";
            this._editPassword = passwordForEdit;
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSiteName.Text))
                return;
            else
            {
                txbSiteName.Text = char.ToUpper(txbSiteName.Text[0]) + txbSiteName.Text.Substring(1);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txbSiteName.Text))
            {
                txbSiteName.BackColor = Color.Red;
                //MessageBox.Show("Site name cannot be empty!", "No Site Name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txbSiteName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txbUsername.Text))
            {
                txbUsername.BackColor = Color.Red;
                //MessageBox.Show("Username cannot be empty!", "No Username", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txbUsername.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txbPassword.Text))
            {
                txbPassword.BackColor = Color.Red;
                //MessageBox.Show("Password cannot be empty!", "No Password", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txbPassword.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txbURL.Text))
            {
                txbURL.BackColor = Color.Red;
                //MessageBox.Show("URL cannot be empty!", "No URL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txbURL.Focus();
                return;
            }
            _newSifra = new Password(txbSiteName.Text, txbUsername.Text, txbPassword.Text, txbURL.Text);
            this.DialogResult = DialogResult.OK;
        }

        //Fade in when from opens
        private void AddNewForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            for (double i = 0; i <= 1; i += 0.1)
            {
                this.Opacity = i;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }

            if (_edit)
            {
                txbSiteName.Text = _editPassword.SiteName;
                txbPassword.Text = _editPassword.Pass;
                txbUsername.Text = _editPassword.Username;
                txbURL.Text = _editPassword.SiteURL;
            }
        }
        //

        private void lblHelp_Click(object sender, EventArgs e)
        {
            if (!_edit)
            {
                MessageBox.Show("Add all informations about your password!", "Add new password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Change informations about your password!", "Edit password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lblX_Click(object sender, EventArgs e)
        {
            if (!_edit)
            {
                if (MessageBox.Show("Are you sure you don't want to add new password?", "No new password?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you don't want to edit password?", "No edit password?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txbSiteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbSiteName.BackColor = Color.White;
        }

        private void txbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbUsername.BackColor = Color.White;
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbPassword.BackColor = Color.White;
        }

        private void txbURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbURL.BackColor = Color.White;
        }

        private void txbURL_Enter(object sender, EventArgs e)
        {
            tltpURL.Show("Enter site URL like 'www.site.com'.", txbURL, new Point(14, 24));
        }

        private void txbURL_Leave(object sender, EventArgs e)
        {
            tltpURL.Hide(txbURL);
        }

        #endregion
    }
}
