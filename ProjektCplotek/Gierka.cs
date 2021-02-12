using System;
using System.Windows.Forms;

namespace ProjektCplotek
{
    public partial class Gierka : Form
    {
        bool skacze = false;
        int predSkoku = 10;
        int silaSkoku = 10;
        int wynik = 0;
        int predKaktus = 10;
        Random r = new Random();
        public Gierka()
        {
            InitializeComponent();
            reset();
        }

        private void Event1(object sender, EventArgs e)
        {
            biegacz.Top += predSkoku;// przesuwa biegacza w gore o predkosc skoku

            WynikLabel.Text = "Wynik: " + wynik;

            if (skacze && silaSkoku < 0)
            {
                skacze = false;
            }

            if(skacze)
            {
                predSkoku = -10;
                silaSkoku -= 1;
            }
            else
            {
                predSkoku = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "kaktus")
                {
                    x.Left -= predKaktus; //przesun kaktusa w lewo

                    if (x.Left + x.Width < -100)
                    {
                        x.Left = this.ClientSize.Width + r.Next(200, 800);// tworzy nowego kaktusa
                        wynik++;
                    }

                    if(biegacz.Bounds.IntersectsWith(x.Bounds))
                    {
                        TimerGierki.Stop();
                        biegacz.Image = Properties.Resources.gameover;//Zmienia obrazek biegacza na gameover
                        button1.Visible = true;
                        button2.Visible = true;
                    }
                }
            }

            if(biegacz.Top >= 300 && !skacze)
            {
                silaSkoku = 10;
                biegacz.Top = podloga.Top - biegacz.Height;
                predSkoku = 0;
            }

            if (wynik >= 5)
            {
                int przelicznik = wynik / 5;
                predKaktus = 10 + przelicznik;
            }
        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                reset();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if(skacze)
            {
                skacze = false;
            }
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !skacze)
                skacze = true;
        }

        public void reset() 
        {
            this.ActiveControl = null;//zeby focus zszedl z buttonow i mozna bylo skakac
            button1.Visible = false;
            button2.Visible = false;
            silaSkoku = 10;
            biegacz.Top = podloga.Top - biegacz.Height;
            predSkoku = 0;
            skacze = false;
            predKaktus = 10;
            wynik = 0;
            WynikLabel.Text = "Wynik: " + wynik;
            biegacz.Image = Properties.Resources.bieganim;//ustawienie obrazka biegacza na animacje biegania

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "kaktus")
                {
                    int poz = r.Next(600, 1000);
                    x.Left = 640 + (x.Left + poz + x.Width * 3);
                }
            }

            TimerGierki.Start();
        }

        private void resetuj(object sender, EventArgs e)
        {
            reset();
        }

        private void ZapiszWynik(object sender, EventArgs e)
        {
            ZapiszWynik zapiszW;
            zapiszW = new ZapiszWynik(wynik);
            zapiszW.Show();
        }
    }
}
