using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Classes
{
    public class Enemy : IObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Speedx { get; set; }
        public double Speedy { get; set; }
        public double Size { get; set; }
        public int Hitpoints { get; set; }
        public int Bounty { get; set; }
        public Texture2D Sprite { get; set; }
        public Texture2D Bsprite { get; set; }
        public void Rules() {
            this.PRules();
            this.X += this.Speedx;
            this.Y += this.Speedy;
        }
        public virtual void PRules()
        {

        }
        public Enemy(int x, int y, Texture2D sprite, Texture2D Bsprite,double Size,int Hitpoints,int Bounty)
        {
            this.X = x;
            this.Y = y;
            this.Speedx = 0;
            this.Speedy = 0;
            this.Sprite = sprite;
            this.Bsprite = Bsprite;
            this.Hitpoints = Hitpoints;
            this.Bounty = Bounty;
            this.Size = Size;
        }
    }
}
