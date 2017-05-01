using System.Drawing;
using System.Windows.Forms;

namespace NdpProjeOdevi
{
  public class Mermi:PictureBox
  {

    public Mermi(Gemi pctSavar)
    {
      Image = Image.FromFile("../../Resources/mermi.png");
      Location = new Point((pctSavar.Location.X + pctSavar.Width / 2) - 15, pctSavar.Top + 2);
      Size = new Size(28, 28);
      SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}
