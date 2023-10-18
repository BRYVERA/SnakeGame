using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using WindowsInput.Native;
using WindowsInput;

namespace SnakeGame
{
    #region "Variables"
    public partial class FrmGame : Form
    {
        Timer tmrGame, tmrScore;
        
        PictureBox pictureBox;
        List<PictureBox> Lista1, Lista2;

        int puntaje = 0;
        int puntaje2 = 0;
        int Movimiento = 0;
        int Movimiento2 = 0;

        int x_Movimiento = 0;
        int x_Movimiento2 = 0;
        bool isLabel = false;
        int numberPlayers = 1;
        int lbcontador = 0;

        int snake_X1 = 0; 
        int snake_Y1 = 0; 
        int movimiento_TX1 = 0;
        int movimiento_TY1 = 0; 
        int movimiento_TX2 = 0; 
        int movimiento_TY2 = 0;

        int snake_X2 = 0;
        int snake_Y2 = 0;
        int movimiento_TX3 = 0; 
        int movimiento_TY3 = 0; 
        int movimiento_TX4 = 0; 
        int movimiento_TY4 = 0;
       

        public FrmGame()
        {
            InitializeComponent();
            RestarGame();
        }

        #endregion

        #region "Menu"
        private void NewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Saliendo del juego actual...", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                return;
            }

            PauseGame();

            if (numberPlayers == 2)
            {
                Disconnect();
            }

            using (FrmPlayers frm = new FrmPlayers())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RestarGame();

                    numberPlayers = frm.numberPlayers;

