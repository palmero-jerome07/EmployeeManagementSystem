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
            if (string.IsNullOrWhiteSpace(txtEmpID.Text) || string.IsNullOrWhiteSpace(txtRequestorName.Text) || string.IsNullOrWhiteSpace(txtEmailAddress.Text) || string.IsNullOrWhiteSpace(cmbSection.Text) || string.IsNullOrWhiteSpace(txtLocalNumber.Text))
            {
                MessageBox.Show("Please fill up all the fields.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            bool dtg_addrequestor = false;
            string EMS_data = string.Empty;
            EMS_data = "SELECT * FROM [tblEmployeeData] WHERE [EmployeeNumber] = '" + txtEmpID.Text + "'";
            dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);

            if (dtg_addrequestor == true)
            {
                MessageBox.Show("This account '" + txtRequestorName.Text + "' is already exist.", "Not found.",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtRequestorName.Text = "";
                txtEmailAddress.Text = "";
                txtLocalNumber.Text = "";
            }
            else
            {
                string add_requestor = "INSERT INTO [tblEmployeeData] ([EmployeeNumber],[RequestorName], [RequestorEmail], [Section],[LocalNumber]) VALUES ('" + txtEmpID.Text + "','" + txtRequestorName.Text + "','" + txtEmailAddress.Text + "','" + cmbSection.Text + "','" + txtLocalNumber.Text + "')";

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
            button2.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnInsertUpdate.BackColor = Color.FromArgb(26, 188, 156);
        }
    }
}
