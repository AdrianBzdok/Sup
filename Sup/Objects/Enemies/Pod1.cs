using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using Sup.Mechanic;
using Sup.Objects.Bullets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Objects.Enemies
{
    class Pod1:Enemy
    {
        public int timing { get; set; }
        public PShip target { get; set; }
        public Pod1(int x, int y, Texture2D sprite, Texture2D Bsprite,int hitpoints,int Bounty) : base(x, y, sprite, Bsprite,35.0,hitpoints,Bounty)
        {
            this.timing = 0;
            this.Speedy = 2.5;
        }
        public override void PRules()
        {
            switch (this.timing)
            {
                case 33:
                    if (InGame.players.Count > 0) { this.target = MBullet.ChooseTargetRandom(); } else { this.target = null; }
                    break;
                case 35:
                case 37:
                case 38:
                case 41:
                case 43:
                case 45:
                    if (this.target!=null&&this.Y < this.target.Y) { InGame.AddBullet(new Sinus1(this.X, this.Y + 10, 20.0, Bsprite, 10.0, this.target)); }
                    break;
                case 60:
                    this.timing = 0;
                    break;
            }
            this.timing++;
        }
    }
}
