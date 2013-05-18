using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace skype_flooder_gui
{
    public partial class frm_warning : Form
    {
        public frm_warning()
        {
            InitializeComponent();
        }

        private void frm_warning_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();

        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
