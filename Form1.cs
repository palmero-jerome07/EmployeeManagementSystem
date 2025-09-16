namespace EmployeeManagementSystem
{
    public partial class frmMotherForm : Form
    {

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;



        public frmMotherForm()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void frmMotherForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblFooter.Text = $"© {DateTime.Now.Year} EMS. All rights reserved.";
        }

        private void OpenChildForm(Form childform)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlStage.Controls.Add(childform);
            pnlStage.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMasterData());
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddEmployee());
        }

        private void btnMasterData_MouseEnter(object sender, EventArgs e)
        {
            btnMasterData.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnMasterData_MouseLeave(object sender, EventArgs e)
        {
            btnMasterData.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void btnAddEmp_MouseEnter(object sender, EventArgs e)
        {
            btnAddEmp.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnAddEmp_MouseLeave(object sender, EventArgs e)
        {
            btnAddEmp.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(231, 76, 60);
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(236, 240, 241);
            btnClose.ForeColor = Color.Black;
        }

        private void pnlStage_MouseEnter(object sender, EventArgs e)
        {
            pnlStage.BackColor = Color.FromArgb(245, 246, 250);
        }

        private void pnlStage_MouseLeave(object sender, EventArgs e)
        {
            pnlStage.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void LblHeader_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Common.ReleaseCapture();
                Common.SendMessage(Handle, Common.WM_NCLBUTTONDOWN, Common.HT_CAPTION, 0);
            }
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }
    }
}
