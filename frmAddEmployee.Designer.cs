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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 77, 95);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(236, 240, 241);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 28);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "➕ Add Employee";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnInsertUpdate);
            groupBox1.Controls.Add(cmbSection);
            groupBox1.Controls.Add(txtLocalNumber);
            groupBox1.Controls.Add(txtEmailAddress);
            groupBox1.Controls.Add(txtRequestorName);
            groupBox1.Controls.Add(txtEmpID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 226);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Details Manual Insert and Update";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(60, 173, 150);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(418, 37);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 11;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnInsertUpdate
            // 
            btnInsertUpdate.BackColor = Color.FromArgb(60, 173, 150);
            btnInsertUpdate.FlatStyle = FlatStyle.Popup;
            btnInsertUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertUpdate.ForeColor = Color.White;
            btnInsertUpdate.Location = new Point(136, 185);
            btnInsertUpdate.Name = "btnInsertUpdate";
            btnInsertUpdate.Size = new Size(109, 28);
            btnInsertUpdate.TabIndex = 10;
            btnInsertUpdate.Text = "INSERT/UPDATE";
            btnInsertUpdate.UseVisualStyleBackColor = false;
            btnInsertUpdate.Click += btnInsertUpdate_Click;
            // 
            // cmbSection
            // 
            cmbSection.AutoCompleteCustomSource.AddRange(new string[] { "IT", "CS", "EMC-DA", "CPE", "EE", "IE", "ECE" });
            cmbSection.FormattingEnabled = true;
            cmbSection.Items.AddRange(new object[] { "IT", "CS", "EMC-DA", "CPE", "EE", "IE", "ECE" });
            cmbSection.Location = new Point(136, 156);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(276, 23);
            cmbSection.TabIndex = 9;
            // 
            // txtLocalNumber
            // 
            txtLocalNumber.Location = new Point(136, 125);
            txtLocalNumber.Name = "txtLocalNumber";
            txtLocalNumber.Size = new Size(276, 23);
            txtLocalNumber.TabIndex = 8;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(136, 96);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(452, 23);
            txtEmailAddress.TabIndex = 7;
            // 
            // txtRequestorName
            // 
            txtRequestorName.Location = new Point(136, 67);
            txtRequestorName.Name = "txtRequestorName";
            txtRequestorName.Size = new Size(452, 23);
            txtRequestorName.TabIndex = 6;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(136, 37);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(276, 23);
            txtEmpID.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 160);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
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
            BackColor = Color.Linen;
            ClientSize = new Size(748, 373);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddEmployee";
            Text = "Add Employee";
            Load += frmAddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button btnInsertUpdate;
        private ComboBox cmbSection;
        private TextBox txtLocalNumber;
        private TextBox txtEmailAddress;
        private TextBox txtRequestorName;
        private TextBox txtEmpID;
    }
}