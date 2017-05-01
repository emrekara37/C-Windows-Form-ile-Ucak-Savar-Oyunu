using System;
using System.Drawing;
using System.Windows.Forms;

namespace NdpProjeOdevi
{
  public class DusmanUcak : PictureBox
  {
    public DusmanUcak(Form form)
    {
      var rnd = new Random();
      Image = Image.FromFile("../../Resources/enemyPlane.png");
      SizeMode = PictureBoxSizeMode.StretchImage;
      Location = new Point(rnd.Next(1, form.Width - 105), 20);
     
    }
  }
}
