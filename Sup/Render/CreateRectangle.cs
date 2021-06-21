using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sup.LoadContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Render
{
    public class CreateRectangle
    {
        public AllSprites Sprity { get; set; }
        public CreateRectangle(AllSprites Sprity)
        {
            this.Sprity = Sprity;
        } 

        public Texture2D Create(int width,int height, Color color)
        {
            if (width <= 0)
            {
                width = 1;
            }
            Color[] data = new Color[width * height];
            Texture2D rectTexture = new Texture2D(this.Sprity.GraphicsDevice,width, height);

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = color;
            }
            rectTexture.SetData(data);
            return rectTexture;
        }
    }
}

