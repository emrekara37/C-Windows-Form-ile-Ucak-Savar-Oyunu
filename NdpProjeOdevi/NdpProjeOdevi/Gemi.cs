using System.Drawing;
using System.Windows.Forms;

namespace NdpProjeOdevi
{
  public class Gemi : PictureBox
  {
    public Gemi()
    {
      Location= new Point(588 ,517);
      Image = Image.FromFile("../../Resources/myPlane.png");
      SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}