                    if (numberPlayers == 2)
                    {
                        pbSnake2.Visible = true;

                        userName = frm.userName;
                        Client.Connect(this, userName, frm.ipAddress);
                    }
                    else
                    {
                        player2 = true;
                    }
                }
            }
        }
        #endregion
        #region "Configuraciones"
        private void RestarGame()
        {
            currentPlayer = 0; 
            play = true;

            List<PictureBox> temp = this.Controls.OfType<PictureBox>().Where(x => !x.Name.Contains("pb") && (x.Tag.ToString() == "A" || x.Tag.ToString() == "B")).ToList(); // Profesdor Referencia // https://docs.microsoft.com/en-us/search/?scope=.NET&terms=c%23
            foreach (PictureBox c in temp)
            {
                this.Controls.Remove(c);
            }
            pbSnake1.Location = new Point(10, 300);
            pbSnake2.Location = new Point(810, 300);            
             
            tmrGame = new Timer
            {
                Interval = 60
            };
            tmrGame.Tick += TimerGame_Tick;

            tmrScore = new Timer
            {
                Interval = 1000
            };
            tmrScore.Tick += TimerScore_Tick;

            NewPoint();
            StartGame();
        }
        #endregion

        #region "TimerMarcador"
        private void TimerScore_Tick(object sender, EventArgs e)
        {
            if(isLabel)
            {
                lbcontador++;
                label1.Visible = !label1.Visible;

                if (lbcontador == 6)
                {
                    lbcontador = 0;
                    label1.Visible = true;
                    label1.ForeColor = Color.Black;
                    isLabel = false;
                }
            }
        }
        #endregion

        #region "Movimiento"
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            if (!play)
            {
                return;
            }

            snake_X1 = pbSnake1.Location.X;
            snake_Y1 = pbSnake1.Location.Y;

            snake_X2 = pbSnake2.Location.X;
            snake_Y2 = pbSnake2.Location.Y;

            Lista1 = this.Controls.OfType<PictureBox>().Where(x => !x.Name.Contains("pb") && x.Tag.ToString() == "A").ToList(); // Profesor referencia // https://docs.microsoft.com/en-us/search/?scope=.NET&terms=c%23
            Lista2 = this.Controls.OfType<PictureBox>().Where(x => !x.Name.Contains("pb") && x.Tag.ToString() == "B").ToList(); // Profesor referencia // https://docs.microsoft.com/en-us/search/?scope=.NET&terms=c%23

            if (Movimiento == 1)
            {
                pbSnake1.Location = new Point(pbSnake1.Location.X, pbSnake1.Location.Y + 10);
                x_Movimiento = Movimiento;
            }
            else if (Movimiento == 2)
            {
                pbSnake1.Location = new Point(pbSnake1.Location.X, pbSnake1.Location.Y - 10);
                x_Movimiento = Movimiento;
            }
            else if (Movimiento == 3)
            {
                pbSnake1.Location = new Point(pbSnake1.Location.X - 10, pbSnake1.Location.Y);
                x_Movimiento = Movimiento;
            }
            else if (Movimiento == 4)
            {
                pbSnake1.Location = new Point(pbSnake1.Location.X + 10, pbSnake1.Location.Y);
                x_Movimiento = Movimiento;
            }

            if (Movimiento2 == 1)
            {
                pbSnake2.Location = new Point(pbSnake2.Location.X, pbSnake2.Location.Y + 10);
                x_Movimiento2 = Movimiento2;
            }
            else if (Movimiento2 == 2)
            {
                pbSnake2.Location = new Point(pbSnake2.Location.X, pbSnake2.Location.Y - 10);
                x_Movimiento2 = Movimiento2;
            }
            else if (Movimiento2 == 3)
            {
                pbSnake2.Location = new Point(pbSnake2.Location.X - 10, pbSnake2.Location.Y);
                x_Movimiento2 = Movimiento2;
            }
            else if (Movimiento2 == 4)
            {
                pbSnake2.Location = new Point(pbSnake2.Location.X + 10, pbSnake2.Location.Y);
                x_Movimiento2 = Movimiento2;
            }

            for (int i = 0; i < Lista1.Count; i++)
            {
                if (i == 0)
                {
                    movimiento_TX1 = Lista1[i].Location.X;
                    movimiento_TY1 = Lista1[i].Location.Y;

                    Lista1[i].Location = new Point(snake_X1, snake_Y1);
                }
                else
                {
                    movimiento_TX2 = Lista1[i].Location.X;
                    movimiento_TY2 = Lista1[i].Location.Y;

                    Lista1[i].Location = new Point(movimiento_TX1, movimiento_TY1);

                    movimiento_TX1 = movimiento_TX2;
                    movimiento_TY1 = movimiento_TY2;
                }
            }

            for (int i = 0; i < Lista2.Count; i++)
            {
                if (i == 0)
                {
                    movimiento_TX3 = Lista2[i].Location.X;
                    movimiento_TY3 = Lista2[i].Location.Y;

                    Lista2[i].Location = new Point(snake_X2, snake_Y2);
                }
                else
                {
                    movimiento_TX4 = Lista2[i].Location.X;
                    movimiento_TY4 = Lista2[i].Location.Y;

                    Lista2[i].Location = new Point(movimiento_TX3, movimiento_TY3);

                    movimiento_TX3 = movimiento_TX4;
                    movimiento_TY3 = movimiento_TY4;
                }
            }

            Impacto();

            Largo();

            AreaJuego();
            AreaJuego2();

            ImpactoIndividual();
            ImpactoIndividual2();
        }
        #endregion

        #region "Comida"
        private void Largo()
        {
            if (pbSnake1.Location == pbBall.Location)
            {
                pictureBox = new PictureBox // Referencia // https://docs.microsoft.com/en-us/search/?scope=.NET&terms=c%23
                {
                    Location  = new Point(snake_X1, snake_Y1),
                    BackColor = Color.Green,
                    Tag       = "A",
                    Size      = pbSnake1.Size
                };
                this.Controls.Add(pictureBox);

                int scoreWin;

                puntaje++;
                    scoreWin = 1;
                

                isLabel = true;
                lbcontador = 0;
                label1.ForeColor = Color.Black; 

                
                    pbBall.BackColor = Color.Transparent;
                    pbBall.Visible   = true;
                

                NewPoint(scoreWin: scoreWin);
            }

            if (pbSnake2.Location == pbBall.Location)
            {
                pictureBox = new PictureBox // Referencia // https://docs.microsoft.com/en-us/search/?scope=.NET&terms=c%23
                {
                    Location  = new Point(snake_X2, snake_Y2),
                    BackColor = Color.Green,
                    Tag       = "B",
                    Size      = pbSnake2.Size
                };
                this.Controls.Add(pictureBox);

                int scoreWin;

                puntaje2++;
                    scoreWin = 1;
                

                isLabel = true;
                lbcontador = 0;
                label1.ForeColor = Color.Black; // label Marcador

                
                    
                
                    pbBall.BackColor = Color.Transparent;
                    pbBall.Visible   = true;
                

                NewPoint(scoreWin: scoreWin);
            }
        }

        #endregion

        private void pbBall_Click(object sender, EventArgs e)
        {

        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }

        private void pbSnake2_Click(object sender, EventArgs e)
        {

        }
        #region "Comida"
        private void NewPoint(int X = 0, int Y = 0, int scoreWin = 0)
        {
            if (X == 0 && Y == 0)
            {
                Random aletorio = new Random();

                X = aletorio.Next(1, 81) * 10;
                Y = aletorio.Next(5, 54) * 10;

                pbBall.Location = new Point(X, Y);

                SendMessage("point|" + currentPlayer + "|" + X + "|" + Y + "|" + scoreWin);
            }
            else
            {
                pbBall.Location = new Point(X, Y);
            }
            
            if (numberPlayers == 2)
            {
                label1.Text = "1 Jugador " + puntaje + " | " + puntaje2 + " Jugador 2";
            }
            else
            {
                label1.Text = "Puntaje " + puntaje;
            }
        }
        #endregion

        #region "Paredes"
        private void AreaJuego()
        {
            if (pbSnake1.Location.X <= 0 && x_Movimiento == 3)
            {
                pbSnake1.Location = new Point(810, pbSnake1.Location.Y);
            }
            else if (pbSnake1.Location.X >= 810 && x_Movimiento == 4)
            {
                pbSnake1.Location = new Point(0, pbSnake1.Location.Y);
            }
            else if (pbSnake1.Location.Y <= 40 && x_Movimiento == 2)
            {
                pbSnake1.Location = new Point(pbSnake1.Location.X, 540);
            }
            else if (pbSnake1.Location.Y >= 540 && x_Movimiento == 1)
            {
                pbSnake1.Location = new Point(pbSnake1.Location.X, 40);
            }
        }

        private void AreaJuego2()
        {
            if (pbSnake2.Location.X <= 0 && x_Movimiento2 == 3)
            {
                pbSnake2.Location = new Point(810, pbSnake2.Location.Y);
            }
            else if (pbSnake2.Location.X >= 810 && x_Movimiento2 == 4)
            {
                pbSnake2.Location = new Point(0, pbSnake2.Location.Y);
            }
            else if (pbSnake2.Location.Y <= 40 && x_Movimiento2 == 2)
            {
                pbSnake2.Location = new Point(pbSnake2.Location.X, 540);
            }
            else if (pbSnake2.Location.Y >= 540 && x_Movimiento2 == 1)
            {
                pbSnake2.Location = new Point(pbSnake2.Location.X, 40);
            }
        }

        #endregion

        #region "Colisiones"

        private void ImpactoIndividual()
        {
            if (currentPlayer != 0) return;

            for (int i = 0; i < Lista1.Count; i++)
            {
                if (Lista1[i].Location == pbSnake1.Location)
                {
                    Loser();
                    return;
                }
            }
        }

        private void ImpactoIndividual2()
        {
            if (currentPlayer != 0) return;

            for (int i = 0; i < Lista2.Count; i++)
            {
                if (Lista2[i].Location == pbSnake2.Location)
                {
                    Loser();
                    return;
                }
            }
        }

        #endregion

        #region "Colision"
        private void Impacto()
        {
            if (numberPlayers == 2)
            {
                if (pbSnake1.Location == pbSnake2.Location)
                {
                    SendMessage("gameo" + currentPlayer);
                    GameOver();                    
                }
                else
                {
                    for (int i = 0; i < Lista1.Count; i++)
                    {
                        for (int j = 0; j < Lista2.Count; j++)
                        {
                            if (Lista1[i].Location == Lista2[j].Location)
                            {
                                SendMessage("gameo" + currentPlayer);
                                GameOver();
                                return;
                            }
                        }
                    }

                    for (int i = 0; i < Lista2.Count; i++)
                    {
                        for (int j = 0; j < Lista1.Count; j++)
                        {
                            if (Lista2[i].Location == Lista1[j].Location)
                            {
                                SendMessage("gameo" + currentPlayer);
                                GameOver();
                                return;
                            }
                        }
                    }
                }                
            }
        }
        #endregion // colision multijugador

        #region "Mensajes"

        private void PauseGame()
        {
            tmrGame.Stop();
            tmrScore.Stop();
        }

        private void StartGame()
        {
            tmrGame.Start();
            tmrScore.Start();
        }

        private void GameOver()
        {
            play = false;
            PauseGame();
            MessageBox.Show("Game Over!!", "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Loser()
        {
            play = false;
            PauseGame();
            MessageBox.Show("Perdistes :(!!", "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region "MsgEsperando"

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (numberPlayers == 2)
            {
                if (play && !player2)
                {
                    MessageBox.Show("Esperando al jugador 2!!", "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            #endregion
        #region "Teclado"

            if (currentPlayer == 0 || currentPlayer == 1)
            {
                if (e.KeyCode == Keys.S && x_Movimiento != 2)
                {
                    Movimiento = 1;
                }
                else if (e.KeyCode == Keys.W && x_Movimiento != 1)
                {
                    Movimiento = 2;
                }
                else if (e.KeyCode == Keys.A && x_Movimiento != 4)
                {
                    Movimiento = 3;
                }
                else if (e.KeyCode == Keys.D && x_Movimiento != 3)
                {
                    Movimiento = 4;
                }

                if (currentPlayer == 1 && Movimiento != 0)
                {
                    SendMessage("moved|" + currentPlayer + "|" + Movimiento);
                }
            }

            if (currentPlayer == 0 || currentPlayer == 2)
            {
                if (e.KeyCode == Keys.Down && x_Movimiento2 != 2)
                {
                    Movimiento2 = 1;
                }
                else if (e.KeyCode == Keys.Up && x_Movimiento2 != 1)
                {
                    Movimiento2 = 2;
                }
                else if (e.KeyCode == Keys.Left && x_Movimiento2 != 4)
                {
                    Movimiento2 = 3;
                }
                else if (e.KeyCode == Keys.Right && x_Movimiento2 != 3)
                {
                    Movimiento2 = 4;
                }

                if (currentPlayer == 2 && Movimiento2 != 0)
                {
                    SendMessage("moved|" + currentPlayer + "|" + Movimiento2);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                SendMessage("pause|" + currentPlayer);
                PauseGame();
            }
            else if (e.KeyCode == Keys.Space)
            {
                SendMessage("plays|" + currentPlayer);
                StartGame();
            }
        }
        #endregion

        #region Cliente
        private string userName = "";
        private int currentPlayer = 0;
        private bool play = false, player2 = false;

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void SendMessage(string data)
        {
            lblInput.Text = data;

            if (currentPlayer != 0)
            {
                Client.SendMessage();
            }
            
            lblInput.Text = "";
        }

        private void Disconnect()
        {
            Client.Disconnect();
        }

        private void LblOutput_TextChanged(object sender, EventArgs e)
        {
            if (lblOutput.Text.Trim() != "")
            {
                string[] datos = lblOutput.Text.Trim().Split('|');
                string data = datos[0];

                switch (data.Substring(0, 6))
                {
                    case "!accep":
                        currentPlayer = int.Parse(data.Substring(9, data.Length - 9));
                        WriteStatus(userName + " Conectado");
                        NewPoint();

                        if (currentPlayer == 2)
                        {
                            play    = true;
                            player2 = true;
                        }
                        
                        break;

                    case "!other":
                        play    = true;
                        player2 = true;
                        break;

                    case "!pause":
                        PauseGame();
                        break;

                    case "!plays":
                        StartGame();
                        break;

                    case "!gameo":
                        GameOver();
                        break;

                    case "!loser":
                        MessageBox.Show("Jugador " + data[1] + " Perdido!!!", "Snake Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "!moved":
                        InputSimulator sim = new InputSimulator();

                        if (int.Parse(datos[1]) == 1)
                        {
                            Movimiento = int.Parse(datos[2]);

                            if (Movimiento == 1)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.VK_S);
                            }
                            else if (Movimiento == 2)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                            }
                            else if (Movimiento == 3)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                            }
                            else if (Movimiento == 4)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.VK_D);
                            }

                            x_Movimiento = Movimiento;
                        }
                        else
                        {
                            Movimiento2 = int.Parse(datos[2]);

                            if (Movimiento2 == 1)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                            }
                            else if (Movimiento2 == 2)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.UP);
                            }
                            else if (Movimiento2 == 3)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                            }
                            else if (Movimiento2 == 4)
                            {
                                sim.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                            }

                            x_Movimiento2 = Movimiento2;
                        }

                        break;

                    case "!point":
                        NewPoint(int.Parse(datos[2]), int.Parse(datos[3]));

                        break;
                }
            }
        }

        private void WriteStatus(string Message)
        {
            StatusPlayer1.Text = "Jugador " + currentPlayer + " " + Message;
            this.Text = "Snake Game - Jugador " + currentPlayer;
        }
        #endregion
    }
}
