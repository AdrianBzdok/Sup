using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using Sup.Objects.Bullets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Mechanic
{
    public static class InGame
    {
        static public List<IObject> objects { get; set; }
        static public List<PShip> players { get; set; }
        static public List<Enemy> enemies { get; set; }

        static InGame()
        {
            objects = new List<IObject>();
            players = new List<PShip>();
            enemies = new List<Enemy>();
        }

        static public void AddBullet(Bullet bullet)
        {
            objects.Add(bullet);
        }
        static public void AddPlayer(PShip player)
        {
            objects.Add(player);
            players.Add(player);
        }
        static public void AddEnemy(Enemy enemy)
        {
            objects.Add(enemy);
            enemies.Add(enemy);
        }
        static public void Clear()
        {

        }

    }
}
