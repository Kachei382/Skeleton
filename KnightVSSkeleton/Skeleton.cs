using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    class Skeleton:fighter
    {
          
         public Skeleton(PictureBox sprit,Weapon myWeapon):base(sprit,myWeapon)
        {

        }
        protected override async void Die()
        {
            base.sprite.Image = Image.FromFile(@"C:\Users\User\Desktop\Nikita C#\KnightVSSkeleton-master\Assets\Skeleton_Death.gif");
            await Task.Delay(900);
            sprite.Enabled = false;

        }

    }
}
    
