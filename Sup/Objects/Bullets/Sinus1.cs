using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using Sup.Mechanic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Objects.Bullets
{
    public class Sinus1 : Bullet
    {
        public double var { get; set; }
        public double kont { get; set; }
        public int kierunek { get; set; }
        public Sinus1(double x, double y, double speed, Texture2D sprite, double size,PShip Target = null) : base(x,y,speed,sprite,size)
        {
            if (Target != null) { MBullet.SetToTarget(this, Target); } else
            if (InGame.players.Count > 0) { MBullet.SetToTarget(this, MBullet.ChooseTargetRandom()); } else { this.Speedy = this.Speed; }
            this.var = 0;
            this.kont = Math.Atan2(Speedy, Speedx);
            this.kierunek = 1;
        }
        public override void PRules()
        {
            this.Speedy = this.Speed*Math.Sin(this.kont+this.var);
            this.Speedx = this.Speed*Math.Cos(this.kont+this.var);
            this.var +=  0.2 * this.kierunek;
            if (Math.Abs(this.var) >= 1.2)
            {
                this.kierunek *= -1;
            }
        }
    }
}
