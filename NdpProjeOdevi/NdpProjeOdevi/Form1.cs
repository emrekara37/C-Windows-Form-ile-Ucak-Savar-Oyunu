using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace NdpProjeOdevi
{
  public partial class Form1 : Form
  {
    public Gemi Gemi { get; set; } = new Gemi();
    public Mermi Mermi1 { get; set; }
    public GameOver GameOver;
    public DusmanUcak Ucak { get; set; }
    public ObservableCollection<DusmanUcak> DusmanGemiListesi = new ObservableCollection<DusmanUcak>();
    public ObservableCollection<Mermi> MermiListesi = new ObservableCollection<Mermi>();
    public static int Score;
    public bool Olustu;
    public Form1()
    {
      this.Controls.Add(Gemi);
      InitializeComponent();

      Text = "Uçak Savar Oyunu ";
      // Ekran Boyutlandırmayı Kapatma
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
    }

    private void TimerAyar()
    {
      timerGenel.Enabled = false;
      timerGenel.Interval = 2000;
      timerMermi.Enabled = false;
      timerMermi.Interval = 10;
      timerSavas.Enabled = false;
      timerSavas.Interval = 10;
    }


    private void Form1_Load(object sender, EventArgs e)
    {


      TimerAyar();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      var xPosition = Gemi.Location.X;
      var yPosition = Gemi.Location.Y;

      if (e.KeyCode == Keys.Right && Gemi.Right < this.ClientSize.Width)
      {
        xPosition += 15;
        Gemi.Location = new Point(xPosition, yPosition);
      }
      if (e.KeyCode == Keys.Left && Gemi.Left > 0)
      {
        xPosition -= 15;
        Gemi.Location = new Point(xPosition, yPosition);
      }

      if (e.KeyCode == Keys.Enter)
      {
        timerGenel.Enabled = true;
        timerSavas.Enabled = true;
        panel1.Hide();
      }
      if (e.KeyCode == Keys.Space)
      {
        MermiOlustur();
        SesCal();
        if (timerMermi.Enabled != true)
        {
          timerMermi.Enabled = true;
          timerMermi.Start();

        }

      }
    }




    private void timer1_Tick(object sender, EventArgs e)
    {
      NesneOlustur();
    }
    private void SesCal()
    {
      var simpleSound = new SoundPlayer("../../Resources/mermi.wav");
      simpleSound.Play();
    }

    private void NesneOlustur()
    {


      Ucak = new DusmanUcak(this);

      Olustu = true;


      DusmanGemiListesi.Add(Ucak);
      this.Controls.Add(Ucak);


    }

    private void timerMermi_Tick(object sender, EventArgs e)
    {
      AtesEt();

    }

    private void timerSavas_Tick(object sender, EventArgs e)
    {

      Dusur();

    }

    private void Dusur()
    {
      if (!Olustu) return;
      GameOver = new GameOver(Score);

      for (int i = DusmanGemiListesi.Count - 1; i >= 0; i--)
      {
        var yPosition = DusmanGemiListesi[i].Top;
        yPosition += 1;
        DusmanGemiListesi[i].Location = new Point(DusmanGemiListesi[i].Location.X, yPosition);

        OyunBitir(DusmanGemiListesi[i]);


      }

    }

    private void OyunBitir(DusmanUcak ucak)
    {

      if (this.ClientSize.Height <= ucak.Top + ucak.Height / 2)
      {
        var t = new System.Threading.Thread(ThreadIsle);
        t.Start();
        timerSavas.Enabled = false;
        this.Close();
      }

    }

    private void ScoreArttir()
    {
      Score++;
      lblSkor.Text = Score.ToString();

    }
    private void Carpisma(Mermi mermi)
    {
      if (DusmanGemiListesi == null) return;

      for (int i = DusmanGemiListesi.Count - 1; i >= 0; i--)
      {

        if (mermi.Top <= DusmanGemiListesi[i].Top && (mermi.Left >= DusmanGemiListesi[i].Left && mermi.Left <= DusmanGemiListesi[i].Right))
        {
          this.Controls.Remove(mermi);
          this.Controls.Remove(DusmanGemiListesi[i]);
          MermiListesi.Remove(mermi);
          DusmanGemiListesi.Remove(DusmanGemiListesi[i]);
          ScoreArttir();
        }
      }

    }

    private void MermiOlustur()
    {

      Mermi1 = new Mermi(Gemi);
      MermiListesi.Add(Mermi1);


      this.Controls.Add(Mermi1);
    }
    private void AtesEt()
    {

      for (int i = MermiListesi.Count - 1; i >= 0; i--)
      {
        var yPositionMermi = MermiListesi[i].Top;
        yPositionMermi -= 5;
        MermiListesi[i].Location = new Point(MermiListesi[i].Location.X, yPositionMermi);

        //Ekrandan çıkanı sil

        if (MermiListesi[i].Location.Y <= 0)
        {
          this.Controls.Remove(MermiListesi[i]);
          MermiListesi.Remove(MermiListesi[i]);

        }
        if (MermiListesi.Count > 0)
          Carpisma(MermiListesi[i]);
      }


    }

   
    private void ThreadIsle()
    {
      Application.Run(new GameOver(Score));
    }
  }
}
