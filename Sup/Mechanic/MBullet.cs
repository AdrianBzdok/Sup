using Sup.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Mechanic
{
    public static class MBullet
    {
        public static PShip ChooseTargetRandom()
        {
            int r = Rng.rng.Next(InGame.players.Count);
            return InGame.players[r];
        }
        public static void SetToTarget(Bullet bullet, PShip temptar)
        {
                double tempx = bullet.X - temptar.X;
                double tempy = bullet.Y - temptar.Y;
                bullet.Speedx = bullet.Speed * -(tempx / (Math.Abs(tempx) + Math.Abs(tempy)));
                bullet.Speedy = bullet.Speed * -(tempy / (Math.Abs(tempx) + Math.Abs(tempy)));
        }
        public static bool CheckHit(Bullet bullet, IObject target)
        {
            double tempdist = Math.Sqrt(Math.Pow(bullet.X - target.X,2) + Math.Pow(-bullet.Y + target.Y,2));
            if (tempdist <= bullet.Size+target.Size)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
