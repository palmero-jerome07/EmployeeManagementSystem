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
            pnlSideMenu = new Panel();
            panel1 = new Panel();
            pnlTitleBar = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            pnlSideMenu.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideMenu
            // 
            pnlSideMenu.Controls.Add(panel1);
            pnlSideMenu.Dock = DockStyle.Left;
            pnlSideMenu.Location = new Point(0, 51);
            pnlSideMenu.Name = "pnlSideMenu";
            pnlSideMenu.Size = new Size(220, 446);
            pnlSideMenu.TabIndex = 0;
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
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMaximize);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(828, 51);
            pnlTitleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(782, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 27);
            btnClose.TabIndex = 2;
            btnClose.Text = "🗙";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaximize.Location = new Point(742, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(34, 27);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "🗖";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(702, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 27);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "━";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // frmMotherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 497);
            Controls.Add(pnlSideMenu);
            Controls.Add(pnlTitleBar);
            Name = "frmMotherForm";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
