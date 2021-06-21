using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Classes
{
    public class Controls
    {
        public int down { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int up { get; set; }
        public int slow { get; set; }
        public int shoot { get; set; }
        public int shoot2 { get; set; }
        public int start { get; set; }

        public Tuple<double,double,bool,bool,bool> Rules()
        {
            double speed = 1;
            double x = 0;
            double y = 0;
            bool fired = false;
            bool fired2 = false;
            bool start = false;
            if (Keyboard.GetState().IsKeyDown((Keys)this.slow))
            {
                speed *= 0.5;
            }
            if ((Keyboard.GetState().IsKeyDown((Keys)this.up) || Keyboard.GetState().IsKeyDown((Keys)this.down)) && (Keyboard.GetState().IsKeyDown((Keys)this.left) || Keyboard.GetState().IsKeyDown((Keys)this.right)))
            {
                speed *= 0.7;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.up))
            {
                y = -speed;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.down))
            {
                y = speed;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.right))
            {
                x = speed;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.left))
            {
                x = -speed;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.shoot))
            {
                fired = true;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.shoot2))
            {
                fired2 = true;
            }
            if (Keyboard.GetState().IsKeyDown((Keys)this.start))
            {
                start = true;
            }
            return Tuple.Create(x,y,fired,fired2,start);
        }

        public Controls(int up=0, int right=0, int down=0, int left=0, int slow=0, int shoot=0, int shoot2=0, int start=0)
        {
            this.up = up;
            this.right = right;
            this.down = down;
            this.left = left;
            this.slow = slow;
            this.shoot = shoot;
            this.shoot2 = shoot2;
            this.start = start;
        }
    }
}
