using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sup.Mechanic;
namespace Sup.Classes
{
    public class PBullet : Bullet
    {
        public int Damage;
        public Player Player;
        public PBullet(double x, double y, double speed, Texture2D sprite, double size,int damage,Player player): base(x,y,speed,sprite,size)
        {
            this.Damage = damage;
            this.Player = player;
        }
        public override void Rules()
        {
            this.X += this.Speedx;
            this.Y += this.Speedy;
            foreach (Enemy Enemy in InGame.enemies.Reverse<Enemy>())
            {
                if (MBullet.CheckHit(this, Enemy))
                {
                    Enemy.Hitpoints -= this.Damage;
                    this.X = 4650;
                    if (Enemy.Hitpoints <= 0)
                    {
                        this.Player.Score += Enemy.Bounty;
                        Enemy.X = 4001;
                    }
                }
            }
        }
    }
} 
