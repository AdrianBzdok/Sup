using Microsoft.Xna.Framework.Input;
using Sup.LoadContent;
using Sup.Classes;
using Sup.Objects.Bullets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sup.Objects.Enemies;
using Sup.Objects.PShips;
using Sup.Objects.Weapons;

namespace Sup.Mechanic
{
    public class Mgame
    {
        public List<IObject> obiekty { get; set; }
        public List<PShip> pstatki { get; set; }
        public int Test { get; set; }
        public int Test2 { get; set; }
        public List<Player> Players { get; set; }
        public List<Weapon> TestWep { get; set; }
        public Mgame(AllSprites sprity)
        {
            Test = 0;
            Test2 = 180;
            obiekty = InGame.objects;
            pstatki = InGame.players;
            Players = new List<Player>();
            Players.Add(new Player(new Controls(38, 39, 40, 37, 160, 90, 98, 49), sprity.PRed));
            int a = 0;
            foreach (Player playerx in Players) {
                TestWep = new List<Weapon>();
                TestWep.Add(new WeaponUpGatling(sprity.PBullets.PBullet1, -20, -16, playerx));
                TestWep.Add(new WeaponUpGatling(sprity.PBullets.PBullet1, 20, -16, playerx));
                playerx.AddShip(new ShipType1(200+a, 680, playerx, TestWep, new List<Weapon>()));
                a += 100;
            }
            Players.Add(new Player(new Controls(38, 39, 40, 37, 160, 90, 98, 49), sprity.PBlue));
            Players.Add(new Player(new Controls(38, 39, 40, 37, 160, 90, 98, 49), sprity.PGreen));
            Players.Add(new Player(new Controls(38, 39, 40, 37, 160, 90, 98, 49), sprity.PYellow));
        }

        public void Update(AllSprites sprity)
        {
            this.Test++;
            if (this.Test == Test2)
            {
                InGame.AddEnemy(new Pod1(Rng.rng.Next(26,1038), -40, sprity.E1, sprity.Bullet,100,100));
                this.Test = 0;
                if (Test2 > 60)
                {
                    this.Test2 -= 3;
                }
            }
            foreach (var obiekt in obiekty.Reverse<IObject>())
            {
                if (Math.Abs(obiekt.X) > 2000 || Math.Abs(obiekt.Y) > 2000)
                {
                    obiekty.Remove(obiekt);
                }
                else
                {
                    obiekt.Rules();
                }
            }
            foreach (var obiekt in pstatki.Reverse<PShip>())
            {
                if (Math.Abs(obiekt.X) > 2000 || Math.Abs(obiekt.Y) > 2000)
                {
                    pstatki.Remove(obiekt);
                }
            }
            foreach (Player player in Players.Reverse<Player>())
            {
                player.Rules();
            }
        }
    }
}
