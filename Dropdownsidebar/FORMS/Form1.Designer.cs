using Dropdownsidebar.CustomControls;

namespace Dropdownsidebar
{
    partial class Form1
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
            panel1 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentToolStripMenuItem = new ToolStripMenuItem();
            studentReportToolStripMenuItem = new ToolStripMenuItem();
            bookReportToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            panel5 = new Panel();
            exitIcon = new FontAwesome.Sharp.IconPictureBox();
            maxIcon = new FontAwesome.Sharp.IconPictureBox();
            miniIcon = new FontAwesome.Sharp.IconPictureBox();
            currentChildIcon = new FontAwesome.Sharp.IconPictureBox();
            titleOfChildForm = new Label();
            panel4 = new Panel();
            panelMenu = new Panel();
            libDropDown4 = new LibDropDown(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentChildIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 39, 60);
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 543);
            panel1.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(37, 39, 60);
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 35;
            iconButton4.Location = new Point(0, 280);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 0, 0);
            iconButton4.Size = new Size(150, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "REPORT";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(37, 39, 60);
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Person;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 35;
            iconButton3.Location = new Point(0, 220);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 0, 0);
            iconButton3.Size = new Size(150, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "STUDENT";
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(37, 39, 60);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.Location = new Point(0, 160);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 0, 0);
            iconButton2.Size = new Size(150, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "BOOK";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(37, 39, 60);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(0, 100);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(150, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Dashboard";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 100);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(37, 39, 60);
            iconPictureBox1.ForeColor = Color.Gainsboro;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            iconPictureBox1.IconColor = Color.Gainsboro;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(59, 60);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Image = Properties.Resources.bookicon;
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(124, 22);
            dashboardToolStripMenuItem.Text = "Issue";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Image = Properties.Resources.bookicon;
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(124, 22);
            returnToolStripMenuItem.Text = "Return";
            returnToolStripMenuItem.Click += returnToolStripMenuItem_Click;
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Image = Properties.Resources.studenticon;
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(196, 22);
            addNewStudentToolStripMenuItem.Text = "Add new student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // viewStudentToolStripMenuItem
            // 
            viewStudentToolStripMenuItem.Image = Properties.Resources.studenticon;
            viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            viewStudentToolStripMenuItem.Size = new Size(196, 22);
            viewStudentToolStripMenuItem.Text = "View student";
            viewStudentToolStripMenuItem.Click += viewStudentToolStripMenuItem_Click;
            // 
            // studentReportToolStripMenuItem
            // 
            studentReportToolStripMenuItem.BackColor = Color.Transparent;
            studentReportToolStripMenuItem.Image = Properties.Resources.reporticon;
            studentReportToolStripMenuItem.ImageTransparentColor = SystemColors.Control;
            studentReportToolStripMenuItem.Name = "studentReportToolStripMenuItem";
            studentReportToolStripMenuItem.Size = new Size(188, 22);
            studentReportToolStripMenuItem.Text = "Student Report";
            studentReportToolStripMenuItem.Click += studentReportToolStripMenuItem_Click;
            // 
            // bookReportToolStripMenuItem
            // 
            bookReportToolStripMenuItem.Image = Properties.Resources.reporticon;
            bookReportToolStripMenuItem.Name = "bookReportToolStripMenuItem";
            bookReportToolStripMenuItem.Size = new Size(188, 22);
            bookReportToolStripMenuItem.Text = "Book Report";
            bookReportToolStripMenuItem.Click += bookReportToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(37, 39, 60);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(currentChildIcon);
            panel3.Controls.Add(titleOfChildForm);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(150, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 50);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(exitIcon);
            panel5.Controls.Add(maxIcon);
            panel5.Controls.Add(miniIcon);
            panel5.Location = new Point(626, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(98, 32);
            panel5.TabIndex = 0;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.FromArgb(37, 39, 60);
            exitIcon.Cursor = Cursors.Hand;
            exitIcon.Dock = DockStyle.Left;
            exitIcon.ForeColor = Color.Gainsboro;
            exitIcon.IconChar = FontAwesome.Sharp.IconChar.X;
            exitIcon.IconColor = Color.Gainsboro;
            exitIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitIcon.IconSize = 30;
            exitIcon.Location = new Point(64, 0);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(32, 32);
            exitIcon.TabIndex = 2;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // maxIcon
            // 
            maxIcon.BackColor = Color.FromArgb(37, 39, 60);
            maxIcon.Cursor = Cursors.Hand;
            maxIcon.Dock = DockStyle.Left;
            maxIcon.ForeColor = Color.Gainsboro;
            maxIcon.IconChar = FontAwesome.Sharp.IconChar.Square;
            maxIcon.IconColor = Color.Gainsboro;
            maxIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maxIcon.IconSize = 30;
            maxIcon.Location = new Point(32, 0);
            maxIcon.Name = "maxIcon";
            maxIcon.Size = new Size(32, 32);
            maxIcon.TabIndex = 1;
            maxIcon.TabStop = false;
            maxIcon.Click += iconPictureBox3_Click;
            // 
            // miniIcon
            // 
            miniIcon.BackColor = Color.FromArgb(37, 39, 60);
            miniIcon.Cursor = Cursors.Hand;
            miniIcon.Dock = DockStyle.Left;
            miniIcon.ForeColor = Color.Gainsboro;
            miniIcon.IconChar = FontAwesome.Sharp.IconChar.Minus;
            miniIcon.IconColor = Color.Gainsboro;
            miniIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            miniIcon.IconSize = 30;
            miniIcon.Location = new Point(0, 0);
            miniIcon.Name = "miniIcon";
            miniIcon.Size = new Size(32, 32);
            miniIcon.TabIndex = 0;
            miniIcon.TabStop = false;
            miniIcon.Click += miniIcon_Click;
            // 
            // currentChildIcon
            // 
            currentChildIcon.BackColor = Color.Transparent;
            currentChildIcon.ForeColor = Color.Teal;
            currentChildIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            currentChildIcon.IconColor = Color.Teal;
            currentChildIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            currentChildIcon.Location = new Point(6, 12);
            currentChildIcon.Name = "currentChildIcon";
            currentChildIcon.Size = new Size(32, 32);
            currentChildIcon.TabIndex = 1;
            currentChildIcon.TabStop = false;
            // 
            // titleOfChildForm
            // 
            titleOfChildForm.AutoSize = true;
            titleOfChildForm.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleOfChildForm.ForeColor = Color.Gainsboro;
            titleOfChildForm.Location = new Point(44, 26);
            titleOfChildForm.Name = "titleOfChildForm";
            titleOfChildForm.Size = new Size(80, 18);
            titleOfChildForm.TabIndex = 0;
            titleOfChildForm.Text = "Directory";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(150, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 10);
            panel4.TabIndex = 4;
            // 
            // panelMenu
            // 
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(150, 60);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(727, 483);
            panelMenu.TabIndex = 5;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // libDropDown4
            // 
            libDropDown4.IsMainMenu = false;
            libDropDown4.MenuItemHeight = 25;
            libDropDown4.MenuItemTextColor = Color.Empty;
            libDropDown4.Name = "libDropDown4";
            libDropDown4.PrimaryColor = Color.Empty;
            libDropDown4.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 543);
            Controls.Add(panelMenu);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentChildIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private LibDropDown libDropDown1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private LibDropDown libDropDown2;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentToolStripMenuItem;
        private LibDropDown libDropDown3;
        private ToolStripMenuItem studentReportToolStripMenuItem;
        private ToolStripMenuItem bookReportToolStripMenuItem;
        private Panel panel3;
        private Panel panel4;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconPictureBox currentChildIcon;
        private Label titleOfChildForm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox exitIcon;
        private FontAwesome.Sharp.IconPictureBox maxIcon;
        private FontAwesome.Sharp.IconPictureBox miniIcon;
        private LibDropDown libDropDown4;
    }
}