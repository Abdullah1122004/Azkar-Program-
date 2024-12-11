using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammed_Abu_Hadhoud_Cources
{
    public partial class btnLogOut : Form
    {
        float CalculateSize()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else
                return Convert.ToSingle(rbLarge.Tag);
        }
        float CalculateCrust()
        {

            if (rbThick.Checked)
            {
                return Convert.ToSingle(rbThick.Tag);
            }
            else
                return Convert.ToSingle(rbThin.Tag);


        }
        float CalculateToppings()
        {
            float Count = 0;

            if (chbExtraCheese.Checked)
            {
                Count += Convert.ToSingle(chbExtraCheese.Tag);
            }

            if (chbOnin.Checked)
            {
                Count += Convert.ToSingle(chbOnin.Tag);
            }

            if (chbMushroom.Checked)
            {
                Count += Convert.ToSingle(chbMushroom.Tag);
            }

            if (chbOlives.Checked)
            {
                Count += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbTomatos.Checked)
            {
                Count += Convert.ToSingle(chbTomatos.Tag);
            }

            if (chbGreenPepers.Checked)
            {
                Count += Convert.ToSingle(chbGreenPepers.Tag);
            }

            return Count;

        }

        float CalculateTotalPrice()
        {
            return CalculateSize() + CalculateCrust() + CalculateToppings();
        }

        void UpdateTotalPrice()
        {
            lbTotalBrice.Text = "$" + CalculateTotalPrice().ToString();
        }


        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lbSizeText.Text = "Small";
            }

            if (rbMedium.Checked)
            {
                lbSizeText.Text = "Medium";
            }

            if (rbLarge.Checked)
            {
                lbSizeText.Text = "Large";
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                label3.Text = "Thin";
            }

            if (rbThick.Checked)
            {
                label3.Text = "Thick";
            }
        }
        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text = "Eat In";
            }

            if (rbTackOut.Checked)
            {
                lbWhereToEat.Text = "Take Out";
            }
        }


        void GetToppingsString()
        {
            UpdateTotalPrice();

            string Stopping = "";

            if (chbExtraCheese.Checked)
            {
                Stopping = chbExtraCheese.Text;
            }

            if (chbOnin.Checked)
            {
                Stopping += ", " + chbOnin.Text;
            }

            if (chbMushroom.Checked)
            {
                Stopping += ", " + chbMushroom.Text;
            }

            if (chbOlives.Checked)
            {
                Stopping += ", " + chbOlives.Text;
            }

            if (chbTomatos.Checked)
            {
                Stopping += ", " + chbTomatos.Text;
            }

            if (chbGreenPepers.Checked)
            {
                Stopping += ", " + chbGreenPepers.Text;
            }

            if (Stopping.StartsWith(","))
            {
                Stopping = Stopping.Substring(1, Stopping.Length - 1).Trim();
            }

            if (Stopping == "")
            {
                Stopping = "No Toppings";
            }

            lbUserCheckToppigns.Text = Stopping;
        }

        public btnLogOut()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rbMedium.Checked = true;

            rbThin.Checked = true;

            rbEatIn.Checked = true;


        }


        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsString();
        }

        private void chbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsString();
        }

        private void chbOnin_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsString();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsString();
        }

        private void chbTomatos_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsString();
        }

        private void chbGreenPepers_CheckedChanged(object sender, EventArgs e)
        {
            GetToppingsString();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;

                btnOrderPizza.Enabled = false;

                numericUpDown1.Enabled = false;
            }
        }

        private void btnRecetForm_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                gbSize.Enabled = true;
                gbCrust.Enabled = true;
                gbToppings.Enabled = true;
                gbWhereToEat.Enabled = true;

                btnOrderPizza.Enabled = true;

                numericUpDown1.Enabled = true;
                numericUpDown1.Value = 1;


                rbMedium.Checked = true;

                rbThin.Checked = true;

                rbEatIn.Checked = true;


                chbExtraCheese.Checked = false;
                chbOnin.Checked = false;
                chbMushroom.Checked = false;
                chbOlives.Checked = false;
                chbTomatos.Checked = false;
                chbGreenPepers.Checked = false;
            }
        }

        private void btnTicTac_Click(object sender, EventArgs e)
        {
            Form frm = new TicTacToeGame();

            frm.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbTotalBrice.Text = "$" + (CalculateTotalPrice() * (float)numericUpDown1.Value);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbTotalBrice_Click(object sender, EventArgs e)
        {

        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
