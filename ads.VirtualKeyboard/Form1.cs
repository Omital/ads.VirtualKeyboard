using System;
using System.Windows.Forms;

namespace ads.VirtualKeyboard
{
    public partial class Form1 : Form
    {


        private const int WS_EX_TOOLWINDOW = 0x00000080;
        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int WS_EX_TOPMOST = 0x00000008;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= (WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST);
                cp.Parent = IntPtr.Zero; // Keep this line only if you used UserControl
                cp.X = this.Location.X;
                cp.Y = this.Location.Y;
                return cp;

                //return base.CreateParams;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{" + (sender as Button).Tag.ToString() + "}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
