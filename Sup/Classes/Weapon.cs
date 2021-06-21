using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Classes
{
    public class Weapon
    {
        public double RelX { get; set; }
        public double RelY { get; set; }
        public int Reload { get;  set; }
        public int FireRate { get; set; }
        public Texture2D BulletSprite { get; set; }
        public Player Player { get; set; }
        public Weapon(Texture2D bulletSprite,double relX, double relY,Player player)
        {
            this.BulletSprite = bulletSprite;
            this.RelX = relX;
            this.RelY = relY;
            this.Player = player;
        }
        public virtual void Rules()
        {
            if (this.Reload < this.FireRate)
            {
                this.Reload++;
            }
        }

        public virtual int Shoot(int power,double X,double Y)
        {
            return power;
        }
    }
}
