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

            Regex r = new Regex(@"xmpp\:.*");
            foreach (User friend in skype.Friends)
            {
if (!r.IsMatch(friend.Handle))
                listBox1.Items.Add(new skype_friends() { s_user = friend });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skype.SendMessage(txt_target.Text, txt_flood_text.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_target.Text = ((skype_friends)listBox1.SelectedItem).s_user.Handle;
        }

    }
}
