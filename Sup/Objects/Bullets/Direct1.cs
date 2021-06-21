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
    public class Direct1 : Bullet
    {
        public Direct1(double x, double y, double speed, Texture2D sprite, double size,PShip Target = null) : base(x,y,speed,sprite,size)
        {
            if (Target != null) { MBullet.SetToTarget(this, Target); } else
            if (InGame.players.Count > 0) { MBullet.SetToTarget(this, MBullet.ChooseTargetRandom()); } else { this.Speedy = this.Speed; }
        }
    }
}
