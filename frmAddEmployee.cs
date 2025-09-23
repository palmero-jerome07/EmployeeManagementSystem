using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
            loadInputData();
        }

        private void loadInputData()
        {
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            txtEmpID.Text = frmMasterData.EmployeeNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please enter an Employee Number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchQuery = $"SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = '{txtEmpID.Text}'";

            // Use CRUD.RETRIEVESINGLE to check if employee exists
            bool employeeExists = CRUD.CRUD.RETRIEVESINGLE(searchQuery);

            if (employeeExists)
            {
                MessageBox.Show("Employee found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpID.Clear();
            }
            else
            {
                MessageBox.Show("Employee not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Optionally clear fields or handle as needed
                txtEmpID.Clear();
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {

            //Validation for empty fields
            if ((string.IsNullOrWhiteSpace(txtEmpID.Text) || string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(cmbSection.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text)))
            {
                MessageBox.Show("Please fill up all the fields.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else if (!this.txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
            {
                MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtLocalNumber.Text.Length != 4 || !txtLocalNumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 4-digit local number.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] WHERE [ID] = " + frmMasterData.selectedTransaction + " OR [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist. Wanna Update?", "Already Exists.",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    if (!txtEmailAddress.Text.EndsWith("@firstasia.edu.ph"))
                    {
                        MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txtLocalNumber.Text.Length != 4 || !txtLocalNumber.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("Please enter a valid 4-digit local number.", "Invalid Local Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string update_requestor = "UPDATE [tblEmployeeData] SET [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' , [EmployeeNumber] = '" + txtEmpID.Text + "' WHERE [ID] = " + frmMasterData.selectedTransaction + "";
                    CRUD.CRUD.CUD(update_requestor);
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearAllFields();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("No changes were made.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadInputData();
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] ([EmployeeNumber],[RequestorName], [RequestorEmail], [Section],[LocalNumber]) VALUES ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAllFields();
            }


        }
        private void clearAllFields()
        {
            txtEmpID.Clear();
            txtEmailAddress.Clear();
            txtLocalNumber.Clear();
            txtRequestorName.Clear();
            cmbSection.Text = "";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnInsertUpdate.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnInsertUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnInsertUpdate.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnInsertUpdate.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmMasterData.selectedTransaction == null || frmMasterData.selectedTransaction == "0" || string.IsNullOrEmpty(txtEmpID.Text))
            {
                MessageBox.Show("No selected data.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Data", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE ID = " + frmMasterData.selectedTransaction;
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Data has been deleted.", "Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
            btnClose.ForeColor = Color.Black;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_MouseEnter(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.Silver;
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Silver;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        //Close button hover effects
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(231, 76, 60);
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
        }
        //Maximize button hover effects
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Silver;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }
        //Minimize button hover effects
        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
        }

        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

