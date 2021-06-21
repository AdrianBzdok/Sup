using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.Classes
{
    public interface IObject
    {
        double X { get; set; }
        double Y { get; set; }
        double Size { get; set; }
        Texture2D Sprite { get; set; }
        void Rules();

    }
}
