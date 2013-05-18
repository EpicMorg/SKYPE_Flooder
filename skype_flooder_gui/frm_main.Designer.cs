namespace skype_flooder_gui
{
    partial class frm_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_flood_text = new System.Windows.Forms.TextBox();
            this.btn_flooding = new System.Windows.Forms.Button();
            this.skype_protokol = new System.Windows.Forms.NumericUpDown();
            this.lbl_protocol = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.list_users = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbx_settings = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_flood_text
            // 
            this.txt_flood_text.Location = new System.Drawing.Point(12, 342);
            this.txt_flood_text.Multiline = true;
            this.txt_flood_text.Name = "txt_flood_text";
            this.txt_flood_text.Size = new System.Drawing.Size(588, 147);
            this.txt_flood_text.TabIndex = 0;
            // 
            // btn_flooding
            // 
            this.btn_flooding.Location = new System.Drawing.Point(525, 495);
            this.btn_flooding.Name = "btn_flooding";
            this.btn_flooding.Size = new System.Drawing.Size(75, 23);
            this.btn_flooding.TabIndex = 1;
            this.btn_flooding.Text = "FLOOD";
            this.btn_flooding.UseVisualStyleBackColor = true;
            this.btn_flooding.Click += new System.EventHandler(this.button1_Click);
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
            this.list_users.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::skype_flooder_gui.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gbx_settings
            // 
            this.gbx_settings.Location = new System.Drawing.Point(15, 189);
            this.gbx_settings.Name = "gbx_settings";
            this.gbx_settings.Size = new System.Drawing.Size(273, 147);
            this.gbx_settings.TabIndex = 8;
            this.gbx_settings.TabStop = false;
            this.gbx_settings.Text = "Settings";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 532);
            this.Controls.Add(this.gbx_settings);
            this.Controls.Add(this.pictureBox1);
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
            this.Text = "Skype Flooder+";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbx_settings;
    }
}

