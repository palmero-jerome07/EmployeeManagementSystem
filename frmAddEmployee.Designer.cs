namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblHeader = new Label();
            label2 = new Label();
            gboxInsertUpdate = new GroupBox();
            btnDelete = new Button();
            btnSearch = new Button();
            btnInsertUpdate = new Button();
            cmbSection = new ComboBox();
            txtLocalNumber = new TextBox();
            txtEmailAddress = new TextBox();
            txtRequestorName = new TextBox();
            txtEmpID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            TTempNum = new ToolTip(components);
            TTreqName = new ToolTip(components);
            TTemailAdd = new ToolTip(components);
            TTlocalNum = new ToolTip(components);
            TTsection = new ToolTip(components);
            TTinsertUpdate = new ToolTip(components);
            TTsearch = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gboxInsertUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 77, 95);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblHeader);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 28);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(41, 4);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(108, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Add Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 1;
            // 
            // gboxInsertUpdate
            // 
            gboxInsertUpdate.BackColor = Color.FromArgb(236, 240, 250);
            gboxInsertUpdate.Controls.Add(btnDelete);
            gboxInsertUpdate.Controls.Add(btnSearch);
            gboxInsertUpdate.Controls.Add(btnInsertUpdate);
            gboxInsertUpdate.Controls.Add(cmbSection);
            gboxInsertUpdate.Controls.Add(txtLocalNumber);
            gboxInsertUpdate.Controls.Add(txtEmailAddress);
            gboxInsertUpdate.Controls.Add(txtRequestorName);
            gboxInsertUpdate.Controls.Add(txtEmpID);
            gboxInsertUpdate.Controls.Add(label7);
            gboxInsertUpdate.Controls.Add(label6);
            gboxInsertUpdate.Controls.Add(label5);
            gboxInsertUpdate.Controls.Add(label4);
            gboxInsertUpdate.Controls.Add(label3);
            gboxInsertUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gboxInsertUpdate.ForeColor = SystemColors.ActiveCaptionText;
            gboxInsertUpdate.Location = new Point(11, 50);
            gboxInsertUpdate.Name = "gboxInsertUpdate";
            gboxInsertUpdate.Size = new Size(524, 240);
            gboxInsertUpdate.TabIndex = 3;
            gboxInsertUpdate.TabStop = false;
            gboxInsertUpdate.Text = "Employee Details Manual Insert and Update";
            gboxInsertUpdate.Enter += groupBox1_Enter;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(60, 173, 150);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(251, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 24);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            TTinsertUpdate.SetToolTip(btnDelete, "Insert or update employee");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(60, 173, 150);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(418, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            TTsearch.SetToolTip(btnSearch, "Search employee");
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button2_Click;
            btnSearch.MouseEnter += button2_MouseEnter;
            btnSearch.MouseLeave += button2_MouseLeave;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = Color.FromArgb(60, 173, 150);
            btnInsertUpdate.FlatStyle = FlatStyle.Popup;
            btnInsertUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertUpdate.ForeColor = Color.White;
            btnInsertUpdate.Location = new Point(136, 185);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(109, 24);
            btnInsertUpdate.TabIndex = 10;
            btnInsertUpdate.Text = "INSERT/UPDATE";
            TTinsertUpdate.SetToolTip(btnInsertUpdate, "Insert or update employee");
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            btnInsertUpdate.MouseEnter += btnInsertUpdate_MouseEnter;
            btnInsertUpdate.MouseLeave += btnInsertUpdate_MouseLeave;
            // 
            // cmbSection
            // 
            cmbSection.AutoCompleteCustomSource.AddRange(new string[] { "IT", "CS", "EMC-DA", "CPE", "EE", "IE", "ECE" });
            cmbSection.DropDownStyle = ComboBoxStyle.Simple;
            cmbSection.FlatStyle = FlatStyle.Popup;
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "IT Dept.", "CS Dept.", "EMC-DA Dept.", "CPE Dept.", "EE Dept.", "IE Dept.", "ECE Dept." });
            cmbSection.Location = new Point(136, 156);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(109, 23);
            cmbSection.TabIndex = 9;
            TTsection.SetToolTip(cmbSection, "Select department");
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.BorderStyle = BorderStyle.FixedSingle;
            txtLocalNumber.Location = new Point(136, 125);
            txtLocalNumber.MaxLength = 4;
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(276, 23);
            txtLocalNumber.TabIndex = 8;
            TTlocalNum.SetToolTip(txtLocalNumber, "Input local number");
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAddress.Location = new Point(136, 96);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(328, 23);
            txtEmailAddress.TabIndex = 7;
            TTemailAdd.SetToolTip(txtEmailAddress, "Input email address");
            // 
            // txtRequestorName
            // 
            txtRequestorName.BorderStyle = BorderStyle.FixedSingle;
            txtRequestorName.Location = new Point(136, 67);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(328, 23);
            txtRequestorName.TabIndex = 6;
            TTreqName.SetToolTip(txtRequestorName, "Input requestor name");
            // 
            // txtEmpID
            // 
            txtEmpID.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEmpID.BorderStyle = BorderStyle.FixedSingle;
            txtEmpID.Location = new Point(136, 37);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(276, 23);
            txtEmpID.TabIndex = 5;
            TTempNum.SetToolTip(txtEmpID, "Input Employee Number");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 160);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 4;
            label7.Text = "Section :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 129);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 3;
            label6.Text = "Local Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 99);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 2;
            label5.Text = "Email Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 70);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 1;
            label4.Text = "Requestor Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 40);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 0;
            label3.Text = "Employee Number :";
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(1500, 0);
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(748, 373);
            Controls.Add(gboxInsertUpdate);
            Controls.Add(label2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmAddEmployee";
            Text = "Add Employee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gboxInsertUpdate.ResumeLayout(false);
            gboxInsertUpdate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeader;
        private Label label2;
        private GroupBox gboxInsertUpdate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSearch;
        private Button btnInsertUpdate;
        private ComboBox cmbSection;
        private TextBox txtLocalNumber;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        private TextBox txtEmpID;
        private ToolTip TTempNum;
        private ToolTip TTreqName;
        private ToolTip TTemailAdd;
        private ToolTip TTlocalNum;
        private ToolTip TTsection;
        private ToolTip TTinsertUpdate;
        private ToolTip TTsearch;
        private PictureBox pictureBox1;
        private Button btnDelete;
    }
}