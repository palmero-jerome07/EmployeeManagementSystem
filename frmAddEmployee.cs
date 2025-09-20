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
            txtRequestorName.Text = frmMasterData.RequestorName;
            txtEmailAddress.Text = frmMasterData.EmailAddress;
            cmbSection.Text = frmMasterData.Section;
            txtLocalNumber.Text = frmMasterData.LocalNumber;
            txtEmpID.Text = frmMasterData.selectedTransaction;
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
            } else if (!this.txtEmailAddress.Text.Contains("@firstasia.edu.ph"))
            {
                MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] WHERE [ID] = '" + frmMasterData.selectedTransaction + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                DialogResult result = MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist. Wanna Update?", "Already Exists.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Yes)
                {
                    if(!this.txtEmailAddress.Text.Contains("@firstasia.edu.ph"))
                    {
                        MessageBox.Show("Please enter a valid First Asia email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string update_requestor = "UPDATE [tblEmployeeData] SET [RequestorName] = '" + txtRequestorName.Text + "', [RequestorEmail] = '" + txtEmailAddress.Text + "', [Section] = '" + cmbSection.Text + "', [LocalNumber] = '" + txtLocalNumber.Text + "' WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";
                    CRUD.CRUD.CUD(update_requestor);
                    MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEmpID.Clear();
                    txtEmailAddress.Clear();
                    txtLocalNumber.Clear();
                    txtRequestorName.Clear();
                    cmbSection.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }

            }
            else
            {
                
                string add_requestor = "INSERT INTO [tblEmployeeData] ([EmployeeNumber],[RequestorName], [RequestorEmail], [Section],[LocalNumber]) VALUES ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtEmailAddress.Text + "')";

                CRUD.CRUD.CUD(add_requestor);
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Afrer saving clear all fields
                txtEmpID.Clear();
                txtEmailAddress.Clear();
                txtLocalNumber.Clear();
                txtRequestorName.Clear();
                cmbSection.Text = "";
            }
            

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
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Data", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE ID = '" + frmMasterData.selectedTransaction + "'";
                CRUD.CRUD.CUD(delete_requestor);
                MessageBox.Show("Data has been deleted.", "Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } else
            {
                return;
            }
        }
    }
}
