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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotherForm));
            pnlSideMenu = new Panel();
            lblFooter = new Label();
            btnAddEmp = new Button();
            btnMasterData = new Button();
            panel1 = new Panel();
            pnlInformation = new Panel();
            lblAge = new Label();
            lblSection = new Label();
            lblFullName = new Label();
            pnlTitleBar = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblHeader = new Label();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            lblWelcome = new Label();
            TTminimize = new ToolTip(components);
            TTmaximize = new ToolTip(components);
            TTclose = new ToolTip(components);
            TTmasterData = new ToolTip(components);
            TTinsertUpdateEmployee = new ToolTip(components);
            TTversion = new ToolTip(components);
            TTfooter = new ToolTip(components);
            pnlSideMenu.SuspendLayout();
            pnlInformation.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlStage.SuspendLayout();
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
            pnlSideMenu.Controls.Add(pnlInformation);
            pnlSideMenu.Name = "pnlSideMenu";
            TTclose.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip"));
            TTmasterData.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip2"));
            TTfooter.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip3"));
            TTminimize.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip4"));
            TTversion.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip5"));
            TTmaximize.SetToolTip(pnlSideMenu, resources.GetString("pnlSideMenu.ToolTip6"));
            // 
            // lblFooter
            // 
            resources.ApplyResources(lblFooter, "lblFooter");
            lblFooter.BackColor = Color.Transparent;
            lblFooter.ForeColor = SystemColors.AppWorkspace;
            lblFooter.Name = "lblFooter";
            TTmasterData.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip"));
            TTminimize.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip1"));
            TTmaximize.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip2"));
            TTversion.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip3"));
            TTclose.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip4"));
            TTfooter.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(lblFooter, resources.GetString("lblFooter.ToolTip6"));
            lblFooter.Click += lblFooter_Click;
            // 
            // btnAddEmp
            // 
            resources.ApplyResources(btnAddEmp, "btnAddEmp");
            btnAddEmp.BackColor = Color.FromArgb(60, 173, 150);
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Name = "btnAddEmp";
            TTminimize.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip"));
            TTmaximize.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip1"));
            TTversion.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip2"));
            TTclose.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip3"));
            TTmasterData.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip4"));
            TTfooter.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(btnAddEmp, resources.GetString("btnAddEmp.ToolTip6"));
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
            TTminimize.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip"));
            TTmaximize.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip1"));
            TTversion.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip2"));
            TTclose.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip3"));
            TTmasterData.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip4"));
            TTfooter.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(btnMasterData, resources.GetString("btnMasterData.ToolTip6"));
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            btnMasterData.MouseEnter += btnMasterData_MouseEnter;
            btnMasterData.MouseLeave += btnMasterData_MouseLeave;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            TTclose.SetToolTip(panel1, resources.GetString("panel1.ToolTip"));
            TTmasterData.SetToolTip(panel1, resources.GetString("panel1.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(panel1, resources.GetString("panel1.ToolTip2"));
            TTfooter.SetToolTip(panel1, resources.GetString("panel1.ToolTip3"));
            TTminimize.SetToolTip(panel1, resources.GetString("panel1.ToolTip4"));
            TTversion.SetToolTip(panel1, resources.GetString("panel1.ToolTip5"));
            TTmaximize.SetToolTip(panel1, resources.GetString("panel1.ToolTip6"));
            // 
            // pnlInformation
            // 
            resources.ApplyResources(pnlInformation, "pnlInformation");
            pnlInformation.BackColor = Color.FromArgb(43, 77, 95);
            pnlInformation.Controls.Add(lblAge);
            pnlInformation.Controls.Add(lblSection);
            pnlInformation.Controls.Add(lblFullName);
            pnlInformation.Name = "pnlInformation";
            TTclose.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip"));
            TTmasterData.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip2"));
            TTfooter.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip3"));
            TTminimize.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip4"));
            TTversion.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip5"));
            TTmaximize.SetToolTip(pnlInformation, resources.GetString("pnlInformation.ToolTip6"));
            // 
            // lblAge
            // 
            resources.ApplyResources(lblAge, "lblAge");
            lblAge.ForeColor = Color.White;
            lblAge.Name = "lblAge";
            TTmasterData.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip"));
            TTminimize.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip1"));
            TTmaximize.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip2"));
            TTversion.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip3"));
            TTclose.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip4"));
            TTfooter.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(lblAge, resources.GetString("lblAge.ToolTip6"));
            // 
            // lblSection
            // 
            resources.ApplyResources(lblSection, "lblSection");
            lblSection.AutoEllipsis = true;
            lblSection.ForeColor = Color.White;
            lblSection.Name = "lblSection";
            TTmasterData.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip"));
            TTminimize.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip1"));
            TTmaximize.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip2"));
            TTversion.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip3"));
            TTclose.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip4"));
            TTfooter.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(lblSection, resources.GetString("lblSection.ToolTip6"));
            // 
            // lblFullName
            // 
            resources.ApplyResources(lblFullName, "lblFullName");
            lblFullName.AutoEllipsis = true;
            lblFullName.ForeColor = Color.White;
            lblFullName.Name = "lblFullName";
            TTmasterData.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip"));
            TTminimize.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip1"));
            TTmaximize.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip2"));
            TTversion.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip3"));
            TTclose.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip4"));
            TTfooter.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(lblFullName, resources.GetString("lblFullName.ToolTip6"));
            // 
            // pnlTitleBar
            // 
            resources.ApplyResources(pnlTitleBar, "pnlTitleBar");
            pnlTitleBar.BackColor = Color.FromArgb(39, 58, 74);
            pnlTitleBar.BorderStyle = BorderStyle.FixedSingle;
            pnlTitleBar.Controls.Add(label1);
            pnlTitleBar.Controls.Add(pictureBox1);
            pnlTitleBar.Controls.Add(lblHeader);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Name = "pnlTitleBar";
            TTclose.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip"));
            TTmasterData.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip2"));
            TTfooter.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip3"));
            TTminimize.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip4"));
            TTversion.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip5"));
            TTmaximize.SetToolTip(pnlTitleBar, resources.GetString("pnlTitleBar.ToolTip6"));
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Help;
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Name = "label1";
            TTmasterData.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            TTminimize.SetToolTip(label1, resources.GetString("label1.ToolTip1"));
            TTmaximize.SetToolTip(label1, resources.GetString("label1.ToolTip2"));
            TTversion.SetToolTip(label1, resources.GetString("label1.ToolTip3"));
            TTclose.SetToolTip(label1, resources.GetString("label1.ToolTip4"));
            TTfooter.SetToolTip(label1, resources.GetString("label1.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(label1, resources.GetString("label1.ToolTip6"));
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            TTclose.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            TTmasterData.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip1"));
            TTminimize.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip2"));
            TTmaximize.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip3"));
            TTversion.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip4"));
            TTfooter.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(pictureBox1, resources.GetString("pictureBox1.ToolTip6"));
            pictureBox1.MouseDown += pictureBox1_Click;
            // 
            // lblHeader
            // 
            resources.ApplyResources(lblHeader, "lblHeader");
            lblHeader.ForeColor = Color.White;
            lblHeader.Name = "lblHeader";
            TTmasterData.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip"));
            TTminimize.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip1"));
            TTmaximize.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip2"));
            TTversion.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip3"));
            TTclose.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip4"));
            TTfooter.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(lblHeader, resources.GetString("lblHeader.ToolTip6"));
            lblHeader.MouseDown += LblHeader_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Name = "btnClose";
            TTminimize.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip"));
            TTmaximize.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip1"));
            TTversion.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip2"));
            TTclose.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip3"));
            TTmasterData.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip4"));
            TTfooter.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(btnClose, resources.GetString("btnClose.ToolTip6"));
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnMaximize
            // 
            resources.ApplyResources(btnMaximize, "btnMaximize");
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.Name = "btnMaximize";
            TTminimize.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip"));
            TTmaximize.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip1"));
            TTversion.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip2"));
            TTclose.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip3"));
            TTmasterData.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip4"));
            TTfooter.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(btnMaximize, resources.GetString("btnMaximize.ToolTip6"));
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnMinimize
            // 
            resources.ApplyResources(btnMinimize, "btnMinimize");
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.Name = "btnMinimize";
            TTminimize.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip"));
            TTmaximize.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip1"));
            TTversion.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip2"));
            TTclose.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip3"));
            TTmasterData.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip4"));
            TTfooter.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(btnMinimize, resources.GetString("btnMinimize.ToolTip6"));
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // pnlStage
            // 
            resources.ApplyResources(pnlStage, "pnlStage");
            pnlStage.BackColor = Color.FromArgb(245, 246, 250);
            pnlStage.Controls.Add(lblWelcome);
            pnlStage.Name = "pnlStage";
            TTclose.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip"));
            TTmasterData.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip1"));
            TTinsertUpdateEmployee.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip2"));
            TTfooter.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip3"));
            TTminimize.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip4"));
            TTversion.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip5"));
            TTmaximize.SetToolTip(pnlStage, resources.GetString("pnlStage.ToolTip6"));
            pnlStage.MouseEnter += pnlStage_MouseEnter;
            pnlStage.MouseLeave += pnlStage_MouseLeave;
            // 
            // lblWelcome
            // 
            resources.ApplyResources(lblWelcome, "lblWelcome");
            lblWelcome.ForeColor = Color.FromArgb(43, 77, 95);
            lblWelcome.Name = "lblWelcome";
            TTmasterData.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip"));
            TTminimize.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip1"));
            TTmaximize.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip2"));
            TTversion.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip3"));
            TTclose.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip4"));
            TTfooter.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip5"));
            TTinsertUpdateEmployee.SetToolTip(lblWelcome, resources.GetString("lblWelcome.ToolTip6"));
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
            TTfooter.SetToolTip(this, resources.GetString("$this.ToolTip"));
            TTinsertUpdateEmployee.SetToolTip(this, resources.GetString("$this.ToolTip1"));
            TTversion.SetToolTip(this, resources.GetString("$this.ToolTip2"));
            TTclose.SetToolTip(this, resources.GetString("$this.ToolTip3"));
            TTmasterData.SetToolTip(this, resources.GetString("$this.ToolTip4"));
            TTmaximize.SetToolTip(this, resources.GetString("$this.ToolTip5"));
            TTminimize.SetToolTip(this, resources.GetString("$this.ToolTip6"));
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlSideMenu.PerformLayout();
            pnlInformation.ResumeLayout(false);
            pnlInformation.PerformLayout();
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlStage.ResumeLayout(false);
            pnlStage.PerformLayout();
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
        private Label label1;
        private ToolTip TTminimize;
        private ToolTip TTmaximize;
        private ToolTip TTclose;
        private ToolTip TTmasterData;
        private ToolTip TTinsertUpdateEmployee;
        private ToolTip TTversion;
        private ToolTip TTfooter;
        private Panel pnlInformation;
        private Label lblAge;
        private Label lblSection;
        private Label lblFullName;
        private Label lblWelcome;
    }
}
