using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using Sup.LoadContent;
using Sup.Mechanic;
using Sup.Objects.PBullets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Objects.Weapons
{
    public class WeaponUpGatling: Weapon
    {
        public WeaponUpGatling(Texture2D bulletSprite, int relX, int relY,Player player) : base(bulletSprite, relX, relY,player) {
            this.Reload = 10;
            this.FireRate = 10;
        }
        public override int Shoot(int power,double X,double Y)
        {
            if (power > 9 && this.Reload == this.FireRate)
            {
                power -= 100;
                InGame.objects.Add(new PUp(X + this.RelX, Y + this.RelY, 19.0, this.BulletSprite, 4.0,40,this.Player));
                this.Reload = 0;
            }
            return power;
        }
    
    }
}
