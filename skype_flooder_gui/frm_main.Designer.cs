namespace skype_flooder_gui {
	partial class frm_main {
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_flood_text = new System.Windows.Forms.TextBox();
            this.btn_flooding = new System.Windows.Forms.Button();
            this.skype_protokol = new System.Windows.Forms.NumericUpDown();
            this.lbl_protocol = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.list_users = new System.Windows.Forms.ListBox();
            this.gbx_settings = new System.Windows.Forms.GroupBox();
            this.rb_infinite_messages = new System.Windows.Forms.RadioButton();
            this.pic_ghost = new System.Windows.Forms.PictureBox();
            this.rb_ghost = new System.Windows.Forms.RadioButton();
            this.pic_fuckoff = new System.Windows.Forms.PictureBox();
            this.rb_fuckoff = new System.Windows.Forms.RadioButton();
            this.pic_nothere = new System.Windows.Forms.PictureBox();
            this.rb_nothere = new System.Windows.Forms.RadioButton();
            this.pic_online = new System.Windows.Forms.PictureBox();
            this.rb_online = new System.Windows.Forms.RadioButton();
            this.chk_status_flooding = new System.Windows.Forms.CheckBox();
            this.nud_delay = new System.Windows.Forms.NumericUpDown();
            this.rb_timeout_messages = new System.Windows.Forms.RadioButton();
            this.rb_single_sending = new System.Windows.Forms.RadioButton();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.brn_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).BeginInit();
            this.gbx_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fuckoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nothere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_online)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_flood_text
            // 
            this.txt_flood_text.Location = new System.Drawing.Point(12, 342);
            this.txt_flood_text.Multiline = true;
            this.txt_flood_text.Name = "txt_flood_text";
            this.txt_flood_text.Size = new System.Drawing.Size(588, 149);
            this.txt_flood_text.TabIndex = 0;
            // 
            // btn_flooding
            // 
            this.btn_flooding.Enabled = false;
            this.btn_flooding.Location = new System.Drawing.Point(525, 497);
            this.btn_flooding.Name = "btn_flooding";
            this.btn_flooding.Size = new System.Drawing.Size(75, 23);
            this.btn_flooding.TabIndex = 0;
            this.btn_flooding.Text = "FLOOD";
            this.btn_flooding.UseVisualStyleBackColor = true;
            // 
            // skype_protokol
            // 
            this.skype_protokol.Location = new System.Drawing.Point(114, 163);
            this.skype_protokol.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.skype_protokol.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.skype_protokol.Name = "skype_protokol";
            this.skype_protokol.Size = new System.Drawing.Size(174, 20);
            this.skype_protokol.TabIndex = 2;
            this.skype_protokol.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_protocol
            // 
            this.lbl_protocol.AutoSize = true;
            this.lbl_protocol.Location = new System.Drawing.Point(12, 165);
            this.lbl_protocol.Name = "lbl_protocol";
            this.lbl_protocol.Size = new System.Drawing.Size(81, 13);
            this.lbl_protocol.TabIndex = 3;
            this.lbl_protocol.Text = "Skype protocol:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 140);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(96, 13);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Target user\'s login:";
            // 
            // txt_target
            // 
            this.txt_target.Location = new System.Drawing.Point(114, 137);
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(174, 20);
            this.txt_target.TabIndex = 5;
            this.txt_target.Text = "kasthack";
            // 
            // list_users
            // 
            this.list_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_users.FormattingEnabled = true;
            this.list_users.Location = new System.Drawing.Point(294, 137);
            this.list_users.Name = "list_users";
            this.list_users.ScrollAlwaysVisible = true;
            this.list_users.Size = new System.Drawing.Size(306, 199);
            this.list_users.Sorted = true;
            this.list_users.TabIndex = 6;
            // 
            // gbx_settings
            // 
            this.gbx_settings.Controls.Add(this.rb_infinite_messages);
            this.gbx_settings.Controls.Add(this.pic_ghost);
            this.gbx_settings.Controls.Add(this.rb_ghost);
            this.gbx_settings.Controls.Add(this.pic_fuckoff);
            this.gbx_settings.Controls.Add(this.rb_fuckoff);
            this.gbx_settings.Controls.Add(this.pic_nothere);
            this.gbx_settings.Controls.Add(this.rb_nothere);
            this.gbx_settings.Controls.Add(this.pic_online);
            this.gbx_settings.Controls.Add(this.rb_online);
            this.gbx_settings.Controls.Add(this.chk_status_flooding);
            this.gbx_settings.Controls.Add(this.nud_delay);
            this.gbx_settings.Controls.Add(this.rb_timeout_messages);
            this.gbx_settings.Controls.Add(this.rb_single_sending);
            this.gbx_settings.Location = new System.Drawing.Point(15, 189);
            this.gbx_settings.Name = "gbx_settings";
            this.gbx_settings.Size = new System.Drawing.Size(273, 147);
            this.gbx_settings.TabIndex = 8;
            this.gbx_settings.TabStop = false;
            this.gbx_settings.Text = "Settings";
            // 
            // rb_infinite_messages
            // 
            this.rb_infinite_messages.AutoSize = true;
            this.rb_infinite_messages.Location = new System.Drawing.Point(24, 42);
            this.rb_infinite_messages.Name = "rb_infinite_messages";
            this.rb_infinite_messages.Size = new System.Drawing.Size(146, 17);
            this.rb_infinite_messages.TabIndex = 11;
            this.rb_infinite_messages.Text = "Infinite sending messages";
            this.rb_infinite_messages.UseVisualStyleBackColor = true;
            // 
            // pic_ghost
            // 
            this.pic_ghost.Enabled = false;
            this.pic_ghost.Image = global::skype_flooder_gui.Properties.Resources._916;
            this.pic_ghost.Location = new System.Drawing.Point(163, 126);
            this.pic_ghost.Name = "pic_ghost";
            this.pic_ghost.Size = new System.Drawing.Size(16, 16);
            this.pic_ghost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_ghost.TabIndex = 10;
            this.pic_ghost.TabStop = false;
            // 
            // rb_ghost
            // 
            this.rb_ghost.AutoSize = true;
            this.rb_ghost.Enabled = false;
            this.rb_ghost.Location = new System.Drawing.Point(165, 108);
            this.rb_ghost.Name = "rb_ghost";
            this.rb_ghost.Size = new System.Drawing.Size(14, 13);
            this.rb_ghost.TabIndex = 9;
            this.rb_ghost.UseVisualStyleBackColor = true;
            // 
            // pic_fuckoff
            // 
            this.pic_fuckoff.Enabled = false;
            this.pic_fuckoff.Image = global::skype_flooder_gui.Properties.Resources._914_001;
            this.pic_fuckoff.Location = new System.Drawing.Point(131, 126);
            this.pic_fuckoff.Name = "pic_fuckoff";
            this.pic_fuckoff.Size = new System.Drawing.Size(16, 16);
            this.pic_fuckoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_fuckoff.TabIndex = 8;
            this.pic_fuckoff.TabStop = false;
            // 
            // rb_fuckoff
            // 
            this.rb_fuckoff.AutoSize = true;
            this.rb_fuckoff.Enabled = false;
            this.rb_fuckoff.Location = new System.Drawing.Point(133, 108);
            this.rb_fuckoff.Name = "rb_fuckoff";
            this.rb_fuckoff.Size = new System.Drawing.Size(14, 13);
            this.rb_fuckoff.TabIndex = 7;
            this.rb_fuckoff.UseVisualStyleBackColor = true;
            // 
            // pic_nothere
            // 
            this.pic_nothere.Enabled = false;
            this.pic_nothere.Image = global::skype_flooder_gui.Properties.Resources._913_001;
            this.pic_nothere.Location = new System.Drawing.Point(97, 126);
            this.pic_nothere.Name = "pic_nothere";
            this.pic_nothere.Size = new System.Drawing.Size(16, 16);
            this.pic_nothere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_nothere.TabIndex = 6;
            this.pic_nothere.TabStop = false;
            // 
            // rb_nothere
            // 
            this.rb_nothere.AutoSize = true;
            this.rb_nothere.Enabled = false;
            this.rb_nothere.Location = new System.Drawing.Point(99, 108);
            this.rb_nothere.Name = "rb_nothere";
            this.rb_nothere.Size = new System.Drawing.Size(14, 13);
            this.rb_nothere.TabIndex = 5;
            this.rb_nothere.UseVisualStyleBackColor = true;
            // 
            // pic_online
            // 
            this.pic_online.Enabled = false;
            this.pic_online.Image = global::skype_flooder_gui.Properties.Resources._912_001;
            this.pic_online.Location = new System.Drawing.Point(61, 126);
            this.pic_online.Name = "pic_online";
            this.pic_online.Size = new System.Drawing.Size(16, 16);
            this.pic_online.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_online.TabIndex = 4;
            this.pic_online.TabStop = false;
            // 
            // rb_online
            // 
            this.rb_online.AutoSize = true;
            this.rb_online.Enabled = false;
            this.rb_online.Location = new System.Drawing.Point(64, 108);
            this.rb_online.Name = "rb_online";
            this.rb_online.Size = new System.Drawing.Size(14, 13);
            this.rb_online.TabIndex = 3;
            this.rb_online.UseVisualStyleBackColor = true;
            // 
            // chk_status_flooding
            // 
            this.chk_status_flooding.AutoSize = true;
            this.chk_status_flooding.Location = new System.Drawing.Point(24, 91);
            this.chk_status_flooding.Name = "chk_status_flooding";
            this.chk_status_flooding.Size = new System.Drawing.Size(197, 17);
            this.chk_status_flooding.TabIndex = 2;
            this.chk_status_flooding.Text = "Change skype status when flooding:";
            this.chk_status_flooding.UseVisualStyleBackColor = true;
            // 
            // nud_delay
            // 
            this.nud_delay.Location = new System.Drawing.Point(153, 65);
            this.nud_delay.Name = "nud_delay";
            this.nud_delay.Size = new System.Drawing.Size(97, 20);
            this.nud_delay.TabIndex = 1;
            // 
            // rb_timeout_messages
            // 
            this.rb_timeout_messages.AutoSize = true;
            this.rb_timeout_messages.Location = new System.Drawing.Point(24, 65);
            this.rb_timeout_messages.Name = "rb_timeout_messages";
            this.rb_timeout_messages.Size = new System.Drawing.Size(123, 17);
            this.rb_timeout_messages.TabIndex = 0;
            this.rb_timeout_messages.Text = "Sending with timeout";
            this.rb_timeout_messages.UseVisualStyleBackColor = true;
            // 
            // rb_single_sending
            // 
            this.rb_single_sending.AutoSize = true;
            this.rb_single_sending.Checked = true;
            this.rb_single_sending.Location = new System.Drawing.Point(24, 19);
            this.rb_single_sending.Name = "rb_single_sending";
            this.rb_single_sending.Size = new System.Drawing.Size(104, 17);
            this.rb_single_sending.TabIndex = 0;
            this.rb_single_sending.TabStop = true;
            this.rb_single_sending.Text = "Single messages";
            this.rb_single_sending.UseVisualStyleBackColor = true;
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImage = global::skype_flooder_gui.Properties.Resources.LOGO;
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(612, 131);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            // 
            // brn_about
            // 
            this.brn_about.Location = new System.Drawing.Point(12, 497);
            this.brn_about.Name = "brn_about";
            this.brn_about.Size = new System.Drawing.Size(75, 23);
            this.brn_about.TabIndex = 9;
            this.brn_about.Text = "About";
            this.brn_about.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 532);
            this.Controls.Add(this.brn_about);
            this.Controls.Add(this.gbx_settings);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.list_users);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_protocol);
            this.Controls.Add(this.skype_protokol);
            this.Controls.Add(this.btn_flooding);
            this.Controls.Add(this.txt_flood_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skype Flooder";
            this.Load += new System.EventHandler(this.on_load);
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).EndInit();
            this.gbx_settings.ResumeLayout(false);
            this.gbx_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fuckoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nothere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_online)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_flood_text;
		private System.Windows.Forms.Button btn_flooding;
		private System.Windows.Forms.NumericUpDown skype_protokol;
		private System.Windows.Forms.Label lbl_protocol;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.TextBox txt_target;
		private System.Windows.Forms.ListBox list_users;
		private System.Windows.Forms.PictureBox pic_logo;
		private System.Windows.Forms.GroupBox gbx_settings;
		private System.Windows.Forms.RadioButton rb_timeout_messages;
		private System.Windows.Forms.RadioButton rb_single_sending;
		private System.Windows.Forms.NumericUpDown nud_delay;
		private System.Windows.Forms.CheckBox chk_status_flooding;
		private System.Windows.Forms.RadioButton rb_online;
		private System.Windows.Forms.PictureBox pic_ghost;
		private System.Windows.Forms.RadioButton rb_ghost;
		private System.Windows.Forms.PictureBox pic_fuckoff;
		private System.Windows.Forms.RadioButton rb_fuckoff;
		private System.Windows.Forms.PictureBox pic_nothere;
		private System.Windows.Forms.RadioButton rb_nothere;
		private System.Windows.Forms.PictureBox pic_online;
		private System.Windows.Forms.RadioButton rb_infinite_messages;
		private System.Windows.Forms.Button brn_about;
	}
}
