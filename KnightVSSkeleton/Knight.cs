using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    class Knight:fighter
    {
         public Knight(PictureBox sprit):base(sprit)
        {

        }
        protected override async void Die()
        {
           base.sprite.Image = Image.FromFile(@"C:\Users\User\Desktop\Nikita C#\KnightVSSkeleton-master\Assets\Knight_Death.gif");
            await Task.Delay(900);
            sprite.Enabled = false;

        }

    }
}
