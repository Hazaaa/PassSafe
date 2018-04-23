using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PassSafe
{
    public partial class MainForm : Form
    {
        private List<Password> _listOfPasswords;
        internal List<Password> ListOfPasswords { get => _listOfPasswords; set => _listOfPasswords = value; }

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            ListOfPasswords = new List<Password>();
            LoadPasswords();
            panelExport.Height = 0;
        }

        #endregion

        #region Methods

        //Making sliding panel for Export button
        public bool panelHidden = true;
        //
        public void ShowPanel()
        {
            panelExport.Height = panelExport.Height + 29;
            if (panelExport.Height >= 145)
            {
                timerPanel.Stop();
                panelHidden = false;
                this.Refresh();
            }
        }

        public void HidePanel(int minus)
        {
            panelExport.Height = panelExport.Height - minus;
            if (panelExport.Height <= 0)
            {
                timerPanel.Stop();
                panelHidden = true;
                this.Refresh();
            }
        }

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

        public string GetRandomName()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period
            return path;
        }

        public void SavePassword(Password save)
        {
            String fileName = this.GetRandomName();
            String filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe\\" + fileName + ".txt";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(filePath, FileMode.Create)))
            {
                String savePasswordForm = save.SiteName + ":" + save.Username + ":" + save.Pass + ":" + save.SiteURL;

                byte[] passwordBytes = Encoding.ASCII.GetBytes(savePasswordForm);
                byte[] encryptedPassword = ProtectedData.Protect(passwordBytes, null, DataProtectionScope.CurrentUser);

                bw.Write(encryptedPassword);
            }
        }

        public void LoadPasswords()
        {
            String filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PassSafe";
            String[] passwords = Directory.GetFiles(filePath, "*", SearchOption.TopDirectoryOnly);
            int numberOfPasswords = passwords.Length;

            for (int i = 0; i < numberOfPasswords; i++)
            {
                if (!passwords[i].Equals(filePath + "\\dump.txt"))
                {
                    byte[] encryptedData = File.ReadAllBytes(passwords[i]);
                    byte[] originalString = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
                    String decryptedPassword = Encoding.ASCII.GetString(originalString);

                    String[] splitedPassword = decryptedPassword.Split(':');
                    Password newPass = null;

                    if (splitedPassword.Length == 5)
                    {
                        newPass = new Password(splitedPassword[0], splitedPassword[1], splitedPassword[2], splitedPassword[3] + splitedPassword[4]);
                    }
                    else
                    {
                        newPass = new Password(splitedPassword[0], splitedPassword[1], splitedPassword[2], splitedPassword[3]);
                    }
                    newPass.FileName = passwords[i];
                    this.ListOfPasswords.Add(newPass);
                }
            }

            this.SortList();
        }

        public void DeletePassword(int index)
        {
            try
            {
                File.Delete(_listOfPasswords[index].FileName);
                _listOfPasswords.RemoveAt(index);
                ListOfPasswords.RemoveRange(0, ListOfPasswords.Count);
                this.LoadPasswords();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SortList()
        {
            ListOfPasswords.Sort((x, y) => x.SiteName.CompareTo(y.SiteName));
            dgvPasswords.DataSource = null;
            dgvPasswords.DataSource = ListOfPasswords;
            dgvPasswords.Columns[0].MinimumWidth = dgvPasswords.Columns[1].MinimumWidth = dgvPasswords.Columns[2].MinimumWidth = 170;
            dgvPasswords.Refresh();
        }

        #endregion

        #region Events Implementation

        private void dgvSifre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedindex = dgvPasswords.SelectedRows[0].Index;
            Password passwordSite = _listOfPasswords[selectedindex];
            try
            {
                System.Diagnostics.Process.Start(passwordSite.SiteURL);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            //Closing app with closing all other forms that are open
            if (MessageBox.Show("Are you sure you want to close app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All your passwords safe and on one place!", "Welcome to PassSafe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Adding fade in when app is oppening
        private void MainForm_Load(object sender, EventArgs e)
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var addNewForm = new AddNewForm();
            if (addNewForm.ShowDialog() == DialogResult.OK)
            {
                _listOfPasswords.Add(addNewForm.NewSifra);
                this.SavePassword(addNewForm.NewSifra);

                //Remove from grid than add again
                ListOfPasswords.RemoveRange(0, ListOfPasswords.Count);
                this.LoadPasswords();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedindex = dgvPasswords.SelectedRows[0].Index;
            if (_listOfPasswords.Count == 0)
                return;
            if (selectedindex < 0)
            {
                MessageBox.Show("You have to select password to delete!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var editForm = new AddNewForm(_listOfPasswords[selectedindex]);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    this.DeletePassword(selectedindex);
                    _listOfPasswords.Insert(selectedindex, editForm.NewSifra);
                    this.SavePassword(editForm.NewSifra);

                    //Remove from grid than add again
                    ListOfPasswords.RemoveRange(0, ListOfPasswords.Count);
                    this.LoadPasswords();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedindex = dgvPasswords.SelectedRows[0].Index;
            if (_listOfPasswords.Count == 0)
                return;
            if (selectedindex < 0)
            {
                MessageBox.Show("You have to select password to delete!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure that you want to delete selected item?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.DeletePassword(selectedindex);
                }
            }
        }

        private void txbFind_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txbFind.Text))
            {
                SortList();
            }
            else
            {
                List<Password> helpList = new List<Password>();

                foreach (Password pass in ListOfPasswords)
                {
                    if (pass.SiteName.ToLower().Contains(txbFind.Text.ToLower()))
                        helpList.Add(pass);
                }
                dgvPasswords.DataSource = null;
                dgvPasswords.DataSource = helpList;
                dgvPasswords.Columns[0].MinimumWidth = dgvPasswords.Columns[1].MinimumWidth = dgvPasswords.Columns[2].MinimumWidth = 170;
                dgvPasswords.Refresh();
            }
        }

        private void btnExport_MouseHover(object sender, EventArgs e)
        {
            timerPanel.Start();
        }

        private void btnExport_MouseLeave(object sender, EventArgs e)
        {
            timerPanel.Start();
        }

        //Timer for Export Panel sliding
        private void timerPanel_Tick(object sender, EventArgs e)
        {
            if (panelHidden)
            {
                this.ShowPanel();
            }
            else
            {
                this.HidePanel(20);
            }
        }
        //

        //Exporting to .txt File
        private void btnToTxtFile_Click(object sender, EventArgs e)
        {
            this.HidePanel(145);
            sfdExport.FileName = "";
            sfdExport.Filter = "*.txt|*.txt";
            if (sfdExport.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(sfdExport.FileName, FileMode.Create)))
                {
                    foreach (Password pass in ListOfPasswords)
                    {
                        sw.WriteLine("Site name: " + pass.SiteName);
                        sw.WriteLine("Username/E-mail: " + pass.Username);
                        sw.WriteLine("Password: " + pass.Pass);
                        sw.WriteLine("-----------------------------------------------------------------------");
                    }
                }
            }
            if (File.Exists(sfdExport.FileName))
            {
                MessageBox.Show("Your passwords are successfully exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was error while exporting your passwords!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //

        //Exporting to Word File
        private void btnToWordFile_Click(object sender, EventArgs e)
        {
            this.HidePanel(145);
            sfdExport.FileName = "";
            sfdExport.Filter = "Word document|*.docx";
            sfdExport.ShowDialog();

            try
            {
                object objMissing = System.Reflection.Missing.Value;
                object objEndOfDocument = "\\endofdoc";

                //Creating application
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;
                wordApp.WindowState = Word.WdWindowState.wdWindowStateMinimize;
                //

                //Creating document
                Word.Document wordDoc = wordApp.Documents.Add();
                //

                //Creating table
                Word.Table wordTable;
                Word.Range tableRange = wordDoc.Bookmarks.get_Item(ref objEndOfDocument).Range;
                wordTable = wordDoc.Tables.Add(tableRange, ListOfPasswords.Count + 1, 3);
                wordTable.Range.ParagraphFormat.SpaceAfter = 2;
                wordTable.Range.Borders.InsideColor = Word.WdColor.wdColorBlack;
                //

                //Adding data in table
                wordTable.Rows[1].Range.Font.Bold = 1;
                wordTable.Cell(1, 1).Range.Text = "Site Name:";
                wordTable.Cell(1, 2).Range.Text = "Username/E-mail:";
                wordTable.Cell(1, 3).Range.Text = "Password:";

                int i = 2;
                foreach (Password pass in ListOfPasswords)
                {
                    wordTable.Cell(i, 1).Range.Text = pass.SiteName;
                    wordTable.Cell(i, 2).Range.Text = pass.Username;
                    wordTable.Cell(i, 3).Range.Text = pass.Pass;
                    i++;
                }

                wordDoc.SaveAs2(sfdExport.FileName);
                wordDoc.Close();
                wordApp.Quit();

                if (File.Exists(sfdExport.FileName))
                {
                    MessageBox.Show("Your passwords are successfully exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was error while exporting your passwords!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error", MessageBoxButtons.OK);
            }
        }
        //

        //Exporting to PDF File
        private void btnToPdfFile_Click(object sender, EventArgs e)
        {
            this.HidePanel(145);
            sfdExport.FileName = "";
            sfdExport.Filter = "PDF File|*.pdf";
            sfdExport.ShowDialog();

            try
            {
                Document pdfDoc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 20, 20);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(sfdExport.FileName, FileMode.Create));

                pdfDoc.Open();

                PdfPTable pdfPTable = new PdfPTable(3);

                pdfPTable.AddCell("Site name:");
                pdfPTable.AddCell("Username/Email:");
                pdfPTable.AddCell("Password:");

                foreach (Password pass in ListOfPasswords)
                {
                    pdfPTable.AddCell(pass.SiteName);
                    pdfPTable.AddCell(pass.Username);
                    pdfPTable.AddCell(pass.Pass);
                }
                pdfDoc.Add(pdfPTable);
                pdfDoc.Close();

                if (File.Exists(sfdExport.FileName))
                {
                    MessageBox.Show("Your passwords are successfully exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was error while exporting your passwords!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }
        //

        //Exporting to Excel File
        private void btnToExcelFile_Click(object sender, EventArgs e)
        {
            this.HidePanel(145);
            sfdExport.FileName = "";
            sfdExport.Filter = "Excel File|*.xlsx";
            sfdExport.ShowDialog();

            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook wb;
                Excel.Worksheet ws;

                wb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                ws = wb.Worksheets.Add();

                int i = 2;

                ws.Cells[1, 1].Value2 = "Site Name:";
                ws.Cells[1, 2].Value2 = "Username:";
                ws.Cells[1, 3].Value2 = "Password:";

                foreach (Password pass in ListOfPasswords)
                {
                    ws.Cells[i, 1].Value2 = pass.SiteName;
                    ws.Cells[i, 2].Value2 = pass.Username;
                    ws.Cells[i, 3].Value2 = pass.Pass;
                    i++;
                }
                wb.SaveAs(sfdExport.FileName);
                wb.Close();

                if (File.Exists(sfdExport.FileName))
                {
                    MessageBox.Show("Your passwords are successfully exported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was error while exporting your passwords!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        //
        #endregion

        
    }
}
