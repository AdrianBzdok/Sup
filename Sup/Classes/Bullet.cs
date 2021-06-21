using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sup.Mechanic;
namespace Sup.Classes
{
    public class Bullet : IObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Speed { get; set; }
        public double Speedx { get; set; }
        public double Speedy { get; set; }
        public double Size { get; set; }
        public Texture2D Sprite { get; set; }

        public Bullet(double x, double y, double speed, Texture2D sprite,double size)
        {
            this.X = x;
            this.Y = y;
            this.Sprite = sprite;
            this.Speed = speed;
            this.Size = size;
        }
        public virtual void Rules()
        {
            this.X += this.Speedx;
            this.Y += this.Speedy;
            foreach (PShip player in InGame.players.Reverse<PShip>())
            {
                if (MBullet.CheckHit(this, player)&&player.Invulnerable==0)
                {
                    player.X = 4001;
                    this.X = 4650;
                }
            }
            this.PRules();
        }
        public virtual void PRules()
        {

        }
    }
}
