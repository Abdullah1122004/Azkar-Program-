using Microsoft.Win32;
using Mohammed_Abu_Hadhoud_Cources.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammed_Abu_Hadhoud_Cources
{
    public partial class TicTacToeGame : Form
    {
      
        enum enPlayer { MAMA, Abdullah};

        enPlayer PlayerTurn = enPlayer.MAMA;


        enum enWinner { MAMA, Abdullah, Draw, GameInPrograss};

        stGameStatus GameStatus;
        struct stGameStatus
        {
            public enWinner Winner;

            public bool GameOver;
            public byte PlayCount;

            public Button btn1, btn2, btn3;
        }

        private void RestButton(Button btn)
        {
            btn.Image = Resources.Qes;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
            btn.Enabled = true;
        }
        private void RestartGame()
        {
            RestButton(button1);
            RestButton(button2);
            RestButton(button3);
            RestButton(button4);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);

            GameStatus.GameOver = false;
            PlayerTurn = enPlayer.MAMA;
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInPrograss;
            lbWinner.Text = "In Prograss";
            lbTurn.Text = "MAMA ";
        }

        public void EndGame()
        {
           

            lbTurn.Text = "Game Over";

            switch(GameStatus.Winner)
            {
                case enWinner.MAMA:

                    lbWinner.Text = " MAMA";
                    break;

                case enWinner.Abdullah:

                    lbWinner.Text = "Abdullah";
                    break;

                default:

                    lbWinner.Text = "Draw";
                    break;

            }


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            GameStatus.btn1.Enabled = true;
            GameStatus.btn2.Enabled = true;
            GameStatus.btn3.Enabled = true;

            MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() &&
                btn2.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;

                GameStatus.btn1 = btn1;
                GameStatus.btn2 = btn2;
                GameStatus.btn3 = btn3;

                GameStatus.GameOver = true;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.MAMA;
                    EndGame();
                    return true;
                }
                else
                    GameStatus.Winner = enWinner.Abdullah;
                    EndGame();
                    return true;

            }

            GameStatus.GameOver = false;
            return false;
        }
                
        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;

            if (CheckValues(button4, button5, button6))
                return;

            if (CheckValues(button7, button8, button9))
                return;



            if (CheckValues(button3, button6, button9))
                return;

            if (CheckValues(button2, button5, button8))
                return;

            if (CheckValues(button1, button4, button7))
                return;



            if (CheckValues(button1, button5, button9))
                return;

            if (CheckValues(button3, button5, button7))
                return;


        }

        public void ChangeImage(Button btn)
        {

            if (GameStatus.GameOver == true)
            {
                EndGame();
            }

            if (btn.Tag.ToString() == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.MAMA:

                        PlayerTurn = enPlayer.Abdullah;
                        btn.Image = Resources.x_koko;
                        lbTurn.Text = "Abdullah";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();

                        break;

                    case enPlayer.Abdullah:

                        PlayerTurn = enPlayer.MAMA;
                        btn.Image = Resources.O_koko;
                        lbTurn.Text = "MAMA";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();

                        break;
                }
            }

        }

        public TicTacToeGame()
        {
            InitializeComponent();
        }

        private void TempPracticForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TempPracticForm_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);

            Pen WhitePen = new Pen(White);
            WhitePen.Width = 15;

            WhitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            WhitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(WhitePen, 300, 130, 770, 130);
            e.Graphics.DrawLine(WhitePen, 300, 250, 770, 250);

            e.Graphics.DrawLine(WhitePen, 620, 20, 620, 370);
            e.Graphics.DrawLine(WhitePen, 450, 20, 450, 370);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            RestartGame();
        
        }

        private void Button_Click(object Sender, EventArgs e)
        {
            ChangeImage((Button)Sender);
        }
    }
}
