using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using SKYPE4COMLib; 
using skype_flooder_gui.Resources;

namespace skype_flooder_gui.UI
{
    public partial class FrmMain : Form
    {
        private bool _attacking;
        private Thread thr;

        public FrmMain()
        {
            InitializeComponent();
            attach_handlers();
        }

        private bool Attacking
        {
            get { return _attacking; }
            set
            {
                if (value & !_attacking && (thr == null || !thr.IsAlive))
                    run_flooder();
                _attacking = value;
                btn_flooding.Text = value ? Strings.stop : Strings.flood;
            }
        }

        private void run_flooder()
        {
            (thr = new Thread(AttackProcess)).Start();
        }

        private void attach_handlers()
        {
            txt_flood_text.TextChanged +=
                (a, b) => { btn_flooding.Enabled = !string.IsNullOrEmpty(txt_flood_text.Text.Trim()); };
            list_users.SelectedIndexChanged +=
                (a, b) => { txt_target.Text = ((SkypeFriends) list_users.SelectedItem).SUser.Handle; };
            btn_flooding.Click += (a, b) => Attacking ^= true;
            comboStatus.Items.Add(Strings.online);
            comboStatus.Items.Add(Strings.away);
            comboStatus.Items.Add(Strings.red);
            comboStatus.Items.Add(Strings.invisible);
            comboStatus.SelectedIndex = 0;
            comboBoxSmiles.SelectedIndex = 0;
            brn_about.Click += (a, b) =>
            {
                new FrmAbout().ShowDialog();
                Load += on_load;
            };
        }

        private void on_load(object sender, EventArgs e)
        {
            try
            {
                Skype skype = new SkypeClass(); //skype
                skype.Attach(Convert.ToInt32(skype_protokol.Value), false);
                var r = new Regex(@"xmpp\:.*");
                foreach (var friend in skype.Friends.Cast<User>().Where(friend => !r.IsMatch(friend.Handle)))
                {
                    list_users.Items.Add(new SkypeFriends
                    {
                        SUser = friend
                    });
                }
            }
            catch
            {
                new FrmMessage().ShowDialog(); 
            }
        }

        private void AttackProcess()
        {
            var skype = new SkypeClass(); //skype 
           
            string target = "", message = "";
            int delay = 0, floodType = 0, protocol = 0;
            Invoke((Action) (() =>
            {
                target = txt_target.Text;
                message = txt_flood_text.Text;
                delay = Convert.ToInt32(nud_delay.Value)*1000;
                floodType = rb_infinite_messages.Checked ? 0 : rb_timeout_messages.Checked ? 1 : 2;
                protocol = Convert.ToInt32(skype_protokol.Value);
            }));
            if (message.Length == 0)
            {
                Invoke((Action) (() => Attacking = false));
                return;
            }
            skype.Attach(protocol, false);
            if (floodType == 2)
            {
                try
                {
                    skype.SendMessage(target, message);
                    Invoke((Action) (() => Attacking = false));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return;
            }
           
            while (Attacking)
            { 
                try
                {
                    skype.SendMessage(target, message); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                if (floodType == 1 && delay > 0)
                    Thread.Sleep(delay);
            }
        }

        private void btn_flooding_Click(object sender, EventArgs e)
        {
            if (!chk_status_flooding.Checked) return;
            var skype = new SkypeClass(); //skype 
            switch (comboStatus.SelectedIndex)
            {
                case 0:
                {
                    skype.CurrentUserStatus = TUserStatus.cusOnline;
                }
                    break;
                case 1:
                {
                    skype.CurrentUserStatus = TUserStatus.cusAway;
                }
                    break;
                case 2:
                {
                    skype.CurrentUserStatus = TUserStatus.cusDoNotDisturb;
                }
                    break;
                case 3:
                {
                    skype.CurrentUserStatus = TUserStatus.cusInvisible;
                }
                    break;
            }
        }

        private void chk_status_flooding_CheckedChanged(object sender, EventArgs e)
        {
            comboStatus.Enabled = chk_status_flooding.Checked;
        }

        
    }
}