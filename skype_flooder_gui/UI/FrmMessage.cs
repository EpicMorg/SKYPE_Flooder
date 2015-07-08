using System;
using System.Media;
using System.Windows.Forms;

namespace skype_flooder_gui.UI
{
    public partial class FrmMessage : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        public FrmMessage()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void frm_warning_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}