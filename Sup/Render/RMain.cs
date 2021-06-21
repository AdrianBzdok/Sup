using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sup.LoadContent;
using Sup.Mechanic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Render
{
    public class RMain
    {
        public AllSprites Sprity { get; set; }
        public Mgame gra { get; set; }
        public RGame rgame { get; set; }
        public RHud rhud { get; set; }
        public void Rules(GameTime gameTime)
        {
            rgame.Rules();
            rhud.Rules(gameTime);
        }
        public RMain(AllSprites Sprity,Mgame gra)
        {
            this.Sprity = Sprity;
            this.gra = gra;
            this.rgame = new RGame(Sprity, gra);
            this.rhud = new RHud(Sprity, gra);
        }
    }
}
