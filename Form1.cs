using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Practice
{
   

    public partial class Form1 : Form
    {
        int skakkvar = 30;
        string filnamn = "secretfile.txt";
        string[] nivåer = { "inget", "level 2", "tree", "fyjra" };
        int nivå = 0;

        Random rng = new Random();
        int korrekta, felaktiga;
        List<Uppgift> uppgifterna = new List<Uppgift>();
        List<Uppgift> felsvarade = new List<Uppgift>();
        Uppgift currentUppgift;
        Stopwatch tid = new Stopwatch();

        public Form1()
        {

            InitializeComponent();

            Start();

        }

        //Starta nytt spel
        public void Start()
        {
            LaddaResultat();

            //Nollställ värden
            progressBar1.Value = 100;
            felsvarade.Clear();            
            korrekta = 0;
            felaktiga = 0;

            int antalUppgifter = 21 + nivå * 20;

            stapelKvar.Nollställ();
            stapelKvar.Max = antalUppgifter;

            //Generera gångeruppgifterna

            List<Uppgift> allaUppgifter = new List<Uppgift>();

            for (int i = 2; i <= 10; i++)
            {
                for (int j = 2; j <= 10; j++)
                {
                    Uppgift uppgift = new Uppgift(i, j);
                    allaUppgifter.Add(uppgift);
                }
            }
            foreach (Uppgift u in allaUppgifter)
                Debug.WriteLine(u.Text);

            //Slumpa uppgifter till den här omgången
            while (uppgifterna.Count < antalUppgifter)
            {
                int nr = rng.Next(allaUppgifter.Count - 1);
                uppgifterna.Add(allaUppgifter[nr]);
                allaUppgifter.RemoveAt(nr);
            }
            
            //Tidtadning
            tid.Reset();
            tid.Start();

            //Nedräkningen
            timer1.Start();

            //Starta spelet
            NästaUppgift();
        }

        //Välj nästa uppgift
        private void NästaUppgift()
        {
            Debug.WriteLine(uppgifterna.Count);

            //Det finns uppgifter i båda listorna
            if (felsvarade.Count > 0 && uppgifterna.Count > 0)
            {

                //20 procents chans att hämta uppgift ur fellistan
                if (rng.Next(5) == 0)
                {
                    lblUppgift.ForeColor = Color.Blue;
                    int nr = rng.Next(felsvarade.Count - 1);
                    currentUppgift = felsvarade[nr];
                    felsvarade.RemoveAt(nr);
                }

                //Vanlig uppgift
                else 
                {
                    currentUppgift = uppgifterna[0].Copy();
                    uppgifterna.RemoveAt(0);
                }
            }
        
            //Det finns uppgifter i uppgiftslistan
            else if(uppgifterna.Count>0)            
            {
                currentUppgift = uppgifterna[0].Copy();
                uppgifterna.RemoveAt(0);
            }
            //Det finns uppgifter i fellistan
            else if (felsvarade.Count > 0)
            {
                lblUppgift.ForeColor = Color.Blue;
                int nr = rng.Next(felsvarade.Count - 1);
                currentUppgift = felsvarade[nr];
                felsvarade.RemoveAt(nr);
            }

            //Inga uppgifter kvar
            else
            {
                Slut();
            }

            lblUppgift.Text = currentUppgift.Text;
            lblSvar.Text = string.Empty;
        }

        //Inmatning
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ta bara in siffror
            if (char.IsDigit(e.KeyChar))
                lblSvar.Text += e.KeyChar;

            //Enter och det finns redan siffra
            else if (e.KeyChar == 13 && lblSvar.Text.Length>0)
            {
                //RÄTT
                if (currentUppgift.Rätta(int.Parse(lblSvar.Text)))
                {
                    korrekta++;
                    lblUppgift.ForeColor = Color.Green;
                    stapelKvar.Minska();
                    NästaUppgift();
                    progressBar1.Value = Math.Min(progressBar1.Value+50, 100);
                }

                //FEL
                else
                {
                    felaktiga++;

                    lblUppgift.ForeColor = Color.Red;

                    felsvarade.Add(currentUppgift.Copy());
                    felsvarade.Add(currentUppgift.Copy());
                    stapelKvar.Öka();
                    stapelKvar.Öka();
                    lblSvar.Text = string.Empty;
                    Skaka();
                }
            }

            //Sudda
            else if (e.KeyChar == 8)
                lblSvar.Text = string.Empty;
        }

        //Till tidtagningen
        private void timer1_Tick(object sender, EventArgs e)
        {
            //TIDEN SLUT!
            if (progressBar1.Value == 0)
            {
                Slut();
            }
            else
                progressBar1.Value -= 2;
        }

        //Tiden eller uppgifterna är slut
        public void Slut()
        {
            tid.Stop();
            timer1.Stop();
            
            frmResultat resultat = new frmResultat();
            resultat.tbxTid.Text = Math.Round((tid.ElapsedMilliseconds / 1000f), 1).ToString() + " s";
            resultat.tbxKorrekta.Text = korrekta.ToString();
            resultat.tbxFelaktiga.Text = felaktiga.ToString();

            resultat.tbxTidPerUppgift.Text = Math.Round((tid.ElapsedMilliseconds / 1000f) / korrekta, 1).ToString();

            //KLARADE NIVÅN!
            if (uppgifterna.Count == 0)
            {
                resultat.lblOK.Text = "Bra jobbat!";
                LevelUp();
            }
            resultat.ShowDialog();
            Start();
        }

        //Nästa nivå - spara i filen!
        public void LevelUp()
        {
            nivå++;
            if (nivå < 4)
            {
                try
                {
                    File.WriteAllText(filnamn, nivåer[nivå]);
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Application.Exit();
                }
            }
            else
                MessageBox.Show("NU KAN DU DET HÄR!!!");
        }

        //Finns något resultat sparat?
        public void LaddaResultat()
        {
            Text = "Gångertränaren - nivå 1";
            BackColor = Color.FromArgb(240, 240, 240);

            if (File.Exists(filnamn))
            {

                string läst = File.ReadAllText(filnamn);

                if (läst == "level 2")
                {
                    Text = "Gångertränaren - nivå 2";
                    BackColor = Color.FromArgb(221,160,221);
                    
                    nivå = 1;
                    timer1.Interval = 400;
                }

                else if (läst == "tree")
                {
                    Text = "Gångertränaren - nivå 3";
                    BackColor = Color.FromArgb(202,225,255);
                    nivå = 2;
                    timer1.Interval = 250;

                }

                else if (läst == "fyjra")
                {
                    Text = "Gångertränaren - nivå 4";
                    BackColor = Color.FromArgb(154, 255, 154);
                    nivå = 3;
                    timer1.Interval = 100;

                }
            }

            
        }

        public void Skaka()
        {
            skakkvar = 10;
            timer2.Start();
        }

        //ETT SKAK
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Skaka lite till
            if (skakkvar > 0)
            {
                Left += rng.Next(31) - 15;
                Top += rng.Next(31) - 15;
                skakkvar--;
                stapelKvar.Left += rng.Next(9) - 4;
                stapelKvar.Top+= rng.Next(9) - 4;
                Left = Math.Max(Left, 0);
                Top= Math.Max(Top, 0);
            }

            //SLUTSKAKAT
            else
                timer2.Stop();

        }
    }
}
