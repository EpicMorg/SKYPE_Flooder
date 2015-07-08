using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace skype_flooder_gui.UI
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            lbl_ver.Text =  AssemblyVersion;
        }

        private static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
        }


        private void btnGit_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/stamepicmorg/SKYPE_Flooder");
        }
    }
}