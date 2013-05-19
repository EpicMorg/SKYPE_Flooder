using System.ComponentModel;
using System.Windows.Forms;
using System;
namespace skype_flooder_gui {
	partial class frm_main {
		private IContainer components = null;
		private Button brn_about, btn_flooding;
		private CheckBox chk_status_flooding;
		private GroupBox gbx_settings;
		private Label lbl_protocol, lbl_user;
		private ListBox list_users;
		private NumericUpDown nud_delay, skype_protokol;
		private PictureBox pic_fuckoff, pic_ghost, pic_logo, pic_nothere, pic_online;
		private RadioButton rb_fuckoff, rb_ghost, rb_infinite_messages, rb_nothere, rb_online, rb_single_sending, rb_timeout_messages;
		private TextBox txt_flood_text, txt_target;
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
			rb_infinite_messages = new RadioButton() {
				AutoSize = true,
				Location = new System.Drawing.Point( 24, 42 ),
				Name = "rb_infinite_messages",
				Size = new System.Drawing.Size( 146, 17 ),
				TabIndex = 11,
				Text = "Infinite sending messages",
				UseVisualStyleBackColor = true,
				Enabled = false
			};
			pic_ghost = new PictureBox() {
				Enabled = false,
				Image = global::skype_flooder_gui.Properties.Resources._916,
				Location = new System.Drawing.Point( 163, 126 ),
				Name = "pic_ghost",
				Size = new System.Drawing.Size( 16, 16 ),
				SizeMode = PictureBoxSizeMode.AutoSize,
				TabIndex = 10,
				TabStop = false
			};
			rb_ghost = new RadioButton() {
				AutoSize = true,
				Enabled = false,
				Location = new System.Drawing.Point( 165, 108 ),
				Name = "rb_ghost",
				Size = new System.Drawing.Size( 14, 13 ),
				TabIndex = 9,
				UseVisualStyleBackColor = true
			};
			pic_fuckoff = new PictureBox() {
				Enabled = false,
				Image = global::skype_flooder_gui.Properties.Resources._914_001,
				Location = new System.Drawing.Point( 131, 126 ),
				Name = "pic_fuckoff",
				Size = new System.Drawing.Size( 16, 16 ),
				SizeMode = PictureBoxSizeMode.AutoSize,
				TabIndex = 8,
				TabStop = false
			};
			rb_fuckoff = new RadioButton() {
				AutoSize = true,
				Enabled = false,
				Location = new System.Drawing.Point( 133, 108 ),
				Name = "rb_fuckoff",
				Size = new System.Drawing.Size( 14, 13 ),
				TabIndex = 7,
				UseVisualStyleBackColor = true
			};
			pic_nothere = new PictureBox() {
				Enabled = false,
				Image = global::skype_flooder_gui.Properties.Resources._913_001,
				Location = new System.Drawing.Point( 97, 126 ),
				Name = "pic_nothere",
				Size = new System.Drawing.Size( 16, 16 ),
				SizeMode = PictureBoxSizeMode.AutoSize,
				TabIndex = 6,
				TabStop = false
			};
			rb_nothere = new RadioButton() {
				AutoSize = true,
				Enabled = false,
				Location = new System.Drawing.Point( 99, 108 ),
				Name = "rb_nothere",
				Size = new System.Drawing.Size( 14, 13 ),
				TabIndex = 5,
				UseVisualStyleBackColor = true
			};
			pic_online = new PictureBox() {
				Enabled = false,
				Image = skype_flooder_gui.Properties.Resources._912_001,
				Location = new System.Drawing.Point( 61, 126 ),
				Name = "pic_online",
				Size = new System.Drawing.Size( 16, 16 ),
				SizeMode = PictureBoxSizeMode.AutoSize,
				TabIndex = 4,
				TabStop = false,
			};
			rb_online = new RadioButton() {
				AutoSize = true,
				Enabled = false,
				Location = new System.Drawing.Point( 64, 108 ),
				Name = "rb_online",
				Size = new System.Drawing.Size( 14, 13 ),
				TabIndex = 3,
				UseVisualStyleBackColor = true,
			};
			chk_status_flooding = new CheckBox() {
				AutoSize = true,
				Location = new System.Drawing.Point( 24, 91 ),
				Name = "chk_status_flooding",
				Size = new System.Drawing.Size( 197, 17 ),
				TabIndex = 2,
				Text = "Change skype status when flooding:",
				UseVisualStyleBackColor = true
			};
			nud_delay = new NumericUpDown() {
					Location = new System.Drawing.Point( 153, 65 ),
				Name = "numericUpDown1",
				Size = new System.Drawing.Size( 97, 20 ),
				TabIndex = 1
			};
			rb_timeout_messages = new RadioButton() {
					AutoSize = true,
					Location = new System.Drawing.Point( 24, 65 ),
					Name = "rb_timeout_messages",
					Size = new System.Drawing.Size( 123, 17 ),
					TabIndex = 0,
					Text = "Sending with timeout",
					UseVisualStyleBackColor = true
			};
			rb_single_sending = new RadioButton() {
				AutoSize = true,
				Checked = true,
				Location = new System.Drawing.Point( 24, 19 ),
				Name = "rb_single_sending",
				Size = new System.Drawing.Size( 104, 17 ),
				TabIndex = 0,
				TabStop = true,
				Text = "Single messages",
				UseVisualStyleBackColor = true,
			};
			pic_logo = new PictureBox() {
				BackgroundImage = global::skype_flooder_gui.Properties.Resources.LOGO,
				BackgroundImageLayout = ImageLayout.Center,
				Dock = DockStyle.Top,
				Location = new System.Drawing.Point( 0, 0 ),
				Name = "pic_logo",
				Size = new System.Drawing.Size( 612, 131 ),
				SizeMode = PictureBoxSizeMode.AutoSize,
				TabIndex = 7,
				TabStop = false
			};
			brn_about = new Button() {
				Location = new System.Drawing.Point( 12, 497 ),
				Name = "brn_about",
				Size = new System.Drawing.Size( 75, 23 ),
				TabIndex = 9,
				Text = "About",
				UseVisualStyleBackColor = true
			};
			txt_flood_text.TextChanged += ( a, b ) => { btn_flooding.Enabled = !String.IsNullOrEmpty( txt_flood_text.Text.Trim() ); };
			list_users.SelectedIndexChanged += ( a, b ) => {txt_target.Text = ( (skype_friends)list_users.SelectedItem ).s_user.Handle;};
			btn_flooding.Click += ( a, b ) => this.Attacking ^= true;
			chk_status_flooding.CheckedChanged += ( a, b ) => {rb_fuckoff.Enabled = rb_ghost.Enabled = rb_nothere.Enabled = rb_online.Enabled = chk_status_flooding.Checked;};
			brn_about.Click += ( a, b ) => { new frm_about().ShowDialog(); };
			Load += on_load ;

			gbx_settings.Controls.AddRange(new Control[]{
pic_ghost,rb_ghost,pic_fuckoff,rb_fuckoff,pic_nothere,rb_nothere,pic_online,rb_online,
chk_status_flooding,nud_delay,rb_timeout_messages,rb_single_sending,rb_infinite_messages} );
			
			AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size( 612, 532 );
			Controls.AddRange( new Control[]{ brn_about,gbx_settings,pic_logo,list_users,txt_target, lbl_user,lbl_protocol,skype_protokol,btn_flooding,txt_flood_text} );
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = ( (System.Drawing.Icon)( resources.GetObject( "$Icon" ) ) );
			MaximizeBox = false;
			Name = "frm_main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Skype Flooder";
			PerformLayout();
		}
		}
}