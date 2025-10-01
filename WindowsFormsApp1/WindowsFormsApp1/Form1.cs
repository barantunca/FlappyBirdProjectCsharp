using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       

        private int gravity = 1;
        private int velocity = 0;

        int score = 0;
        bool gameOver = false;
        Random rand = new Random();

        List<DevExpress.XtraEditors.PictureEdit> tops;
        List<DevExpress.XtraEditors.PictureEdit> bots;
        List<bool> scored;

        int pipeSpeed = 7;
        int pipeGap = 140;
        int pipeSpacing = 250;
        bool gameStarted = false;
        int highScore = 0;
        Label lblStart;
        Label lblHighScore;
        private void SetupStartScreen()
        {
            // START yazısı
            lblStart = new Label();
            lblStart.Text = "FLAPPY BIRD\nBaslamak icin SPACE";
            lblStart.Font = new Font("Arial", 24, FontStyle.Bold);
            lblStart.ForeColor = Color.White;
            lblStart.AutoSize = true;
            lblStart.BackColor = Color.Transparent;
            lblStart.Location = new Point(
                (this.ClientSize.Width - lblStart.PreferredWidth) / 2,
                (this.ClientSize.Height - lblStart.PreferredHeight) / 2
            );
            this.Controls.Add(lblStart);
        }


        public Form1()
        {

            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;   
            gameTimer.Tick += gameTimer_Tick; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
            SetupStartScreen();
            gameTimer.Stop(); // varsa oyun timerını başta durdur
            


            InitLists();
            
            ResetGame();
            
        }

        private void InitLists()
        {
            tops = new List<DevExpress.XtraEditors.PictureEdit> { pipeTop1, pipeTop2, pipeTop3 };
            bots = new List<DevExpress.XtraEditors.PictureEdit> { pipeBot1, pipeBot2, pipeBot3 };
            scored = new List<bool> { false, false, false };
        }

        

        private void ResetGame()
        {
            score = 0;
            gameOver = false;
            velocity = 0;

            int startX = this.ClientSize.Width + 100;
            int spacing = 300; // borular arası yatay mesafe
            int minGapY = 100; // alt sınır
            int maxGapY = this.ClientSize.Height - pipeGap - 100;
            int pipeHeight = tops[0].Height; // boruların doğal yüksekliği

            for (int i = 0; i < tops.Count; i++)
            {
                int gapY = rand.Next(minGapY, maxGapY);
                int leftPos = startX + i * spacing;

                // Üst boru
                tops[i].Left = leftPos;
                tops[i].Top = gapY - pipeHeight;

                // Alt boru
                bots[i].Left = leftPos;
                bots[i].Top = gapY + pipeGap;

                scored[i] = false;
            }

            // Kuşu ortala
            picBird.Top = this.ClientSize.Height / 2 - picBird.Height / 2;

            // Timer ayarı
            gameTimer.Interval = 20;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Kuş düşme
            velocity += gravity;
            picBird.Top += velocity;

            // Yukarı sınır kontrolü
            if (picBird.Top < 0)
            {
                EndGame();
            }

            for (int i = 0; i < tops.Count; i++)
            {
                tops[i].Left -= pipeSpeed;
                bots[i].Left -= pipeSpeed;

                // Boru ekrandan çıktıysa yeniden spawn (Height değişmeyecek!)
                if (tops[i].Right < 0)
                {
                    int gapY = rand.Next(100, this.ClientSize.Height - pipeGap - 100);
                    int leftPos = this.ClientSize.Width;

                    tops[i].Left = leftPos;
                    tops[i].Top = gapY - tops[i].Height; // boyutu değiştirme

                    bots[i].Left = leftPos;
                    bots[i].Top = gapY + pipeGap;

                    scored[i] = false;
                }

                // Skor
                if (!scored[i] && tops[i].Right < picBird.Left)
                {
                    score++;
                    lblScore.Text = $"Score: {score}";
                    scored[i] = true;
                }

                // Çarpışma
                if (picBird.Bounds.IntersectsWith(tops[i].Bounds) ||
                    picBird.Bounds.IntersectsWith(bots[i].Bounds))
                {
                    EndGame();
                }
            }

            // Zemine çarpma
            if (picBird.Top + picBird.Height >= this.ClientSize.Height)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            gameOver = true;
            MessageBox.Show($"Game Over! Score: {score}");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameStarted)
                {
                    // === İlk basış ===
                    gameStarted = true;
                    lblStart.Visible = false;   // Yazıyı kaldır
                    gameTimer.Start();          // Timer başlasın
                    velocity = -10;             // Kuş zıplasın (ilk jump)
                }
                else
                {
                    // === Oyun zaten başladıysa normal zıplama ===
                    velocity = -10;
                }
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!gameOver)
            {
                velocity = -10;
            }
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
