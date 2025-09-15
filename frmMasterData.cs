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
        private Label lblMasterData;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMasterData));
            pnlChildTitle = new Panel();
            lblMasterData = new Label();
            dtgMasterData = new DataGridView();
            pnlChildTitle.SuspendLayout();
            ((ISupportInitialize)dtgMasterData).BeginInit();
            SuspendLayout();
            // 
            // pnlChildTitle
            // 
            pnlChildTitle.BackColor = Color.FromArgb(43, 77, 95);
            pnlChildTitle.BorderStyle = BorderStyle.FixedSingle;
            pnlChildTitle.Controls.Add(lblMasterData);
            pnlChildTitle.Dock = DockStyle.Top;
            pnlChildTitle.ForeColor = Color.FromArgb(236, 240, 241);
            pnlChildTitle.Location = new Point(0, 0);
            pnlChildTitle.Name = "pnlChildTitle";
            pnlChildTitle.Size = new Size(748, 28);
            pnlChildTitle.TabIndex = 0;
            // 
            // lblMasterData
            // 
            lblMasterData.AutoSize = true;
            lblMasterData.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMasterData.Location = new Point(12, 4);
            lblMasterData.Name = "lblMasterData";
            lblMasterData.Size = new Size(118, 20);
            lblMasterData.TabIndex = 0;
            lblMasterData.Text = "📊 Master Data";
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
            dtgMasterData.EnableHeadersVisualStyles = false;
            dtgMasterData.Location = new Point(0, 28);
            dtgMasterData.Name = "dtgMasterData";
            dtgMasterData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgMasterData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgMasterData.Size = new Size(748, 345);
            dtgMasterData.TabIndex = 1;
            dtgMasterData.CellContentClick += dtgMasterData_CellContentClick;
            // 
            // frmMasterData
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(748, 373);
            Controls.Add(dtgMasterData);
            Controls.Add(pnlChildTitle);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMasterData";
            Text = "Master Data";
            Load += frmMasterData_Load;
            pnlChildTitle.ResumeLayout(false);
            pnlChildTitle.PerformLayout();
            ((ISupportInitialize)dtgMasterData).EndInit();
            ResumeLayout(false);
        }

        private void lblMasterData_Click(object sender, EventArgs e)
        {

        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "SELECT * FROM tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dtgMasterData, select_tblrequestorlist);
        }

        private void dtgMasterData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
