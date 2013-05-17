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
            this.button1 = new System.Windows.Forms.Button();
            this.skype_protokol = new System.Windows.Forms.NumericUpDown();
            this.lbl_protocol = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_flood_text
            // 
            this.txt_flood_text.Location = new System.Drawing.Point(12, 115);
            this.txt_flood_text.Multiline = true;
            this.txt_flood_text.Name = "txt_flood_text";
            this.txt_flood_text.Size = new System.Drawing.Size(258, 147);
            this.txt_flood_text.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "FLOOD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skype_protokol
            // 
            this.skype_protokol.Location = new System.Drawing.Point(111, 89);
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
            this.skype_protokol.Size = new System.Drawing.Size(159, 20);
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
            this.lbl_protocol.Location = new System.Drawing.Point(12, 89);
            this.lbl_protocol.Name = "lbl_protocol";
            this.lbl_protocol.Size = new System.Drawing.Size(81, 13);
            this.lbl_protocol.TabIndex = 3;
            this.lbl_protocol.Text = "Skype protocol:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(9, 66);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(96, 13);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Target user\'s login:";
            // 
            // txt_target
            // 
            this.txt_target.Location = new System.Drawing.Point(111, 63);
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(159, 20);
            this.txt_target.TabIndex = 5;
            this.txt_target.Text = "kasthack";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(276, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(234, 199);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 301);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_protocol);
            this.Controls.Add(this.skype_protokol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_flood_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skype Flooder+";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skype_protokol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_flood_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown skype_protokol;
        private System.Windows.Forms.Label lbl_protocol;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.ListBox listBox1;
    }
}

