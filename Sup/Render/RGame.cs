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
    public class RGame
    {
        private int klatka;

        public AllSprites Sprity { get; set; }
        public Mgame gra { get; set; }
        public RGame(AllSprites Sprity, Mgame gra)
        {
            this.Sprity = Sprity;
            this.gra = gra;
            this.klatka = 0;
        }
        public void Rules()
        {
            Sprity.SpriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp);
            Sprity.SpriteBatch.Draw(Sprity.Bg1, new Vector2(0, -2160 + this.klatka % 2160), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
            foreach (var i in gra.obiekty)
            {
                Sprity.SpriteBatch.Draw(i.Sprite, new Vector2(Convert.ToInt32(i.X - 40), Convert.ToInt32(i.Y - 40)), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
            }
            Sprity.SpriteBatch.End();
            this.klatka += 1;
        }
    }
}
