using Dropdownsidebar.FORMS;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Dropdownsidebar
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderBtn);

            Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void loadForm(object Form)
        {

            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(f);
            this.panelMenu.Tag = f;
            f.Show();
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                currentChildIcon.IconChar = currentBtn.IconChar;
                currentChildIcon.IconColor = color;
                titleOfChildForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            libDropDown1.Show(iconButton2, iconButton2.Width, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libDropDown1.IsMainMenu = false;
            libDropDown2.IsMainMenu = false;
            libDropDown3.IsMainMenu = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            libDropDown2.Show(iconButton3, iconButton3.Width, 0);


        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            libDropDown3.Show(iconButton4, iconButton4.Width, 0);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            loadForm(new Home());


        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new IssueBook());
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ReturnBook());
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new Add_Student());
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ViewStudent());
        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new StudentReport());
        }

        private void bookReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new BookReport());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildIcon.IconChar = IconChar.Home;
            currentChildIcon.IconColor = Color.SeaGreen;
            titleOfChildForm.Text = "Directory";

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void miniIcon_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}