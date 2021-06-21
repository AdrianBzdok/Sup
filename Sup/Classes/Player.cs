using Sup.LoadContent;
using Sup.Mechanic;
using Sup.Objects.PShips;
using Sup.Objects.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Classes
{
    public class Player
    {
        public PShip Ship { get; set; }
        public Controls Controls { get; set; }
        public PlayerSprites Sprites { get; set; }
        public int Lives { get; set; }
        public int Score { get; set; }
        public bool Active { get; set; }

        public Player(Controls controls,PlayerSprites sprites)
        {
            this.Controls = controls;
            this.Sprites = sprites;
            this.Score = 0;
            this.Active = false;
            this.Lives = 4;
        }

        public void AddShip(PShip pship)
        {
            if (this.Lives > 0)
            {
                if (this.Active)
                {
                    pship.X = 540;
                    pship.Y = 900;
                    pship.Speedy = -25;
                    pship.Invulnerable = 60;
                    pship.NoControl = 30;
                    
                }
                Ship = pship;
                this.Active = true;
                InGame.objects.Add(pship);
                InGame.players.Add(pship);
                this.Lives -= 1;
            }
        }

        public void Rules()
        {
            if (this.Active&&this.Ship.X > 3000)
            {
                AddShip(Ship);
            }
            Tuple<double, double, bool, bool, bool> test = this.Controls.Rules();
            if (!this.Active && test.Item5)
            {
                List<Weapon> TestWep = new List<Weapon>();
             //   TestWep.Add(new WeaponUpGatling(sprity.PBullets.PBullet1, -20, -16, this));
             //   TestWep.Add(new WeaponUpGatling(sprity.PBullets.PBullet1, 20, -16, this));
                this.AddShip(new ShipType1(200, 680, this, TestWep, new List<Weapon>()));
            }
        }
    }
}
