using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    public partial class MainForm : Form
    {
        Knight knight;
        fighter skeleton;

        public MainForm()
        {
            InitializeComponent();
            knight = new Knight(knightPictureBox);
            skeleton = new fighter(skeletonPictureBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            skeletonPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        /// <summary>
        /// После того, как рыцарь и скелет проивзаимодействовали, нужно обновить их здоровье и картинки
        /// </summary>
        public async void Update_All()
        {
            knightsHealth.Text = knight.TellHealth().ToString();
            skeletonsHealth.Text = skeleton.TellHealth().ToString();

            if (skeleton.isDead()||knight.isDead())
            {
                skeletonAttacks.Enabled = false;
                button1.Enabled = false;
                await Task.Delay(900);
                if(skeleton.isDead()) MessageBox.Show("Winner Knight", "game over!");
                else MessageBox.Show("Winner Skeleton", "game over!");
                skeleton = new fighter(skeletonPictureBox);
                knight = new Knight(knightPictureBox);
                knightsHealth.Text = knight.TellHealth().ToString();
                skeletonsHealth.Text = skeleton.TellHealth().ToString();
                skeletonAttacks.Enabled = true;
                button1.Enabled = true;
                skeletonPictureBox.Image = Image.FromFile(@"C:\Users\User\Desktop\Nikita C#\KnightVSSkeleton-master\Assets\Skeleton_Idle.gif");
                skeletonPictureBox.Enabled = true;
                knightPictureBox.Image = Image.FromFile(@"C:\Users\User\Desktop\Nikita C#\KnightVSSkeleton-master\Assets\Knight_Idle.gif");
                knightPictureBox.Enabled = true;


            }
        }

        private  void skeletonAttacks_Click(object sender, EventArgs e)
        {
            knight.ReceiveDamage(skeleton.makeDamage());
            Update_All();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skeleton.ReceiveDamage(knight.makeDamage());
            Update_All();
            
        }


    }
}
