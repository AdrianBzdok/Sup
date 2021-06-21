using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.FileManage
{
    public static class FileManager
    {
        static readonly string sciezka = "./../../../../Content/sprites/";
        public static Texture2D OpenSprite(GraphicsDevice graphicsDevice, string plik)
        {
            FileStream x = new FileStream( sciezka + plik, FileMode.Open);
            try
            {
                return Texture2D.FromStream(graphicsDevice, x);
            } finally
            {
                x.Close();
                x = null;
            }
        }
    }
}
