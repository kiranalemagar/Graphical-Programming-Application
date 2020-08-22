using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranAle_CompI
{
    public abstract class Shape
    {
       
        /// Passing Graphic VAlue
        
        /// <param name="g"></param>
        public abstract void Draw(Graphics g);

        /// passing the value to shape
       
        /// <param name="texturestyle">define texture</param>
        /// <param name="bb">define properties of brush</param>
        /// <param name="c">define color</param>
        /// <param name="list">list of parameter</param>
        public abstract void set(int texturestyle, Brush bb, Color c, params int[] list);

    }
}
