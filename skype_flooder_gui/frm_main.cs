using System;
using System.Windows.Forms;
using SKYPE4COMLib;
using System.Text.RegularExpressions;
using System.Threading;
namespace skype_flooder_gui {
	public partial class frm_main : Form {
		Skype skype = new SkypeClass();
		Thread thr;
		bool skype_attached = false;
		private bool _attacking;
		public bool Attacking {
			get {
				return _attacking;
			}
			set {
				if ( value & !_attacking && !thr.IsAlive)
					this.thr.Start();
				_attacking = value;
				btn_flooding.Text = !value ? "Stop" : "Flood!";
			}
		}
		
		public frm_main() {
			//int protocol = Convert.ToInt32( skype_protokol.Value );
			//skype.Attach( protocol, false );
			this.thr=new Thread( new ThreadStart( AttackProcess ) );
			InitializeComponent();
		}
		private void on_load( object sender, EventArgs e ) {
			try {
				Regex r = new Regex( @"xmpp\:.*" );
				foreach ( User friend in skype.Friends ) {
					if ( !r.IsMatch( friend.Handle ) )
						list_users.Items.Add( new skype_friends() {
							s_user = friend
						} );
				}
			}
			catch {
				new frm_warning().ShowDialog();
			}
		}
		private void run_stop_attack( object sender, EventArgs e ) {
			this.Attacking ^= true;
		}
		void attach_skype() {
			if ( !this.skype_attached ) {
				skype.Attach( Convert.ToInt32( skype_protokol.Value ), false );
				skype_attached = true;
			}
		}
		private void AttackProcess(){
			string target="", message="";
			int delay = 0, flood_type = 0;
			this.Invoke((Action)(()=>{
				target = this.txt_target.Text;
				message = txt_flood_text.Text;
				delay = Convert.ToInt32( this.nud_delay.Value );
				flood_type = this.rb_infinite_messages.Checked ? 0 : this.rb_timeout_messages.Checked ? 1 : 2;
			}));
			attach_skype();
			if ( flood_type == 2 ) {
				try {
					this.skype.SendMessage( target, message );
					this.Invoke( (Action)( () => Attacking = false ) );
				}
				catch {
				}
				return;
			}
			while ( this.Attacking ) {
				this.skype.SendMessage( target, message );
				if ( flood_type == 1 )
					Thread.Sleep( delay );
			}
		}
	}
}
