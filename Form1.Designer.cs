namespace EmployeeManagementSystem
{
    partial class frmMotherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotherForm));
            pnlSideMenu = new Panel();
            lblFooter = new Label();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            panel1 = new Panel();
            pnlTitleBar = new Panel();
            pictureBox1 = new PictureBox();
            lblHeader = new Label();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            resources.ApplyResources(pnlSideMenu, "pnlSideMenu");
            pnlSideMenu.BackColor = Color.FromArgb(43, 77, 95);
            pnlSideMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlSideMenu.Controls.Add(lblFooter);
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Controls.Add(panel1);
            pnlSideMenu.Name = "pnlSideMenu";
            // 
            // lblFooter
            // 
            resources.ApplyResources(lblFooter, "lblFooter");
            lblFooter.BackColor = Color.Transparent;
            lblFooter.ForeColor = SystemColors.AppWorkspace;
            lblFooter.Name = "lblFooter";
            // 
            // btnAddEmp
            // 
            resources.ApplyResources(btnAddEmp, "btnAddEmp");
            btnAddEmp.BackColor = Color.FromArgb(60, 173, 150);
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            btnAddEmp.MouseEnter += btnAddEmp_MouseEnter;
            btnAddEmp.MouseLeave += btnAddEmp_MouseLeave;
            // 
            // btnMasterData
            // 
            resources.ApplyResources(btnMasterData, "btnMasterData");
            btnMasterData.BackColor = Color.FromArgb(60, 173, 150);
            btnMasterData.Cursor = Cursors.Hand;
            btnMasterData.ForeColor = Color.White;
            btnMasterData.Name = "btnMasterData";
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            btnMasterData.MouseEnter += btnMasterData_MouseEnter;
            btnMasterData.MouseLeave += btnMasterData_MouseLeave;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // pnlTitleBar
            // 
            resources.ApplyResources(pnlTitleBar, "pnlTitleBar");
            pnlTitleBar.BackColor = Color.FromArgb(39, 58, 74);
            pnlTitleBar.BorderStyle = BorderStyle.FixedSingle;
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Controls.Add(lblHeader);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_Click;
            // 
            // lblHeader
            // 
            resources.ApplyResources(lblHeader, "lblHeader");
            lblHeader.ForeColor = Color.White;
            lblHeader.Name = "lblHeader";
            lblHeader.MouseDown += lblHeader_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = Color.FromArgb(236, 240, 241);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Name = "btnClose";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnMaximize
            // 
            resources.ApplyResources(btnMaximize, "btnMaximize");
            btnMaximize.BackColor = Color.FromArgb(236, 240, 241);
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.BackColor = Color.FromArgb(236, 240, 241);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlStage
            // 
            resources.ApplyResources(pnlStage, "pnlStage");
            pnlStage.BackColor = Color.FromArgb(245, 246, 250);
            pnlStage.Name = "pnlStage";
            pnlStage.MouseEnter += pnlStage_MouseEnter;
            pnlStage.MouseLeave += pnlStage_MouseLeave;
            // 
            // frmMotherForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMotherForm";
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlSideMenu.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideMenu;
        private Panel panel1;
        private Panel pnlTitleBar;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMasterData;
        private Button btnAddEmp;
        private Panel pnlStage;
        private Label lblFooter;
        private Label lblHeader;
        private PictureBox pictureBox1;
    }
}
