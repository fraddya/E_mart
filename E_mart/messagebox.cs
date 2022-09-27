using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace E_mart
{
    public partial class messagebox : Form
    {
        private Color primaryColor = Color.CornflowerBlue;
        private int borderSize = 2;
        //Properties
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Form Border Color
                //this.panelTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }
        //Constructors
        public messagebox(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.mssgbox_content.Text = text;
            this.mssgbox_title.Text = "";
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public messagebox(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.mssgbox_content.Text = text;
            this.mssgbox_title.Text = caption;
            SetFormSize();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public messagebox(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.mssgbox_content.Text = text;
            this.mssgbox_title.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public messagebox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.mssgbox_content.Text = text;
            this.mssgbox_title.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public messagebox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.mssgbox_content.Text = text;
            this.mssgbox_title.Text = caption;
            SetFormSize();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }
        //-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);//Set border size
            this.mssgbox_content.MaximumSize = new Size(550, 0);
            this.mssgbox_btnclose.DialogResult = DialogResult.Cancel;
            this.mssgbox_btn1.DialogResult = DialogResult.OK;
            this.mssgbox_btn1.Visible = false;
            this.mssgbox_btn2.Visible = false;
            this.mssgbox_btn3.Visible = false;
        }
        private void SetFormSize()
        {
            
            //int widht = this.mssgbox_content.Width + this.mssgbox_icon.Width + this.panelBody.Padding.Left;
            //int height = this.panelTitleBar.Height + this.mssgbox_content.Height + this.panelButtons.Height + this.panelBody.Padding.Top;
            //this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.panelButtons.Width - mssgbox_btn1.Width) / 2;
            int yCenter = (this.panelButtons.Height - mssgbox_btn1.Height) / 2;
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    mssgbox_btn1.Visible = true;
                    mssgbox_btn1.Location = new Point(xCenter, yCenter);
                    mssgbox_btn1.Text = "Ok";
                    mssgbox_btn1.DialogResult = DialogResult.OK;//Set DialogResult
                                                           //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    mssgbox_btn1.Visible = true;
                    mssgbox_btn1.Location = new Point(xCenter - (mssgbox_btn1.Width / 2) - 5, yCenter);
                    mssgbox_btn1.Text = "Ok";
                    mssgbox_btn1.DialogResult = DialogResult.OK;//Set DialogResult
                                                                //Cancel Button
                    mssgbox_btn2.Visible = true;
                    mssgbox_btn2.Location = new Point(xCenter + (mssgbox_btn2.Width / 2) + 5, yCenter);
                    mssgbox_btn2.Text = "Cancel";
                    mssgbox_btn2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    mssgbox_btn2.BackColor = Color.DimGray;
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    mssgbox_btn1.Visible = true;
                    mssgbox_btn1.Location = new Point(xCenter - (mssgbox_btn1.Width / 2) - 5, yCenter);
                    mssgbox_btn1.Text = "Retry";
                    mssgbox_btn1.DialogResult = DialogResult.Retry;//Set DialogResult
                                                                   //Cancel Button
                    mssgbox_btn2.Visible = true;
                    mssgbox_btn2.Location = new Point(xCenter + (mssgbox_btn2.Width / 2) + 5, yCenter);
                    mssgbox_btn2.Text = "Cancel";
                    mssgbox_btn2.DialogResult = DialogResult.Cancel;//Set DialogResult
                    mssgbox_btn2.BackColor = Color.DimGray;
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNo:
                    //Yes Button
                    mssgbox_btn1.Visible = true;
                    mssgbox_btn1.Location = new Point(xCenter - (mssgbox_btn1.Width / 2) - 5, yCenter);
                    mssgbox_btn1.Text = "Yes";
                    mssgbox_btn1.DialogResult = DialogResult.Yes;//Set DialogResult
                                                                 //No Button
                    mssgbox_btn2.Visible = true;
                    mssgbox_btn2.Location = new Point(xCenter + (mssgbox_btn2.Width / 2) + 5, yCenter);
                    mssgbox_btn2.Text = "No";
                    mssgbox_btn2.DialogResult = DialogResult.No;//Set DialogResult
                    mssgbox_btn2.BackColor = Color.IndianRed;
                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    mssgbox_btn1.Visible = true;
                    mssgbox_btn1.Location = new Point(xCenter - mssgbox_btn1.Width - 5, yCenter);
                    mssgbox_btn1.Text = "Yes";
                    mssgbox_btn1.DialogResult = DialogResult.Yes;//Set DialogResult
                                                                 //No Button
                    mssgbox_btn2.Visible = true;
                    mssgbox_btn2.Location = new Point(xCenter, yCenter);
                    mssgbox_btn2.Text = "No";
                    mssgbox_btn2.DialogResult = DialogResult.No;//Set DialogResult
                    mssgbox_btn2.BackColor = Color.IndianRed;
                    //Cancel Button
                    mssgbox_btn3.Visible = true;
                    mssgbox_btn3.Location = new Point(xCenter + mssgbox_btn2.Width + 5, yCenter);
                    mssgbox_btn3.Text = "Cancel";
                    mssgbox_btn3.DialogResult = DialogResult.Cancel;//Set DialogResult
                    mssgbox_btn3.BackColor = Color.DimGray;
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    mssgbox_btn1.Visible = true;
                    mssgbox_btn1.Location = new Point(xCenter - mssgbox_btn1.Width - 5, yCenter);
                    mssgbox_btn1.Text = "Abort";
                    mssgbox_btn1.DialogResult = DialogResult.Abort;//Set DialogResult
                    mssgbox_btn1.BackColor = Color.Goldenrod;
                    //Retry Button
                    mssgbox_btn2.Visible = true;
                    mssgbox_btn2.Location = new Point(xCenter, yCenter);
                    mssgbox_btn2.Text = "Retry";
                    mssgbox_btn2.DialogResult = DialogResult.Retry;//Set DialogResult                    
                                                                   //Ignore Button
                    mssgbox_btn3.Visible = true;
                    mssgbox_btn3.Location = new Point(xCenter + mssgbox_btn2.Width + 5, yCenter);
                    mssgbox_btn3.Text = "Ignore";
                    mssgbox_btn3.DialogResult = DialogResult.Ignore;//Set DialogResult
                    mssgbox_btn3.BackColor = Color.IndianRed;
                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }

            //public messagebox()
            //{
              //  InitializeComponent();
            //}
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    mssgbox_btn1.Select();
                    mssgbox_btn1.ForeColor = Color.White;
                    mssgbox_btn1.Font = new Font(mssgbox_btn1.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    mssgbox_btn2.Select();
                    mssgbox_btn2.ForeColor = Color.White;
                    mssgbox_btn2.Font = new Font(mssgbox_btn2.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    mssgbox_btn3.Select();
                    mssgbox_btn3.ForeColor = Color.White;
                    mssgbox_btn3.Font = new Font(mssgbox_btn3.Font, FontStyle.Underline);
                    break;
            }
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.mssgbox_icon.Image = Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    this.mssgbox_btnclose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.mssgbox_icon.Image = Properties.Resources.information;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.mssgbox_icon.Image = Properties.Resources.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.mssgbox_icon.Image = Properties.Resources.exclamation;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.mssgbox_icon.Image = Properties.Resources.chat;
                    PrimaryColor = Color.CornflowerBlue;
                    break;
            }
        }
        //-> Events Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void messagebox_Load(object sender, EventArgs e)
        {

        }

        private void mssgbox_icon_Click(object sender, EventArgs e)
        {


        }
    }

    public abstract class FDDMessageBox
    {
        public static DialogResult Show(string text)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }

        /*-> IWin32Window Owner:
            *      Displays a message box in front of the specified object and with the other specified parameters.
            *      An implementation of IWin32Window that will own the modal dialog box.*/
        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption, buttons))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption, buttons, icon))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new messagebox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog(owner);
            return result;
        }
    }

}

