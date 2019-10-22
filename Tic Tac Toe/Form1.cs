using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        // BoardMatrix, whoseTurn, whoAreYou: 1 <=> X; 0 <=> O; -1 <=> no one

        class BoardMatrix
        {
            public int[][] m;

            public void InitializeOfMatrix()
            {
                m[0][0] = -1;
                m[0][1] = -1;
                m[0][2] = -1;

                m[1][0] = -1;
                m[1][1] = -1;
                m[1][2] = -1;

                m[2][0] = -1;
                m[2][1] = -1;
                m[2][2] = -1;
            }

            public BoardMatrix()
            {
                m = new int[3][];
                for (int i = 0; i < 3; ++i)
                    m[i] = new int[3];

                InitializeOfMatrix();
            }
        }
        BoardMatrix boardMatrix;

        enum ModeGame {NOT_PLAYING = 0, PLAYING_1 = 1, PLAYING_2 = 2};
        ModeGame modeGame;
        int whoseTurn;
        int whoAreYou;
        bool finishedGame;

        public Form1()
        {
            InitializeComponent();
            label1.Text = null;

            boardMatrix = new BoardMatrix();
            modeGame = ModeGame.NOT_PLAYING;
            whoseTurn = -1;
            whoAreYou = -1;
            finishedGame = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int Did_Somebody_Won()
        {
            if (boardMatrix.m[0][0] == boardMatrix.m[0][1] &&
                boardMatrix.m[0][1] == boardMatrix.m[0][2] && boardMatrix.m[0][0] != -1)
            {
                return boardMatrix.m[0][0];
            }

            if (boardMatrix.m[1][0] == boardMatrix.m[1][1] &&
                boardMatrix.m[1][1] == boardMatrix.m[1][2] && boardMatrix.m[1][0] != -1)
            {
                return boardMatrix.m[1][0];
            }

            if (boardMatrix.m[2][0] == boardMatrix.m[2][1] &&
                boardMatrix.m[2][1] == boardMatrix.m[2][2] && boardMatrix.m[2][0] != -1)
            {
                return boardMatrix.m[2][0];
            }

            if (boardMatrix.m[0][0] == boardMatrix.m[1][0] &&
                boardMatrix.m[1][0] == boardMatrix.m[2][0] && boardMatrix.m[0][0] != -1)
            {
                return boardMatrix.m[0][0];
            }

            if (boardMatrix.m[0][1] == boardMatrix.m[1][1] &&
                boardMatrix.m[1][1] == boardMatrix.m[2][1] && boardMatrix.m[0][1] != -1)
            {
                return boardMatrix.m[0][1];
            }

            if (boardMatrix.m[0][2] == boardMatrix.m[1][2] &&
                boardMatrix.m[1][2] == boardMatrix.m[2][2] && boardMatrix.m[0][2] != -1)
            {
                return boardMatrix.m[0][2];
            }

            if (boardMatrix.m[0][0] == boardMatrix.m[1][1] &&
                boardMatrix.m[1][1] == boardMatrix.m[2][2] && boardMatrix.m[0][0] != -1)
            {
                return boardMatrix.m[0][0];
            }

            if (boardMatrix.m[0][2] == boardMatrix.m[1][1] &&
                boardMatrix.m[1][1] == boardMatrix.m[2][0] && boardMatrix.m[0][2] != -1)
            {
                return boardMatrix.m[0][2];
            }

            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[0][0] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[0][0] = 0;
                    button1.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[0][0] = 1;
                    button1.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                } else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[0][1] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[0][1] = 0;
                    button2.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[0][1] = 1;
                    button2.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[0][2] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[0][2] = 0;
                    button3.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[0][2] = 1;
                    button3.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[1][0] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[1][0] = 0;
                    button4.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[1][0] = 1;
                    button4.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[1][1] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[1][1] = 0;
                    button5.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[1][1] = 1;
                    button5.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[1][2] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[1][2] = 0;
                    button6.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[1][2] = 1;
                    button6.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[2][0] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[2][0] = 0;
                    button7.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[2][0] = 1;
                    button7.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[2][1] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[2][1] = 0;
                    button8.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[2][1] = 1;
                    button8.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (modeGame == ModeGame.NOT_PLAYING)
            {
                return;
            }

            if (modeGame == ModeGame.PLAYING_1 && whoseTurn != whoAreYou)
            {
                return;
            }

            if (finishedGame == true)
            {
                return;
            }

            if (boardMatrix.m[2][2] == -1)
            {
                if (whoseTurn == 0)
                {
                    boardMatrix.m[2][2] = 0;
                    button9.BackgroundImage = Properties.Resources._0;
                    whoseTurn = 1;
                } else if (whoseTurn == 1)
                {
                    boardMatrix.m[2][2] = 1;
                    button9.BackgroundImage = Properties.Resources.x;
                    whoseTurn = 0;
                }
            }

            if (Did_Somebody_Won() != -1)
            {
                finishedGame = true;
                if (Did_Somebody_Won() == 1)
                {
                    label1.Text = "X WON!";
                }
                else
                {
                    label1.Text = "0 WON!";
                }
            }
        }

        private void players1_button_Click(object sender, EventArgs e)
        {
            boardMatrix.InitializeOfMatrix();
            modeGame = ModeGame.PLAYING_1;
            whoseTurn = 1;
            finishedGame = false;

            players1_button.Visible = false;
            players2_button.Visible = false;

            exit_button.Visible = true;
            chooseX_button.Visible = true;
            choose0_button.Visible = true;
        }

        private void players2_button_Click(object sender, EventArgs e)
        {
            boardMatrix.InitializeOfMatrix();
            modeGame = ModeGame.PLAYING_2;
            whoseTurn = 1;
            finishedGame = false;

            players1_button.Visible = false;
            players2_button.Visible = false;

            exit_button.Visible = true;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            button4.BackgroundImage = null;
            button5.BackgroundImage = null;
            button6.BackgroundImage = null;
            button7.BackgroundImage = null;
            button8.BackgroundImage = null;
            button9.BackgroundImage = null;
            label1.Text = null;
            whoAreYou = -1;

            exit_button.Visible = false;
            chooseX_button.Visible = false;
            choose0_button.Visible = false;

            players1_button.Visible = true;
            players2_button.Visible = true;
        }

        private void chooseX_button_Click(object sender, EventArgs e)
        {
            whoAreYou = 1;
            chooseX_button.Visible = false;
            choose0_button.Visible = false;
        }

        private void choose0_button_Click(object sender, EventArgs e)
        {
            whoAreYou = 0;
            chooseX_button.Visible = false;
            choose0_button.Visible = false;
        }

        private int BestMove_X(int[][] state)
        {
            /// MAX

            for (int k = 0; k < 3; ++k)
            {
                if (state[k][0] == 0 && state[k][1] == 0 && state[k][2] == 0) return -1; /// O win
                if (state[0][k] == 0 && state[1][k] == 0 && state[2][k] == 0) return -1; /// O win
            }
            if (state[0][0] == 0 && state[1][1] == 0 && state[2][2] == 0) return -1; /// O win
            if (state[0][2] == 0 && state[1][1] == 0 && state[2][0] == 0) return -1; /// O win

            int inf = 9999999, v, curr_v;
            v = -inf;

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (state[i][j] == -1)
                    {
                        state[i][j] = 1; /// put X

                        curr_v = BestMove_O(state);
                        if (v < curr_v)
                        {
                            v = curr_v;
                        }

                        state[i][j] = -1;
                    }

            if (v == (-inf))
                v = 0;

            return v;
        }

        private int BestMove_O(int[][] state)
        {
            /// MIN

            for (int k = 0; k < 3; ++k)
            {
                if (state[k][0] == 1 && state[k][1] == 1 && state[k][2] == 1) return 1; /// X win
                if (state[0][k] == 1 && state[1][k] == 1 && state[2][k] == 1) return 1; /// X win
            }
            if (state[0][0] == 1 && state[1][1] == 1 && state[2][2] == 1) return 1; /// X win
            if (state[0][2] == 1 && state[1][1] == 1 && state[2][0] == 1) return 1; /// X win

            int inf = 9999999, v, curr_v;
            v = inf;

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (state[i][j] == -1)
                    {
                        state[i][j] = 0; /// put

                        curr_v = BestMove_X(state);
                        if (v > curr_v)
                        {
                            v = curr_v;
                        }

                        state[i][j] = -1;
                    }

            if (v == inf)
                v = 0;

            return v;
        }

        private int MinMax_ticTacToe(int[][] state, int whoPlay)
        {
            int[] vect_ret = new int[9];
            Random rnd = new Random();
            int inf = 9999999, v = 0, curr_v, ret = 0, contor = 0;

            if (whoPlay == 1)
            {
                v = -inf;
            }
            else if (whoPlay == 0)
            {
                v = +inf;
            }

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (state[i][j] != -1)
                        continue;

                    if (whoPlay == 1)
                    {
                        state[i][j] = 1; /// put X
                        curr_v = BestMove_O(state);
                        state[i][j] = -1;

                        if (v < curr_v)
                        {
                            v = curr_v;
                            ret = i * 3 + j + 1;

                            contor = 0;
                            vect_ret[contor] = ret;
                            contor++;
                        } else if (v == curr_v)
                        {
                            ret = i * 3 + j + 1;

                            vect_ret[contor] = ret;
                            contor++;
                        }
                    }
                    else if (whoPlay == 0)
                    {
                        state[i][j] = 0; /// put
                        curr_v = BestMove_X(state);
                        state[i][j] = -1;

                        if (v > curr_v)
                        {
                            v = curr_v;
                            ret = i * 3 + j + 1;

                            contor = 0;
                            vect_ret[contor] = ret;
                            contor++;
                        }
                        else if (v == curr_v)
                        {
                            ret = i * 3 + j + 1;

                            vect_ret[contor] = ret;
                            contor++;
                        }
                    }
                }
            }

            if (v == inf || v == -inf)
            {
                return ret;
            } else
            {
                return vect_ret[rnd.Next(0, contor)];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ret, i, j;

            if (modeGame == ModeGame.PLAYING_1 &&
                finishedGame == false &&
                whoAreYou != -1) {
                if (whoseTurn != whoAreYou)
                {
                    ret = MinMax_ticTacToe(boardMatrix.m, whoseTurn);
                    if (ret == 0)
                    {
                        return;
                    }

                    i = (ret - 1) / 3;
                    j = (ret - 1) % 3;

                    if (whoseTurn == 0)
                    {
                        boardMatrix.m[i][j] = 0;
                        switch (ret)
                        {
                            case 1:
                                button1.BackgroundImage = Properties.Resources._0;
                                break;
                            case 2:
                                button2.BackgroundImage = Properties.Resources._0;
                                break;
                            case 3:
                                button3.BackgroundImage = Properties.Resources._0;
                                break;
                            case 4:
                                button4.BackgroundImage = Properties.Resources._0;
                                break;
                            case 5:
                                button5.BackgroundImage = Properties.Resources._0;
                                break;
                            case 6:
                                button6.BackgroundImage = Properties.Resources._0;
                                break;
                            case 7:
                                button7.BackgroundImage = Properties.Resources._0;
                                break;
                            case 8:
                                button8.BackgroundImage = Properties.Resources._0;
                                break;
                            case 9:
                                button9.BackgroundImage = Properties.Resources._0;
                                break;
                            default:
                                break;
                        }
                        whoseTurn = 1;
                    }
                    else if (whoseTurn == 1)
                    {
                        boardMatrix.m[i][j] = 1;
                        switch (ret)
                        {
                            case 1:
                                button1.BackgroundImage = Properties.Resources.x;
                                break;
                            case 2:
                                button2.BackgroundImage = Properties.Resources.x;
                                break;
                            case 3:
                                button3.BackgroundImage = Properties.Resources.x;
                                break;
                            case 4:
                                button4.BackgroundImage = Properties.Resources.x;
                                break;
                            case 5:
                                button5.BackgroundImage = Properties.Resources.x;
                                break;
                            case 6:
                                button6.BackgroundImage = Properties.Resources.x;
                                break;
                            case 7:
                                button7.BackgroundImage = Properties.Resources.x;
                                break;
                            case 8:
                                button8.BackgroundImage = Properties.Resources.x;
                                break;
                            case 9:
                                button9.BackgroundImage = Properties.Resources.x;
                                break;
                            default:
                                break;
                        }
                        whoseTurn = 0;
                    }

                    if (Did_Somebody_Won() != -1)
                    {
                        finishedGame = true;
                        if (Did_Somebody_Won() == 1)
                        {
                            label1.Text = "X WON!";
                        }
                        else
                        {
                            label1.Text = "0 WON!";
                        }
                    }
                    return;
                }
            }
        }
    }
}
