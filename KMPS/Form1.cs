using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace KMPS
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftborderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftborderBtn = new Panel();
            leftborderBtn.Size = new Size(7, 60);
            pnlmenu.Controls.Add(leftborderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);

        }

        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn!=null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border Button
                leftborderBtn.BackColor = color;
                leftborderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftborderBtn.Visible = true;
                leftborderBtn.BringToFront();

                //Icon current child form
                iconcurrentchildform.IconChar = currentBtn.IconChar;
                iconcurrentchildform.IconColor = color;

            }
                
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblchildformname.Text = childForm.Text;


        }

        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormDashBoard());
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormErrorHandle());
        }

        private void BtnMenu3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormMPPDelete());
        }

        private void BtnMenu4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormMemberDelete());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
            //OpenChildForm(new Form1());
        }

        private void Reset()
        {
            DisableButton();
            leftborderBtn.Visible = false;

            iconcurrentchildform.IconChar = IconChar.Home;
            iconcurrentchildform.IconColor = Color.White;
            lblchildformname.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int IParam);
        private void pnltopmenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcurrentchildform_Click(object sender, EventArgs e)
        {

        }

        private void lblchildformname_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Sync());
        }
    }
}
