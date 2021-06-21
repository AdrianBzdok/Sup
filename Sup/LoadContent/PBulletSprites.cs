using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.LoadContent
{
    public class PBulletSprites
    {
        public Texture2D PBullet1 { get; set; }
        public Texture2D PBullet2 { get; set; }
        public PBulletSprites(ContentManager Content)
        {
            this.PBullet1 = Content.Load<Texture2D>("sprites/PBullets/pbullet1");
            this.PBullet2 = Content.Load<Texture2D>("sprites/PBullets/pbullet2");
        }
    }
}
