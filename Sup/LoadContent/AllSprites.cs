using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sup.FileManage;

namespace Sup.LoadContent
{
   public class AllSprites
    {
        public GraphicsDevice GraphicsDevice { get; set; }
        public SpriteBatch SpriteBatch { get; set; }
        public Texture2D Bullet { get; set; }
        public PBulletSprites PBullets { get; set; }
        public Texture2D E1 { get; set; }
        public Texture2D Bg1 { get; set; }
        public SpriteFont Font { get; set; }
        public PlayerSprites PRed { get; set; }
        public PlayerSprites PBlue { get; set; }
        public PlayerSprites PGreen { get; set; }
        public PlayerSprites PYellow { get; set; }
        public Texture2D NoPlayer { get; set; }
        public Texture2D GUI { get; set; }
        public Texture2D PressStart { get; set; }
        public  AllSprites(GraphicsDevice layer,ContentManager Content) {
            this.GraphicsDevice = layer;
            SpriteBatch = new SpriteBatch(layer);
            Bullet = Content.Load<Texture2D>("sprites/bullet");
            E1 = Content.Load<Texture2D>("sprites/e1");
            Bg1 = Content.Load<Texture2D>("background/bg1");
            Font = Content.Load<SpriteFont>("fonts/Arial");
            PRed = new PlayerSprites(Color.Red,"Red",Content);
            PBlue = new PlayerSprites(Color.DeepSkyBlue, "Blue", Content);
            PYellow = new PlayerSprites(Color.Yellow,"Yellow", Content);
            PGreen = new PlayerSprites(Color.LimeGreen, "Green", Content);
            PBullets = new PBulletSprites(Content);
            GUI = Content.Load<Texture2D>("background/gui");
            NoPlayer = Content.Load<Texture2D>("sprites/noplayer");
            PressStart = Content.Load<Texture2D>("sprites/press start");
        }
    }
}
