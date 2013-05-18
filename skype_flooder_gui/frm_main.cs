using System;
using System.Windows.Forms;
using SKYPE4COMLib;
using System.Text.RegularExpressions;

namespace skype_flooder_gui
{
    public partial class frm_main : Form
    {
        private static readonly frm_main TheInstance = new frm_main(); 
        Skype skype = new SkypeClass();
         
        public frm_main()
        {
          InitializeComponent(); 
          int protocol = Convert.ToInt32(skype_protokol.Value);  //skype rotocol fix (dem to int)
          skype.Attach(protocol, false);  //skype.Attach(8, false);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
             
            try
            {
                Regex r = new Regex(@"xmpp\:.*");
                foreach (User friend in skype.Friends)
                {
                    if (!r.IsMatch(friend.Handle))
                        list_users.Items.Add(new skype_friends() { s_user = friend });
                }
            }
            catch
            {
                frm_warning frmwarning = new frm_warning();
                frmwarning.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_single_sending.Checked)
            {
                skype.SendMessage(txt_target.Text, txt_flood_text.Text);
                //beep
                txt_flood_text.Text = "";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_target.Text = ((skype_friends)list_users.SelectedItem).s_user.Handle;
        }

        private void chk_status_flooding_CheckedChanged(object sender, EventArgs e)
        {
            rb_fuckoff.Enabled = chk_status_flooding.Checked;
            rb_ghost.Enabled = chk_status_flooding.Checked;
            rb_nothere.Enabled = chk_status_flooding.Checked;
            rb_online.Enabled = chk_status_flooding.Checked;
        }

        private void txt_flood_text_TextChanged(object sender, EventArgs e)
        {
            if (txt_flood_text.Text == "" & rb_single_sending.Checked)
            {
                btn_flooding.Enabled = false;
            }
            else
            {
                btn_flooding.Enabled = true;
            }
        }

        private void brn_about_Click(object sender, EventArgs e)
        {
            frm_about frmabout = new frm_about();
            frmabout.ShowDialog();
        }
   
    }
}
