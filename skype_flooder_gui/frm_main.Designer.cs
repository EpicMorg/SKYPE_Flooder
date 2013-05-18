using System.ComponentModel;
using System.Windows.Forms;
namespace skype_flooder_gui {
	partial class frm_main {
		private IContainer components = null;
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) )
				components.Dispose();
			base.Dispose( disposing );
		}
		private void InitializeComponent() {
			ComponentResourceManager resources = new ComponentResourceManager( typeof( frm_main ) );
			txt_flood_text = new TextBox() {
				Location = new System.Drawing.Point( 12, 342 ),
				Multiline = true,
				Name = "txt_flood_text",
				Size = new System.Drawing.Size( 588, 149 ),
				TabIndex = 0
			};
			btn_flooding = new Button() {
				Location = new System.Drawing.Point( 525, 497 ),
				Name = "btn_flooding",
				Size = new System.Drawing.Size( 75, 23 ),
				TabIndex = 0,
				Text = "FLOOD",
				UseVisualStyleBackColor = true
			};
			skype_protokol = new NumericUpDown() {
				Location = new System.Drawing.Point( 114, 163 ),
				Maximum = 8M,
				Minimum = 5M,
				Name = "skype_protokol",
				Size = new System.Drawing.Size( 174, 20 ),
				TabIndex = 2,
				Value = 8M
			};
			gbx_settings = new GroupBox() {
				Location = new System.Drawing.Point( 15, 189 ),
				Name = "gbx_settings",
				Size = new System.Drawing.Size( 273, 147 ),
				TabIndex = 8,
				TabStop = false,
				Text = "Settings"
			};
			lbl_protocol = new Label() {
				AutoSize = true,
				Location = new System.Drawing.Point( 12, 165 ),
				Name = "lbl_protocol",
				Size = new System.Drawing.Size( 81, 13 ),
				TabIndex = 3,
				Text = "Skype protocol:"
			};
			lbl_user = new Label() {
				AutoSize = true,
				Location = new System.Drawing.Point( 12, 140 ),
				Name = "lbl_user",
				Size = new System.Drawing.Size( 96, 13 ),
				TabIndex = 4,
				Text = "Target user\'s login:"
			};
			txt_target = new TextBox() {
				Location = new System.Drawing.Point( 114, 137 ),
				Name = "txt_target",
				Size = new System.Drawing.Size( 174, 20 ),
				TabIndex = 5,
				Text = "kasthack",
			};
			list_users = new ListBox() {
				Anchor = (AnchorStyles)( AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right ),
				FormattingEnabled = true,
				Location = new System.Drawing.Point( 294, 137 ),
				Name = "list_users",
				ScrollAlwaysVisible = true,
				Size = new System.Drawing.Size( 306, 199 ),
				Sorted = true,
				TabIndex = 6,
			};
			rb_infinite_messages = new RadioButton();
			pic_ghost = new PictureBox();
			rb_ghost = new RadioButton();
			pic_fuckoff = new PictureBox();
			rb_fuckoff = new RadioButton();
			pic_nothere = new PictureBox();
			rb_nothere = new RadioButton();
			pic_online = new PictureBox();
			rb_online = new RadioButton();
			chk_status_flooding = new CheckBox();
			nud_delay = new NumericUpDown();
			rb_timeout_messages = new RadioButton();
			rb_single_sending = new RadioButton();
			pic_logo = new PictureBox();
			brn_about = new Button();

			SuspendLayout();
			gbx_settings.SuspendLayout();
			( (ISupportInitialize)( skype_protokol ) ).BeginInit();
			( (ISupportInitialize)( pic_ghost ) ).BeginInit();
			( (ISupportInitialize)( pic_fuckoff ) ).BeginInit();
			( (ISupportInitialize)( pic_nothere ) ).BeginInit();
			( (ISupportInitialize)( pic_online ) ).BeginInit();
			( (ISupportInitialize)( nud_delay ) ).BeginInit();
			( (ISupportInitialize)( pic_logo ) ).BeginInit();

			txt_flood_text.TextChanged += ( a, b ) => {btn_flooding.Enabled = !( txt_flood_text.Text == "" & rb_single_sending.Checked );};
			list_users.SelectedIndexChanged += ( a, b ) => {txt_target.Text = ( (skype_friends)list_users.SelectedItem ).s_user.Handle;};
			btn_flooding.Click += new System.EventHandler( run_stop_attack );
			chk_status_flooding.CheckedChanged += ( a, b ) => {rb_fuckoff.Enabled = rb_ghost.Enabled = rb_nothere.Enabled = rb_online.Enabled = chk_status_flooding.Checked;};
			brn_about.Click += ( a, b ) => { new frm_about().ShowDialog(); };
			Load += on_load ;

			gbx_settings.Controls.AddRange(
				new Control[]
				{
					pic_ghost,rb_ghost,pic_fuckoff,rb_fuckoff,pic_nothere,
					rb_nothere,pic_online,rb_online,chk_status_flooding,nud_delay,
					rb_timeout_messages,rb_single_sending
				} );
			gbx_settings.Controls.Add( rb_infinite_messages );
			rb_infinite_messages.AutoSize = true;
			rb_infinite_messages.Location = new System.Drawing.Point( 24, 42 );
			rb_infinite_messages.Name = "rb_infinite_messages";
			rb_infinite_messages.Size = new System.Drawing.Size( 146, 17 );
			rb_infinite_messages.TabIndex = 11;
			rb_infinite_messages.Text = "Infinite sending messages";
			rb_infinite_messages.UseVisualStyleBackColor = true;
			pic_ghost.Enabled = false;
			pic_ghost.Image = global::skype_flooder_gui.Properties.Resources._916;
			pic_ghost.Location = new System.Drawing.Point( 163, 126 );
			pic_ghost.Name = "pic_ghost";
			pic_ghost.Size = new System.Drawing.Size( 16, 16 );
			pic_ghost.SizeMode = PictureBoxSizeMode.AutoSize;
			pic_ghost.TabIndex = 10;
			pic_ghost.TabStop = false;
			rb_ghost.AutoSize = true;
			rb_ghost.Enabled = false;
			rb_ghost.Location = new System.Drawing.Point( 165, 108 );
			rb_ghost.Name = "rb_ghost";
			rb_ghost.Size = new System.Drawing.Size( 14, 13 );
			rb_ghost.TabIndex = 9;
			rb_ghost.UseVisualStyleBackColor = true;
			pic_fuckoff.Enabled = false;
			pic_fuckoff.Image = global::skype_flooder_gui.Properties.Resources._914_001;
			pic_fuckoff.Location = new System.Drawing.Point( 131, 126 );
			pic_fuckoff.Name = "pic_fuckoff";
			pic_fuckoff.Size = new System.Drawing.Size( 16, 16 );
			pic_fuckoff.SizeMode = PictureBoxSizeMode.AutoSize;
			pic_fuckoff.TabIndex = 8;
			pic_fuckoff.TabStop = false;
			rb_fuckoff.AutoSize = true;
			rb_fuckoff.Enabled = false;
			rb_fuckoff.Location = new System.Drawing.Point( 133, 108 );
			rb_fuckoff.Name = "rb_fuckoff";
			rb_fuckoff.Size = new System.Drawing.Size( 14, 13 );
			rb_fuckoff.TabIndex = 7;
			rb_fuckoff.UseVisualStyleBackColor = true;
			pic_nothere.Enabled = false;
			pic_nothere.Image = global::skype_flooder_gui.Properties.Resources._913_001;
			pic_nothere.Location = new System.Drawing.Point( 97, 126 );
			pic_nothere.Name = "pic_nothere";
			pic_nothere.Size = new System.Drawing.Size( 16, 16 );
			pic_nothere.SizeMode = PictureBoxSizeMode.AutoSize;
			pic_nothere.TabIndex = 6;
			pic_nothere.TabStop = false;
			rb_nothere.AutoSize = true;
			rb_nothere.Enabled = false;
			rb_nothere.Location = new System.Drawing.Point( 99, 108 );
			rb_nothere.Name = "rb_nothere";
			rb_nothere.Size = new System.Drawing.Size( 14, 13 );
			rb_nothere.TabIndex = 5;
			rb_nothere.UseVisualStyleBackColor = true;
			pic_online.Enabled = false;
			pic_online.Image = global::skype_flooder_gui.Properties.Resources._912_001;
			pic_online.Location = new System.Drawing.Point( 61, 126 );
			pic_online.Name = "pic_online";
			pic_online.Size = new System.Drawing.Size( 16, 16 );
			pic_online.SizeMode = PictureBoxSizeMode.AutoSize;
			pic_online.TabIndex = 4;
			pic_online.TabStop = false;
			rb_online.AutoSize = true;
			rb_online.Enabled = false;
			rb_online.Location = new System.Drawing.Point( 64, 108 );
			rb_online.Name = "rb_online";
			rb_online.Size = new System.Drawing.Size( 14, 13 );
			rb_online.TabIndex = 3;
			rb_online.UseVisualStyleBackColor = true;
			chk_status_flooding.AutoSize = true;
			chk_status_flooding.Location = new System.Drawing.Point( 24, 91 );
			chk_status_flooding.Name = "chk_status_flooding";
			chk_status_flooding.Size = new System.Drawing.Size( 197, 17 );
			chk_status_flooding.TabIndex = 2;
			chk_status_flooding.Text = "Change skype status when flooding:";
			chk_status_flooding.UseVisualStyleBackColor = true;
			nud_delay.Location = new System.Drawing.Point( 153, 65 );
			nud_delay.Name = "numericUpDown1";
			nud_delay.Size = new System.Drawing.Size( 97, 20 );
			nud_delay.TabIndex = 1;
			rb_timeout_messages.AutoSize = true;
			rb_timeout_messages.Location = new System.Drawing.Point( 24, 65 );
			rb_timeout_messages.Name = "rb_timeout_messages";
			rb_timeout_messages.Size = new System.Drawing.Size( 123, 17 );
			rb_timeout_messages.TabIndex = 0;
			rb_timeout_messages.Text = "Sending with timeout";
			rb_timeout_messages.UseVisualStyleBackColor = true;
			rb_single_sending.AutoSize = true;
			rb_single_sending.Checked = true;
			rb_single_sending.Location = new System.Drawing.Point( 24, 19 );
			rb_single_sending.Name = "rb_single_sending";
			rb_single_sending.Size = new System.Drawing.Size( 104, 17 );
			rb_single_sending.TabIndex = 0;
			rb_single_sending.TabStop = true;
			rb_single_sending.Text = "Single messages";
			rb_single_sending.UseVisualStyleBackColor = true;
			pic_logo.BackgroundImage = global::skype_flooder_gui.Properties.Resources.LOGO;
			pic_logo.BackgroundImageLayout = ImageLayout.Center;
			pic_logo.Dock = DockStyle.Top;
			pic_logo.Location = new System.Drawing.Point( 0, 0 );
			pic_logo.Name = "pic_logo";
			pic_logo.Size = new System.Drawing.Size( 612, 131 );
			pic_logo.SizeMode = PictureBoxSizeMode.AutoSize;
			pic_logo.TabIndex = 7;
			pic_logo.TabStop = false;
			brn_about.Location = new System.Drawing.Point( 12, 497 );
			brn_about.Name = "brn_about";
			brn_about.Size = new System.Drawing.Size( 75, 23 );
			brn_about.TabIndex = 9;
			brn_about.Text = "About";
			brn_about.UseVisualStyleBackColor = true;
			AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size( 612, 532 );
			Controls.AddRange( new Control[]{ brn_about,gbx_settings,pic_logo,list_users,txt_target,
				lbl_user,lbl_protocol,skype_protokol,btn_flooding,txt_flood_text} );
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = ( (System.Drawing.Icon)( resources.GetObject( "$Icon" ) ) );
			MaximizeBox = false;
			Name = "frm_main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Skype Flooder";
			
			( (ISupportInitialize)( skype_protokol ) ).EndInit();
			gbx_settings.ResumeLayout( false );
			gbx_settings.PerformLayout();
			( (ISupportInitialize)( pic_ghost ) ).EndInit();
			( (ISupportInitialize)( pic_fuckoff ) ).EndInit();
			( (ISupportInitialize)( pic_nothere ) ).EndInit();
			( (ISupportInitialize)( pic_online ) ).EndInit();
			( (ISupportInitialize)( nud_delay ) ).EndInit();
			( (ISupportInitialize)( pic_logo ) ).EndInit();
			ResumeLayout( false );
			PerformLayout();

		}
		private TextBox txt_flood_text;
		private Button btn_flooding;
		private NumericUpDown skype_protokol;
		private Label lbl_protocol;
		private Label lbl_user;
		private TextBox txt_target;
		private ListBox list_users;
		private PictureBox pic_logo;
		private GroupBox gbx_settings;
		private RadioButton rb_timeout_messages;
		private RadioButton rb_single_sending;
		private NumericUpDown nud_delay;
		private CheckBox chk_status_flooding;
		private RadioButton rb_online;
		private PictureBox pic_ghost;
		private RadioButton rb_ghost;
		private PictureBox pic_fuckoff;
		private RadioButton rb_fuckoff;
		private PictureBox pic_nothere;
		private RadioButton rb_nothere;
		private PictureBox pic_online;
		private RadioButton rb_infinite_messages;
		private Button brn_about;
	}
}

