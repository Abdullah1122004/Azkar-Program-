using Mohammed_Abu_Hadhoud_Cources.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Versioning;
using Microsoft.Win32;

namespace Mohammed_Abu_Hadhoud_Cources
{
    public partial class FirstProject : Form
    {
        public FirstProject()
        {
            InitializeComponent();
        }

        private void EnabledMainButtons()
        {
            btnAltsbe7.Enabled = true;
            btnAlesgfar.Enabled = true;
            btnAlto7ed.Enabled = true;
            btnElHamd.Enabled = true;
            btnAkbr.Enabled = true;


            lable2.Visible = false;
        }

        private void rb33_CheckedChanged_1(object sender, EventArgs e)
        {
            EnabledMainButtons();
        }
        private void rb70_CheckedChanged(object sender, EventArgs e)
        {
            EnabledMainButtons();
        }
        private void rb100_CheckedChanged(object sender, EventArgs e)
        {
            EnabledMainButtons();
        }
        private void rbn1000_CheckedChanged(object sender, EventArgs e)
        {
            EnabledMainButtons();
        }

        private void SetButton(Button sender)
        {
            lblHowNamy.Visible = false;
            panel1.Visible = false;

            lblCounter.Visible = true;
            btnTap.Visible = true;
            btnTAP3.Visible = true;

            btnAlesgfar.Visible = false;
            btnAlto7ed.Visible = false;
            btnAltsbe7.Visible = false;
            btnElHamd.Visible = false;
            btnAkbr.Visible = false;
            lblBenefitsOfZekr.Visible = false;
            lblBenefitsOfZekr2.Visible = false;


            sender.Visible = true;


            if (rb33.Checked)
            {
                sender.Tag = 33;
            }

            if (rb70.Checked)
            {
                sender.Tag = 70;
            }

            if (rb100.Checked)
            {
                sender.Tag = 100;
            }

            if (rbn1000.Checked)
            {
                sender.Tag = 1000;
            }

        }
        private void btnAltsbe7_Click(object sender, EventArgs e)
        {
            SetButton(btnAltsbe7_2);

           btnTap.Tag = 1;
        }
        private void btnAlto7ed_Click(object sender, EventArgs e)
        {
            SetButton(btnAlto7ed2);

            btnTap.Tag = 2;
        }
        private void btnAlesgfar_Click(object sender, EventArgs e)
        {
            SetButton(btnAlesgfar2);

            btnTap.Tag = 3;
        }

        private void btnElHamd_Click(object sender, EventArgs e)
        {
            SetButton(btnElhmd_2);

            btnTap.Tag = 4;
        }

        private void btnAkbr_Click(object sender, EventArgs e)
        {
            SetButton(btnAkber_2);

            btnTap.Tag = 5;
        }



        private int Counter = 0;
        private int Lap = 0;
        private int LapForGame = 0;
        private void SetTAP(Button button)
        {
            
            Counter++;
            
            lblCounter.Text = Counter.ToString();

            if (lblCounter.Text == button.Tag.ToString())
            {
                lblCounter.Text = "0";
                Counter = 0;

                lblHowNamy.Visible = true;
                panel1.Visible = true;

                button.Visible = false;

                btnAlesgfar.Visible = true;
                btnAlto7ed.Visible = true;
                btnAltsbe7.Visible = true;
                btnElHamd.Visible = true;
                btnAkbr.Visible = true;

                btnTap.Visible = false;
                btnTAP3.Visible = false;
                lblCounter.Visible = false;


                Lap++; LapForGame++;
                MessageBox.Show("Congratlation You Finshed " + Lap + " Lap(s)", "end lap");
                

                btnTap.Tag = 0;
            }
        }
        private void btnTap_Click(object sender, EventArgs e)
        {

            switch (btnTap.Tag)
            {

                case 1:

                    {
                        SetTAP(btnAltsbe7_2);
                        break;
                    }

                case 2:
                    {
                        SetTAP(btnAlto7ed2);
                        break;
                    }

                case 3:
                    {
                        SetTAP(btnAlesgfar2);
                        break;
                    }

                case 4:
                    {
                        SetTAP(btnElhmd_2);
                        break;
                    }

                case 5:
                    {
                        SetTAP(btnAkber_2);
                        break;
                    }
                   
            }
        }

        private void btnTAP3_Click(object sender, EventArgs e)
        {
            Counter += 2;

            switch (btnTap.Tag)
            {

                case 1:

                    {
                     
                        SetTAP(btnAltsbe7_2);
                        break;
                    }

                case 2:
                    {
                      
                        SetTAP(btnAlto7ed2);
                        break;
                    }

                case 3:
                    {
                      
                        SetTAP(btnAlesgfar2);
                        break;
                    }

                case 4:
                    {
                       
                        SetTAP(btnElhmd_2);
                        break;
                    }

                case 5:
                    {
                        
                        SetTAP(btnAkber_2);
                        break;
                    }

            }
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {

            if (LapForGame == 3)
            {
                Form frm = new TicTacToeGame();

                frm.Show();

                LapForGame = 0;
            }
            else
                MessageBox.Show("You should Finsh  3 laps <<< You Finish " + LapForGame + " Lap(s)", "Before you play", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
