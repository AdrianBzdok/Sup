using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.LoadContent
{
    public class PlayerSprites
    {
        public Texture2D Ship1 { get; set; }
        public Texture2D Ship2 { get; set; }
        public Texture2D Ship3 { get; set; }
        public Texture2D Lives { get; set; }
        public Color Color {get; set;}
        public PlayerSprites(Color coloro,string Color, ContentManager Content)
        {
            this.Color = coloro;
            this.Ship1 = Content.Load<Texture2D>("sprites/" + Color + "/Ship1");
            this.Ship2 = Content.Load<Texture2D>("sprites/" + Color + "/Ship2");
            this.Ship3 = Content.Load<Texture2D>("sprites/" + Color + "/Ship3");
            this.Lives = Content.Load<Texture2D>("sprites/" + Color + "/Lives");
        }
    }
}
