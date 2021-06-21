using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sup.Mechanic;
using Sup.Objects.PBullets;

namespace Sup.Classes
{
    public class PShip : IObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Speedx { get; set; }
        public double Speedy { get; set; }
        public double Maxspeed { get; set; }
        public double Restraint { get; set; }
        public double Size { get; set; }
        public int Power { get; set; }
        public int MaxPower { get; set; }
        public int RegenPower { get; set; }
        public int Invulnerable { get; set; }
        public int NoControl { get; set; }
        public List<Weapon> Weapon1 {get; set;}
        public List<Weapon> Weapon2 { get; set; }
        public Controls Input { get; set; }
        public Texture2D Sprite { get; set; }
        public PShip(int x, int y,Texture2D sprite, Controls Controls, List<Weapon> Weapon1, List<Weapon> Weapon2)
        {
            this.X = x;
            this.Y = y;
            this.Speedx = 0;
            this.Speedy = 0;
            this.Invulnerable = 0;
            this.NoControl = 0;
            this.Sprite = sprite;
            this.Input = Controls;
            this.Weapon1 = Weapon1;
            this.Weapon2 = Weapon2;
            this.Size = 4;
        }
        public void Rules()
        {
            if(this.Speedx!=0)
            {
                if (Math.Abs(this.Speedx) > 0.5)
                {
                    this.Speedx += Math.Sign(this.Speedx) * -this.Restraint;
                } else
                {
                    this.Speedx = 0;
                }
            }
            if (this.Speedy != 0)
            {
                if (Math.Abs(this.Speedy) > 0.5)
                {
                    this.Speedy += Math.Sign(this.Speedy) * -this.Restraint;
                }
                else
                {
                    this.Speedy = 0;
                }
            }
            Tuple<double, double,bool,bool,bool> inputy = this.Input.Rules();
            if (inputy.Item1 != 0&&this.NoControl==0)
            {
                this.Speedx = this.Maxspeed * inputy.Item1;
            }
            if (inputy.Item2 != 0 && this.NoControl == 0)
            {
                this.Speedy = this.Maxspeed * inputy.Item2;
            }
            if (inputy.Item3 == true && this.NoControl == 0)
            {
                foreach(Weapon wep in this.Weapon1)
                {
                    this.Power = wep.Shoot(this.Power,this.X,this.Y);
                }
            }
            if (inputy.Item4 == true && this.NoControl == 0)
            {
                foreach (Weapon wep in this.Weapon2)
                {
                    this.Power = wep.Shoot(this.Power, this.X, this.Y);
                }
            }
            foreach (Weapon wep in this.Weapon1)
            {
                wep.Rules();
            }
            foreach (Weapon wep in this.Weapon2)
            {
                wep.Rules();
            }
            if (this.Power < this.MaxPower)
            {
                this.Power += RegenPower;
            }
            this.X += this.Speedx;
            this.Y += this.Speedy;
            if (this.X < 16 && this.NoControl == 0) { this.X = 16; }
            if (this.X > 1048&& this.X < 3000 && this.NoControl == 0) { this.X = 1048; }
            if (this.Y < 16&& this.NoControl == 0) { this.Y = 16; }
            if (this.Y > 702 && this.NoControl == 0) { this.Y = 702; }
            if (this.Invulnerable > 0) { this.Invulnerable--; }
            if (this.NoControl > 0) { this.NoControl--; }

        }
    }
}
