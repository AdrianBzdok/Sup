using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Objects.PShips
{
    public class ShipType1 : PShip
    {
        public ShipType1(int x, int y, Player player, List<Weapon> Weapon1, List<Weapon> Weapon2) : base(x, y, player.Sprites.Ship1, player.Controls, Weapon1, Weapon2)
        {
            this.Restraint = 0.9;
            this.Maxspeed = 8;
            this.Power = 80000;
            this.MaxPower = 100000;
            this.RegenPower = 30;
        }
    }
}
