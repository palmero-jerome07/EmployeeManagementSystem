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
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private Panel pnlChildTitle;
        private DataGridView dtgMasterData;
        private PictureBox pictureBox1;
        private Button btnEditData;
        private Label lblTransactionNo;
        private ToolTip TTeditData;
        private IContainer components;
        private ToolTip TTtransactionNum;
        private Label lblMasterData;

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMasterData));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlChildTitle = new Panel();
            pictureBox1 = new PictureBox();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            btnEditData = new Button();
            lblTransactionNo = new Label();
            TTeditData = new ToolTip(components);
            TTtransactionNum = new ToolTip(components);
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = Color.FromArgb(43, 77, 95);
            pnlChildTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlChildTitle.Controls.Add(pictureBox1);
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.ForeColor = Color.FromArgb(236, 240, 241);
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 28);
            pnlChildTitle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(41, 4);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(92, 20);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "Master Data";
            lblMasterData.Click += lblMasterData_Click;
            // 
            // dtgMasterData
            // 
            dtgMasterData.BackgroundColor = Color.FromArgb(245, 246, 250);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgMasterData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgMasterData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMasterData.Dock = DockStyle.Fill;
            dtgMasterData.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgMasterData.EnableHeadersVisualStyles = false;
            dtgMasterData.Location = new Point(0, 28);
            dtgMasterData.Name = "dtgMasterData";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgMasterData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgMasterData.Size = new Size(748, 295);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellClick += dtgMasterData_CellClick;
            dtgMasterData.CellContentClick += dtgMasterData_CellContentClick;
            dtgMasterData.RowHeaderMouseClick += dtgMasterData_RowHeaderMouseClick;
            // 
            // btnEditData
            // 
            btnEditData.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditData.BackColor = Color.FromArgb(60, 173, 150);
            btnEditData.FlatStyle = FlatStyle.Flat;
            btnEditData.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditData.Location = new Point(659, 339);
            btnEditData.Name = "btnEditData";
            btnEditData.Size = new Size(75, 23);
            btnEditData.TabIndex = 4;
            btnEditData.Text = "Edit Data";
            TTeditData.SetToolTip(btnEditData, "Edit Data Row");
            btnEditData.UseVisualStyleBackColor = false;
            btnEditData.Click += btnEditData_Click;
            btnEditData.MouseEnter += btnEditData_MouseEnter;
            btnEditData.MouseLeave += btnEditData_MouseLeave;
            // 
            // lblTransactionNo
            // 
            lblTransactionNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTransactionNo.AutoSize = true;
            lblTransactionNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionNo.Location = new Point(12, 339);
            lblTransactionNo.Name = "lblTransactionNo";
            lblTransactionNo.Size = new Size(173, 17);
            lblTransactionNo.TabIndex = 5;
            lblTransactionNo.Text = "<TRANSACTION NUMBER>";
            TTtransactionNum.SetToolTip(lblTransactionNo, "Employee unique ID");
            // 
            // frmMasterData
            // 
            BackColor = SystemColors.Window;
            ClientSize = new Size(748, 373);
            Controls.Add(lblTransactionNo);
            Controls.Add(btnEditData);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMasterData";
            Padding = new Padding(0, 0, 0, 50);
            Text = "Master Data";
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblMasterData_Click(object sender, EventArgs e)
        {

        }

        public void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgMasterData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        public static string selectedTransaction, RequestorName, EmailAddress, Section, LocalNumber, EmployeeNumber;

        private void btnEditData_Click(object sender, EventArgs e)
        {
            frmAddEmployee openForm = new frmAddEmployee();
            openForm.ShowDialog();

            this.refreshData();
        }

        private void refreshData()
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }


        private void dtgMasterData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            lblTransactionNo.Text = dtgMasterData.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            selectedTransaction = lblTransactionNo.Text;
            EmployeeNumber = dtgMasterData.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            RequestorName = dtgMasterData.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            EmailAddress = dtgMasterData.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            Section = dtgMasterData.Rows[e.RowIndex].Cells["Section"].Value.ToString();
            LocalNumber = dtgMasterData.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
        }

        private void btnEditData_MouseEnter(object sender, EventArgs e)
        {
            btnEditData.BackColor = Color.FromArgb(14, 102, 85);
        }

        private void btnEditData_MouseLeave(object sender, EventArgs e)
        {
            btnEditData.BackColor = Color.FromArgb(26, 188, 156);
        }
    }
}
