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
            btnAddEmp = new Button();
            btnMasterData = new Button();
            panel1 = new Panel();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlStage = new Panel();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.BackColor = Color.FromArgb(43, 77, 95);
            pnlSideMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlSideMenu.Controls.Add(btnAddEmp);
            pnlSideMenu.Controls.Add(btnMasterData);
            pnlSideMenu.Controls.Add(panel1);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 51);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(220, 322);
            pnlSideMenu.TabIndex = 0;
            // 
            // btnAddEmp
            // 
            btnAddEmp.BackColor = Color.FromArgb(60, 173, 150);
            btnAddEmp.Cursor = Cursors.Hand;
            btnAddEmp.Dock = DockStyle.Top;
            btnAddEmp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmp.ForeColor = Color.White;
            btnAddEmp.Location = new Point(0, 46);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(218, 46);
            btnAddEmp.TabIndex = 3;
            btnAddEmp.Text = "➕ ADD EMPLOYEE";
            btnAddEmp.UseVisualStyleBackColor = false;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnMasterData
            // 
            btnMasterData.BackColor = Color.FromArgb(60, 173, 150);
            btnMasterData.Cursor = Cursors.Hand;
            btnMasterData.Dock = DockStyle.Top;
            btnMasterData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMasterData.ForeColor = Color.White;
            btnMasterData.Location = new Point(0, 0);
            btnMasterData.Name = "btnMasterData";
            btnMasterData.Size = new Size(218, 46);
            btnMasterData.TabIndex = 2;
            btnMasterData.Text = "📊 MASTER DATA";
            btnMasterData.UseVisualStyleBackColor = false;
            btnMasterData.Click += btnMasterData_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(226, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 59);
            panel1.TabIndex = 1;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(39, 58, 74);
            pnlTitleBar.BorderStyle = BorderStyle.FixedSingle;
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(748, 51);
            pnlTitleBar.TabIndex = 2;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(236, 240, 241);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(695, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "🗙";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(236, 240, 241);
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(651, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(38, 27);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(236, 240, 241);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(608, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 27);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "━";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlStage
            // 
            pnlStage.BackColor = Color.FromArgb(236, 240, 241);
            pnlStage.Dock = DockStyle.Fill;
            pnlStage.Location = new Point(220, 51);
            pnlStage.Name = "pnlStage";
            pnlStage.Size = new Size(528, 322);
            pnlStage.TabIndex = 3;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(748, 373);
            Controls.Add(pnlStage);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMotherForm";
            Text = "Employee Management System";
            Load += frmMotherForm_Load;
            pnlSideMenu.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
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
    }
}
