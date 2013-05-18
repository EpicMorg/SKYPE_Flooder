using System;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace skype_flooder_gui
{
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
            lbl_ver.Text = String.Format("Version {0}", AssemblyVersion);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {

        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/stamepicmorg/SKYPE_Flooder");
        }
    }
}
