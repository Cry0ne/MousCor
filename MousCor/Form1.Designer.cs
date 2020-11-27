namespace MousCor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_x = new System.Windows.Forms.Label();
            this.lb_y = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.t_timer_update = new System.Windows.Forms.Timer(this.components);
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.Bt_Help = new System.Windows.Forms.Button();
            this.P_settings = new System.Windows.Forms.Panel();
            this.lb_by_Cryton = new System.Windows.Forms.Label();
            this.cb_topmost = new System.Windows.Forms.CheckBox();
            this.tb_hk_ss = new System.Windows.Forms.TextBox();
            this.lb_ss = new System.Windows.Forms.Label();
            this.lb_hotkey = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.P_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_x.Location = new System.Drawing.Point(26, 43);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(63, 29);
            this.lb_x.TabIndex = 0;
            this.lb_x.Text = "X = ";
            // 
            // lb_y
            // 
            this.lb_y.AutoSize = true;
            this.lb_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_y.Location = new System.Drawing.Point(26, 83);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(62, 29);
            this.lb_y.TabIndex = 1;
            this.lb_y.Text = "Y = ";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_start.Location = new System.Drawing.Point(17, 131);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(156, 32);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            this.bt_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bt_start_KeyDown);
            // 
            // t_timer_update
            // 
            this.t_timer_update.Interval = 1;
            this.t_timer_update.Tick += new System.EventHandler(this.Timer_update_Tick);
            // 
            // tb_x
            // 
            this.tb_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_x.Location = new System.Drawing.Point(84, 40);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(89, 36);
            this.tb_x.TabIndex = 3;
            // 
            // tb_y
            // 
            this.tb_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_y.Location = new System.Drawing.Point(84, 80);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(89, 36);
            this.tb_y.TabIndex = 4;
            // 
            // Bt_Help
            // 
            this.Bt_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Help.Location = new System.Drawing.Point(17, 6);
            this.Bt_Help.Name = "Bt_Help";
            this.Bt_Help.Size = new System.Drawing.Size(157, 28);
            this.Bt_Help.TabIndex = 5;
            this.Bt_Help.Text = "Settings";
            this.Bt_Help.UseVisualStyleBackColor = true;
            this.Bt_Help.Click += new System.EventHandler(this.Bt_Help_Click);
            // 
            // P_settings
            // 
            this.P_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_settings.Controls.Add(this.lb_by_Cryton);
            this.P_settings.Controls.Add(this.cb_topmost);
            this.P_settings.Controls.Add(this.tb_hk_ss);
            this.P_settings.Controls.Add(this.lb_ss);
            this.P_settings.Controls.Add(this.lb_hotkey);
            this.P_settings.Location = new System.Drawing.Point(17, 33);
            this.P_settings.Name = "P_settings";
            this.P_settings.Size = new System.Drawing.Size(156, 133);
            this.P_settings.TabIndex = 6;
            this.P_settings.Visible = false;
            // 
            // lb_by_Cryton
            // 
            this.lb_by_Cryton.AutoSize = true;
            this.lb_by_Cryton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_by_Cryton.Location = new System.Drawing.Point(88, 115);
            this.lb_by_Cryton.Name = "lb_by_Cryton";
            this.lb_by_Cryton.Size = new System.Drawing.Size(68, 17);
            this.lb_by_Cryton.TabIndex = 6;
            this.lb_by_Cryton.Text = "by Cryton";
            // 
            // cb_topmost
            // 
            this.cb_topmost.AutoSize = true;
            this.cb_topmost.Location = new System.Drawing.Point(4, 82);
            this.cb_topmost.Name = "cb_topmost";
            this.cb_topmost.Size = new System.Drawing.Size(85, 21);
            this.cb_topmost.TabIndex = 5;
            this.cb_topmost.Text = "Topmost";
            this.cb_topmost.UseVisualStyleBackColor = true;
            this.cb_topmost.Click += new System.EventHandler(this.Cb_topmost_Click);
            // 
            // tb_hk_ss
            // 
            this.tb_hk_ss.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_hk_ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_hk_ss.Location = new System.Drawing.Point(4, 49);
            this.tb_hk_ss.Name = "tb_hk_ss";
            this.tb_hk_ss.ReadOnly = true;
            this.tb_hk_ss.Size = new System.Drawing.Size(147, 26);
            this.tb_hk_ss.TabIndex = 4;
            this.tb_hk_ss.TextChanged += new System.EventHandler(this.Tb_hk_ss_TextChanged);
            this.tb_hk_ss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_hk_ss_KeyDown);
            this.tb_hk_ss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_hk_ss_KeyPress);
            // 
            // lb_ss
            // 
            this.lb_ss.AutoSize = true;
            this.lb_ss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ss.Location = new System.Drawing.Point(3, 29);
            this.lb_ss.Name = "lb_ss";
            this.lb_ss.Size = new System.Drawing.Size(89, 20);
            this.lb_ss.TabIndex = 3;
            this.lb_ss.Text = "Start/Stop:";
            // 
            // lb_hotkey
            // 
            this.lb_hotkey.AutoSize = true;
            this.lb_hotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_hotkey.Location = new System.Drawing.Point(3, 3);
            this.lb_hotkey.Name = "lb_hotkey";
            this.lb_hotkey.Size = new System.Drawing.Size(61, 20);
            this.lb_hotkey.TabIndex = 2;
            this.lb_hotkey.Text = "Hotkey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 178);
            this.Controls.Add(this.P_settings);
            this.Controls.Add(this.Bt_Help);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_y);
            this.Controls.Add(this.lb_x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MousCor";
            this.TopMost = global::MousCor.Properties.Settings.Default.Topmost;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.P_settings.ResumeLayout(false);
            this.P_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.Label lb_y;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Timer t_timer_update;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Button Bt_Help;
        private System.Windows.Forms.Panel P_settings;
        private System.Windows.Forms.TextBox tb_hk_ss;
        private System.Windows.Forms.Label lb_ss;
        private System.Windows.Forms.Label lb_hotkey;
        private System.Windows.Forms.CheckBox cb_topmost;
        private System.Windows.Forms.Label lb_by_Cryton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

