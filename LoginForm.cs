using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string sql = $"SELECT [FullName], [Section], [Age], [Username], [Password] FROM tblUsers WHERE Username = '{username}' AND Password = '{password}'";
                bool isAuthenticated = CRUD.CRUD.RETRIEVESINGLE(sql);

                string dbEmail, dbPassword;
                string fullname, section, age;
                int dtCount = CRUD.CRUD.dt.Rows.Count;
                
                if(isAuthenticated && dtCount > 0)
                {
                    dbEmail = CRUD.CRUD.dt.Rows[0]["Username"].ToString();
                    dbPassword = CRUD.CRUD.dt.Rows[0]["Password"].ToString();


                    if(dbEmail.Equals(username, StringComparison.Ordinal) && dbPassword.Equals(password, StringComparison.Ordinal))
                    {
                        fullname = CRUD.CRUD.dt.Rows[0]["FullName"].ToString();
                        section = CRUD.CRUD.dt.Rows[0]["Section"].ToString();
                        age = CRUD.CRUD.dt.Rows[0]["Age"].ToString();

                        MessageBox.Show($"Welcome to EMS, {fullname}!", "Login Successfully");
                        this.Hide();

                        frmMotherForm openForm = new frmMotherForm();
                        openForm.ShowDialog();
                    } else
                    {
                        MessageBox.Show("Invalid username or password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                } else
                {
                    MessageBox.Show("No data found.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}
