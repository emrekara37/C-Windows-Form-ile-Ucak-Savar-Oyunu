using System;
using System.Windows.Forms;

namespace NdpProjeOdevi
{
  public partial class GameOver : Form
  {
    public Form1 Form1;
    private readonly int _score = 0;
    public GameOver(int score)
    {
      InitializeComponent();
      _score = score;
      Text = "Oyun Bitti";
    }

    private void GameOver_Load(object sender, EventArgs e)
    {
      label1.Text = "Oyun Bitti Score : " + _score;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var t = new System.Threading.Thread(ThreadIsle);
      t.Start();
      this.Close();
    }

    private void ThreadIsle()
    {
      Application.Run(new Form1());
    }
  }
}
