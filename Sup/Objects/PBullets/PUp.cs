using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Objects.PBullets
{
    public class PUp : PBullet
    {
        public PUp(double x, double y, double speed, Texture2D sprite, double size,int damage, Player player): base(x, y, speed, sprite, size, damage, player)
        {
            this.Speedy = -speed;
        }
    }
}
