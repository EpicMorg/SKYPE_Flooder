namespace skype_flooder_gui.UI {
	partial class FrmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txt_flood_text = new System.Windows.Forms.TextBox();
            this.skype_protokol = new System.Windows.Forms.NumericUpDown();
            this.lbl_protocol = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.list_users = new System.Windows.Forms.ListBox();
            this.gbx_settings = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.rb_infinite_messages = new System.Windows.Forms.RadioButton();
            this.chk_status_flooding = new System.Windows.Forms.CheckBox();
            this.nud_delay = new System.Windows.Forms.NumericUpDown();
            this.rb_timeout_messages = new System.Windows.Forms.RadioButton();
            this.rb_single_sending = new System.Windows.Forms.RadioButton();
            this.brn_about = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_flooding = new System.Windows.Forms.Button();
            this.comboBoxSmiles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).BeginInit();
            this.gbx_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_flood_text
            // 
            resources.ApplyResources(this.txt_flood_text, "txt_flood_text");
            this.txt_flood_text.Name = "txt_flood_text";
            // 
            // skype_protokol
            // 
            resources.ApplyResources(this.skype_protokol, "skype_protokol");
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
            this.skype_protokol.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbl_protocol
            // 
            resources.ApplyResources(this.lbl_protocol, "lbl_protocol");
            this.lbl_protocol.Name = "lbl_protocol";
            // 
            // lbl_user
            // 
            resources.ApplyResources(this.lbl_user, "lbl_user");
            this.lbl_user.Name = "lbl_user";
            // 
            // txt_target
            // 
            resources.ApplyResources(this.txt_target, "txt_target");
            this.txt_target.Name = "txt_target";
            // 
            // list_users
            // 
            resources.ApplyResources(this.list_users, "list_users");
            this.list_users.FormattingEnabled = true;
            this.list_users.Name = "list_users";
            this.list_users.Sorted = true;
            // 
            // gbx_settings
            // 
            resources.ApplyResources(this.gbx_settings, "gbx_settings");
            this.gbx_settings.Controls.Add(this.comboStatus);
            this.gbx_settings.Controls.Add(this.rb_infinite_messages);
            this.gbx_settings.Controls.Add(this.chk_status_flooding);
            this.gbx_settings.Controls.Add(this.nud_delay);
            this.gbx_settings.Controls.Add(this.rb_timeout_messages);
            this.gbx_settings.Controls.Add(this.rb_single_sending);
            this.gbx_settings.Name = "gbx_settings";
            this.gbx_settings.TabStop = false;
            // 
            // comboStatus
            // 
            resources.ApplyResources(this.comboStatus, "comboStatus");
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Name = "comboStatus";
            // 
            // rb_infinite_messages
            // 
            resources.ApplyResources(this.rb_infinite_messages, "rb_infinite_messages");
            this.rb_infinite_messages.Name = "rb_infinite_messages";
            this.rb_infinite_messages.UseVisualStyleBackColor = true;
            // 
            // chk_status_flooding
            // 
            resources.ApplyResources(this.chk_status_flooding, "chk_status_flooding");
            this.chk_status_flooding.Name = "chk_status_flooding";
            this.chk_status_flooding.UseVisualStyleBackColor = true;
            this.chk_status_flooding.CheckedChanged += new System.EventHandler(this.chk_status_flooding_CheckedChanged);
            // 
            // nud_delay
            // 
            resources.ApplyResources(this.nud_delay, "nud_delay");
            this.nud_delay.Name = "nud_delay";
            // 
            // rb_timeout_messages
            // 
            resources.ApplyResources(this.rb_timeout_messages, "rb_timeout_messages");
            this.rb_timeout_messages.Name = "rb_timeout_messages";
            this.rb_timeout_messages.UseVisualStyleBackColor = true;
            // 
            // rb_single_sending
            // 
            resources.ApplyResources(this.rb_single_sending, "rb_single_sending");
            this.rb_single_sending.Checked = true;
            this.rb_single_sending.Name = "rb_single_sending";
            this.rb_single_sending.TabStop = true;
            this.rb_single_sending.UseVisualStyleBackColor = true;
            // 
            // brn_about
            // 
            resources.ApplyResources(this.brn_about, "brn_about");
            this.brn_about.Name = "brn_about";
            this.brn_about.UseVisualStyleBackColor = true;
            // 
            // pic_logo
            // 
            resources.ApplyResources(this.pic_logo, "pic_logo");
            this.pic_logo.BackgroundImage = global::skype_flooder_gui.Properties.Resources.LOGO;
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.TabStop = false;
            // 
            // btn_flooding
            // 
            resources.ApplyResources(this.btn_flooding, "btn_flooding");
            this.btn_flooding.Image = global::skype_flooder_gui.Properties.Resources.Shachlo1;
            this.btn_flooding.Name = "btn_flooding";
            this.btn_flooding.UseVisualStyleBackColor = true;
            this.btn_flooding.Click += new System.EventHandler(this.btn_flooding_Click);
            // 
            // comboBoxSmiles
            // 
            resources.ApplyResources(this.comboBoxSmiles, "comboBoxSmiles");
            this.comboBoxSmiles.FormattingEnabled = true;
            this.comboBoxSmiles.Items.AddRange(new object[] {
            resources.GetString("comboBoxSmiles.Items"),
            resources.GetString("comboBoxSmiles.Items1"),
            resources.GetString("comboBoxSmiles.Items2"),
            resources.GetString("comboBoxSmiles.Items3"),
            resources.GetString("comboBoxSmiles.Items4"),
            resources.GetString("comboBoxSmiles.Items5"),
            resources.GetString("comboBoxSmiles.Items6"),
            resources.GetString("comboBoxSmiles.Items7"),
            resources.GetString("comboBoxSmiles.Items8"),
            resources.GetString("comboBoxSmiles.Items9"),
            resources.GetString("comboBoxSmiles.Items10"),
            resources.GetString("comboBoxSmiles.Items11"),
            resources.GetString("comboBoxSmiles.Items12"),
            resources.GetString("comboBoxSmiles.Items13"),
            resources.GetString("comboBoxSmiles.Items14"),
            resources.GetString("comboBoxSmiles.Items15"),
            resources.GetString("comboBoxSmiles.Items16"),
            resources.GetString("comboBoxSmiles.Items17"),
            resources.GetString("comboBoxSmiles.Items18"),
            resources.GetString("comboBoxSmiles.Items19"),
            resources.GetString("comboBoxSmiles.Items20"),
            resources.GetString("comboBoxSmiles.Items21"),
            resources.GetString("comboBoxSmiles.Items22"),
            resources.GetString("comboBoxSmiles.Items23"),
            resources.GetString("comboBoxSmiles.Items24"),
            resources.GetString("comboBoxSmiles.Items25"),
            resources.GetString("comboBoxSmiles.Items26"),
            resources.GetString("comboBoxSmiles.Items27"),
            resources.GetString("comboBoxSmiles.Items28"),
            resources.GetString("comboBoxSmiles.Items29"),
            resources.GetString("comboBoxSmiles.Items30"),
            resources.GetString("comboBoxSmiles.Items31"),
            resources.GetString("comboBoxSmiles.Items32"),
            resources.GetString("comboBoxSmiles.Items33"),
            resources.GetString("comboBoxSmiles.Items34"),
            resources.GetString("comboBoxSmiles.Items35"),
            resources.GetString("comboBoxSmiles.Items36"),
            resources.GetString("comboBoxSmiles.Items37"),
            resources.GetString("comboBoxSmiles.Items38"),
            resources.GetString("comboBoxSmiles.Items39"),
            resources.GetString("comboBoxSmiles.Items40"),
            resources.GetString("comboBoxSmiles.Items41"),
            resources.GetString("comboBoxSmiles.Items42"),
            resources.GetString("comboBoxSmiles.Items43"),
            resources.GetString("comboBoxSmiles.Items44"),
            resources.GetString("comboBoxSmiles.Items45"),
            resources.GetString("comboBoxSmiles.Items46"),
            resources.GetString("comboBoxSmiles.Items47"),
            resources.GetString("comboBoxSmiles.Items48"),
            resources.GetString("comboBoxSmiles.Items49"),
            resources.GetString("comboBoxSmiles.Items50"),
            resources.GetString("comboBoxSmiles.Items51"),
            resources.GetString("comboBoxSmiles.Items52"),
            resources.GetString("comboBoxSmiles.Items53"),
            resources.GetString("comboBoxSmiles.Items54"),
            resources.GetString("comboBoxSmiles.Items55"),
            resources.GetString("comboBoxSmiles.Items56"),
            resources.GetString("comboBoxSmiles.Items57"),
            resources.GetString("comboBoxSmiles.Items58"),
            resources.GetString("comboBoxSmiles.Items59"),
            resources.GetString("comboBoxSmiles.Items60"),
            resources.GetString("comboBoxSmiles.Items61"),
            resources.GetString("comboBoxSmiles.Items62"),
            resources.GetString("comboBoxSmiles.Items63"),
            resources.GetString("comboBoxSmiles.Items64"),
            resources.GetString("comboBoxSmiles.Items65"),
            resources.GetString("comboBoxSmiles.Items66"),
            resources.GetString("comboBoxSmiles.Items67"),
            resources.GetString("comboBoxSmiles.Items68"),
            resources.GetString("comboBoxSmiles.Items69"),
            resources.GetString("comboBoxSmiles.Items70"),
            resources.GetString("comboBoxSmiles.Items71"),
            resources.GetString("comboBoxSmiles.Items72"),
            resources.GetString("comboBoxSmiles.Items73"),
            resources.GetString("comboBoxSmiles.Items74"),
            resources.GetString("comboBoxSmiles.Items75"),
            resources.GetString("comboBoxSmiles.Items76"),
            resources.GetString("comboBoxSmiles.Items77"),
            resources.GetString("comboBoxSmiles.Items78"),
            resources.GetString("comboBoxSmiles.Items79"),
            resources.GetString("comboBoxSmiles.Items80"),
            resources.GetString("comboBoxSmiles.Items81"),
            resources.GetString("comboBoxSmiles.Items82"),
            resources.GetString("comboBoxSmiles.Items83"),
            resources.GetString("comboBoxSmiles.Items84"),
            resources.GetString("comboBoxSmiles.Items85"),
            resources.GetString("comboBoxSmiles.Items86"),
            resources.GetString("comboBoxSmiles.Items87"),
            resources.GetString("comboBoxSmiles.Items88"),
            resources.GetString("comboBoxSmiles.Items89"),
            resources.GetString("comboBoxSmiles.Items90"),
            resources.GetString("comboBoxSmiles.Items91"),
            resources.GetString("comboBoxSmiles.Items92"),
            resources.GetString("comboBoxSmiles.Items93"),
            resources.GetString("comboBoxSmiles.Items94"),
            resources.GetString("comboBoxSmiles.Items95"),
            resources.GetString("comboBoxSmiles.Items96"),
            resources.GetString("comboBoxSmiles.Items97"),
            resources.GetString("comboBoxSmiles.Items98"),
            resources.GetString("comboBoxSmiles.Items99"),
            resources.GetString("comboBoxSmiles.Items100"),
            resources.GetString("comboBoxSmiles.Items101"),
            resources.GetString("comboBoxSmiles.Items102"),
            resources.GetString("comboBoxSmiles.Items103"),
            resources.GetString("comboBoxSmiles.Items104"),
            resources.GetString("comboBoxSmiles.Items105"),
            resources.GetString("comboBoxSmiles.Items106"),
            resources.GetString("comboBoxSmiles.Items107"),
            resources.GetString("comboBoxSmiles.Items108"),
            resources.GetString("comboBoxSmiles.Items109"),
            resources.GetString("comboBoxSmiles.Items110"),
            resources.GetString("comboBoxSmiles.Items111"),
            resources.GetString("comboBoxSmiles.Items112"),
            resources.GetString("comboBoxSmiles.Items113"),
            resources.GetString("comboBoxSmiles.Items114"),
            resources.GetString("comboBoxSmiles.Items115"),
            resources.GetString("comboBoxSmiles.Items116"),
            resources.GetString("comboBoxSmiles.Items117"),
            resources.GetString("comboBoxSmiles.Items118"),
            resources.GetString("comboBoxSmiles.Items119"),
            resources.GetString("comboBoxSmiles.Items120"),
            resources.GetString("comboBoxSmiles.Items121"),
            resources.GetString("comboBoxSmiles.Items122"),
            resources.GetString("comboBoxSmiles.Items123"),
            resources.GetString("comboBoxSmiles.Items124"),
            resources.GetString("comboBoxSmiles.Items125"),
            resources.GetString("comboBoxSmiles.Items126"),
            resources.GetString("comboBoxSmiles.Items127"),
            resources.GetString("comboBoxSmiles.Items128"),
            resources.GetString("comboBoxSmiles.Items129"),
            resources.GetString("comboBoxSmiles.Items130"),
            resources.GetString("comboBoxSmiles.Items131"),
            resources.GetString("comboBoxSmiles.Items132"),
            resources.GetString("comboBoxSmiles.Items133"),
            resources.GetString("comboBoxSmiles.Items134"),
            resources.GetString("comboBoxSmiles.Items135"),
            resources.GetString("comboBoxSmiles.Items136"),
            resources.GetString("comboBoxSmiles.Items137"),
            resources.GetString("comboBoxSmiles.Items138"),
            resources.GetString("comboBoxSmiles.Items139"),
            resources.GetString("comboBoxSmiles.Items140"),
            resources.GetString("comboBoxSmiles.Items141"),
            resources.GetString("comboBoxSmiles.Items142"),
            resources.GetString("comboBoxSmiles.Items143"),
            resources.GetString("comboBoxSmiles.Items144"),
            resources.GetString("comboBoxSmiles.Items145"),
            resources.GetString("comboBoxSmiles.Items146"),
            resources.GetString("comboBoxSmiles.Items147"),
            resources.GetString("comboBoxSmiles.Items148"),
            resources.GetString("comboBoxSmiles.Items149"),
            resources.GetString("comboBoxSmiles.Items150"),
            resources.GetString("comboBoxSmiles.Items151"),
            resources.GetString("comboBoxSmiles.Items152"),
            resources.GetString("comboBoxSmiles.Items153"),
            resources.GetString("comboBoxSmiles.Items154"),
            resources.GetString("comboBoxSmiles.Items155"),
            resources.GetString("comboBoxSmiles.Items156"),
            resources.GetString("comboBoxSmiles.Items157"),
            resources.GetString("comboBoxSmiles.Items158"),
            resources.GetString("comboBoxSmiles.Items159"),
            resources.GetString("comboBoxSmiles.Items160"),
            resources.GetString("comboBoxSmiles.Items161"),
            resources.GetString("comboBoxSmiles.Items162"),
            resources.GetString("comboBoxSmiles.Items163"),
            resources.GetString("comboBoxSmiles.Items164"),
            resources.GetString("comboBoxSmiles.Items165"),
            resources.GetString("comboBoxSmiles.Items166"),
            resources.GetString("comboBoxSmiles.Items167"),
            resources.GetString("comboBoxSmiles.Items168"),
            resources.GetString("comboBoxSmiles.Items169"),
            resources.GetString("comboBoxSmiles.Items170"),
            resources.GetString("comboBoxSmiles.Items171"),
            resources.GetString("comboBoxSmiles.Items172"),
            resources.GetString("comboBoxSmiles.Items173"),
            resources.GetString("comboBoxSmiles.Items174"),
            resources.GetString("comboBoxSmiles.Items175"),
            resources.GetString("comboBoxSmiles.Items176"),
            resources.GetString("comboBoxSmiles.Items177"),
            resources.GetString("comboBoxSmiles.Items178"),
            resources.GetString("comboBoxSmiles.Items179"),
            resources.GetString("comboBoxSmiles.Items180"),
            resources.GetString("comboBoxSmiles.Items181"),
            resources.GetString("comboBoxSmiles.Items182"),
            resources.GetString("comboBoxSmiles.Items183"),
            resources.GetString("comboBoxSmiles.Items184"),
            resources.GetString("comboBoxSmiles.Items185"),
            resources.GetString("comboBoxSmiles.Items186"),
            resources.GetString("comboBoxSmiles.Items187"),
            resources.GetString("comboBoxSmiles.Items188"),
            resources.GetString("comboBoxSmiles.Items189"),
            resources.GetString("comboBoxSmiles.Items190"),
            resources.GetString("comboBoxSmiles.Items191"),
            resources.GetString("comboBoxSmiles.Items192"),
            resources.GetString("comboBoxSmiles.Items193"),
            resources.GetString("comboBoxSmiles.Items194"),
            resources.GetString("comboBoxSmiles.Items195"),
            resources.GetString("comboBoxSmiles.Items196"),
            resources.GetString("comboBoxSmiles.Items197"),
            resources.GetString("comboBoxSmiles.Items198"),
            resources.GetString("comboBoxSmiles.Items199"),
            resources.GetString("comboBoxSmiles.Items200"),
            resources.GetString("comboBoxSmiles.Items201"),
            resources.GetString("comboBoxSmiles.Items202"),
            resources.GetString("comboBoxSmiles.Items203"),
            resources.GetString("comboBoxSmiles.Items204"),
            resources.GetString("comboBoxSmiles.Items205"),
            resources.GetString("comboBoxSmiles.Items206"),
            resources.GetString("comboBoxSmiles.Items207"),
            resources.GetString("comboBoxSmiles.Items208"),
            resources.GetString("comboBoxSmiles.Items209"),
            resources.GetString("comboBoxSmiles.Items210"),
            resources.GetString("comboBoxSmiles.Items211"),
            resources.GetString("comboBoxSmiles.Items212"),
            resources.GetString("comboBoxSmiles.Items213"),
            resources.GetString("comboBoxSmiles.Items214"),
            resources.GetString("comboBoxSmiles.Items215"),
            resources.GetString("comboBoxSmiles.Items216"),
            resources.GetString("comboBoxSmiles.Items217"),
            resources.GetString("comboBoxSmiles.Items218"),
            resources.GetString("comboBoxSmiles.Items219"),
            resources.GetString("comboBoxSmiles.Items220"),
            resources.GetString("comboBoxSmiles.Items221"),
            resources.GetString("comboBoxSmiles.Items222"),
            resources.GetString("comboBoxSmiles.Items223"),
            resources.GetString("comboBoxSmiles.Items224"),
            resources.GetString("comboBoxSmiles.Items225"),
            resources.GetString("comboBoxSmiles.Items226"),
            resources.GetString("comboBoxSmiles.Items227"),
            resources.GetString("comboBoxSmiles.Items228"),
            resources.GetString("comboBoxSmiles.Items229"),
            resources.GetString("comboBoxSmiles.Items230"),
            resources.GetString("comboBoxSmiles.Items231"),
            resources.GetString("comboBoxSmiles.Items232"),
            resources.GetString("comboBoxSmiles.Items233"),
            resources.GetString("comboBoxSmiles.Items234"),
            resources.GetString("comboBoxSmiles.Items235"),
            resources.GetString("comboBoxSmiles.Items236"),
            resources.GetString("comboBoxSmiles.Items237"),
            resources.GetString("comboBoxSmiles.Items238"),
            resources.GetString("comboBoxSmiles.Items239"),
            resources.GetString("comboBoxSmiles.Items240"),
            resources.GetString("comboBoxSmiles.Items241"),
            resources.GetString("comboBoxSmiles.Items242"),
            resources.GetString("comboBoxSmiles.Items243"),
            resources.GetString("comboBoxSmiles.Items244"),
            resources.GetString("comboBoxSmiles.Items245"),
            resources.GetString("comboBoxSmiles.Items246"),
            resources.GetString("comboBoxSmiles.Items247"),
            resources.GetString("comboBoxSmiles.Items248"),
            resources.GetString("comboBoxSmiles.Items249"),
            resources.GetString("comboBoxSmiles.Items250"),
            resources.GetString("comboBoxSmiles.Items251"),
            resources.GetString("comboBoxSmiles.Items252"),
            resources.GetString("comboBoxSmiles.Items253"),
            resources.GetString("comboBoxSmiles.Items254"),
            resources.GetString("comboBoxSmiles.Items255"),
            resources.GetString("comboBoxSmiles.Items256"),
            resources.GetString("comboBoxSmiles.Items257"),
            resources.GetString("comboBoxSmiles.Items258"),
            resources.GetString("comboBoxSmiles.Items259"),
            resources.GetString("comboBoxSmiles.Items260"),
            resources.GetString("comboBoxSmiles.Items261"),
            resources.GetString("comboBoxSmiles.Items262"),
            resources.GetString("comboBoxSmiles.Items263"),
            resources.GetString("comboBoxSmiles.Items264"),
            resources.GetString("comboBoxSmiles.Items265"),
            resources.GetString("comboBoxSmiles.Items266"),
            resources.GetString("comboBoxSmiles.Items267"),
            resources.GetString("comboBoxSmiles.Items268"),
            resources.GetString("comboBoxSmiles.Items269"),
            resources.GetString("comboBoxSmiles.Items270"),
            resources.GetString("comboBoxSmiles.Items271"),
            resources.GetString("comboBoxSmiles.Items272"),
            resources.GetString("comboBoxSmiles.Items273"),
            resources.GetString("comboBoxSmiles.Items274"),
            resources.GetString("comboBoxSmiles.Items275"),
            resources.GetString("comboBoxSmiles.Items276"),
            resources.GetString("comboBoxSmiles.Items277"),
            resources.GetString("comboBoxSmiles.Items278"),
            resources.GetString("comboBoxSmiles.Items279"),
            resources.GetString("comboBoxSmiles.Items280"),
            resources.GetString("comboBoxSmiles.Items281"),
            resources.GetString("comboBoxSmiles.Items282"),
            resources.GetString("comboBoxSmiles.Items283"),
            resources.GetString("comboBoxSmiles.Items284"),
            resources.GetString("comboBoxSmiles.Items285"),
            resources.GetString("comboBoxSmiles.Items286"),
            resources.GetString("comboBoxSmiles.Items287"),
            resources.GetString("comboBoxSmiles.Items288"),
            resources.GetString("comboBoxSmiles.Items289"),
            resources.GetString("comboBoxSmiles.Items290"),
            resources.GetString("comboBoxSmiles.Items291"),
            resources.GetString("comboBoxSmiles.Items292"),
            resources.GetString("comboBoxSmiles.Items293"),
            resources.GetString("comboBoxSmiles.Items294"),
            resources.GetString("comboBoxSmiles.Items295"),
            resources.GetString("comboBoxSmiles.Items296"),
            resources.GetString("comboBoxSmiles.Items297"),
            resources.GetString("comboBoxSmiles.Items298"),
            resources.GetString("comboBoxSmiles.Items299"),
            resources.GetString("comboBoxSmiles.Items300"),
            resources.GetString("comboBoxSmiles.Items301"),
            resources.GetString("comboBoxSmiles.Items302"),
            resources.GetString("comboBoxSmiles.Items303"),
            resources.GetString("comboBoxSmiles.Items304"),
            resources.GetString("comboBoxSmiles.Items305"),
            resources.GetString("comboBoxSmiles.Items306"),
            resources.GetString("comboBoxSmiles.Items307"),
            resources.GetString("comboBoxSmiles.Items308"),
            resources.GetString("comboBoxSmiles.Items309"),
            resources.GetString("comboBoxSmiles.Items310"),
            resources.GetString("comboBoxSmiles.Items311"),
            resources.GetString("comboBoxSmiles.Items312"),
            resources.GetString("comboBoxSmiles.Items313"),
            resources.GetString("comboBoxSmiles.Items314"),
            resources.GetString("comboBoxSmiles.Items315"),
            resources.GetString("comboBoxSmiles.Items316"),
            resources.GetString("comboBoxSmiles.Items317"),
            resources.GetString("comboBoxSmiles.Items318"),
            resources.GetString("comboBoxSmiles.Items319"),
            resources.GetString("comboBoxSmiles.Items320"),
            resources.GetString("comboBoxSmiles.Items321"),
            resources.GetString("comboBoxSmiles.Items322"),
            resources.GetString("comboBoxSmiles.Items323"),
            resources.GetString("comboBoxSmiles.Items324"),
            resources.GetString("comboBoxSmiles.Items325"),
            resources.GetString("comboBoxSmiles.Items326"),
            resources.GetString("comboBoxSmiles.Items327"),
            resources.GetString("comboBoxSmiles.Items328"),
            resources.GetString("comboBoxSmiles.Items329")});
            this.comboBoxSmiles.Name = "comboBoxSmiles";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSmiles);
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
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.on_load);
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).EndInit();
            this.gbx_settings.ResumeLayout(false);
            this.gbx_settings.PerformLayout();
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
		private System.Windows.Forms.RadioButton rb_infinite_messages;
		private System.Windows.Forms.Button brn_about;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboBoxSmiles;
    }
}
