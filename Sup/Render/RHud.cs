using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sup.Classes;
using Sup.LoadContent;
using Sup.Mechanic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Render
{
    public class RHud
    {
        private double framerate;
        private int presstart;

        public AllSprites Sprity { get; set; }
        public Mgame gra { get; set; }
        public CreateRectangle CreateRectangle { get; set; }
        public RHud(AllSprites Sprity, Mgame gra)
        {
            this.Sprity = Sprity;
            this.gra = gra;
            this.CreateRectangle = new CreateRectangle(Sprity);
        }
        public void Rules(GameTime gameTime)
        {
            framerate = (1 / gameTime.ElapsedGameTime.TotalSeconds);
            Sprity.SpriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp);
            Sprity.SpriteBatch.Draw(Sprity.GUI, new Vector2(0, 0), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
            Sprity.SpriteBatch.DrawString(Sprity.Font, Convert.ToString(Math.Round(this.framerate, 2)), new Vector2(1150, 650), Color.White, 0f, Vector2.Zero, 2.0f, SpriteEffects.None, 0f);
            int b = 0;
            foreach (Player player in gra.Players ) 
            {
                if (player.Active)
                {
                    Sprity.SpriteBatch.DrawString(Sprity.Font, Convert.ToString(player.Score).PadLeft(13, '0'), new Vector2(1062, 370 + (b*36)), player.Sprites.Color, 0f, Vector2.Zero, 1.34f, SpriteEffects.None, 0f);
                    Sprity.SpriteBatch.Draw(CreateRectangle.Create((int)((float)(208 * player.Ship.Power) / (float)player.Ship.MaxPower), 24, player.Sprites.Color), new Vector2(1064, 232+(b*36)), Color.White);
                    int a = 1;
                    while (a <= player.Lives)
                    {
                        Sprity.SpriteBatch.Draw(player.Sprites.Lives, new Vector2(1090 + (30 * a), 24 + (b*52)), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
                        a++;
                    }
                }
                else
                {
                    if (this.presstart > 30) {
                    Sprity.SpriteBatch.Draw(Sprity.PressStart, new Vector2(1058, 16 + (b * 52)), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
                    }
                    Sprity.SpriteBatch.Draw(Sprity.NoPlayer, new Vector2(1060, 228+ (b * 36)), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
                    Sprity.SpriteBatch.Draw(Sprity.NoPlayer, new Vector2(1060, 368 + (b * 36)), null, Color.White, 0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0f);
                }
                b+=1;
            }
            Sprity.SpriteBatch.End();
            this.presstart += 1;
            if (this.presstart > 60)
            {
                this.presstart = 0;
            }
        }
    }
}
