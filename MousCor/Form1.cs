using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MousCor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_hk_ss.Text = Properties.Settings.Default.stringhk.ToUpper();
            cb_topmost.Checked = Properties.Settings.Default.Topmost;

        }

        private void Bt_start_Click(object sender, EventArgs e)
        {
            if (t_timer_update.Enabled == false)
            {
                t_timer_update.Enabled = true;
                bt_start.Text = "Stop";
            }
            else
            {
                t_timer_update.Enabled = false;
                bt_start.Text = "Start";
            }       
        }

        private void Timer_update_Tick(object sender, EventArgs e)
        {
            tb_x.Text = Cursor.Position.X.ToString();
            tb_y.Text = Cursor.Position.Y.ToString();
        }

        private void Bt_Help_Click(object sender, EventArgs e)
        {

            if (P_settings.Visible == false)
            {
                P_settings.Visible = true;
                Bt_Help.Text = "Save";

                t_timer_update.Enabled = false;
                bt_start.Text = "Start";
            }
            else
            {
                P_settings.Visible = false;
                Bt_Help.Text = "Settings";
                
                Properties.Settings.Default.Save();
                bt_start.Focus();
                
            }
        }

        private void Bt_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Properties.Settings.Default.keyss)
            {
                if (t_timer_update.Enabled == false)
                {
                    t_timer_update.Enabled = true;
                    bt_start.Text = "Stop";
                }
                else
                {
                    t_timer_update.Enabled = false;
                    bt_start.Text = "Start";
                }
            }
        }

        private void Tb_hk_ss_KeyDown(object sender, KeyEventArgs e)
        {
            tb_hk_ss.Text = "";
            tb_hk_ss.Text = e.KeyCode.ToString().ToUpper();
            Properties.Settings.Default.keyss = e.KeyCode;
        }

        

        private void Form1_Click(object sender, EventArgs e)
        {
            bt_start.Focus();
        }

        private void Tb_hk_ss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar!= '')
            {
                tb_hk_ss.Text = "";
                tb_hk_ss.Text = e.KeyChar.ToString().ToUpper();
                Properties.Settings.Default.charkeyss = e.KeyChar;
            }
            
            
        }

        private void Tb_hk_ss_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.stringhk = tb_hk_ss.Text;
        }

        private void Cb_topmost_Click(object sender, EventArgs e)
        {
            if (cb_topmost.Checked == true)
            {
                Properties.Settings.Default.Topmost = true;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                Properties.Settings.Default.Topmost = false;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }
    }
}
