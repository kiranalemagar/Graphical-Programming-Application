using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranAle_CompI
{
    public class Triangle : Shape
    {
      
        /// Triangle side
     
       public int ai1, bi1, ai2, bi2, aii1, bii1, aii2, bii2, aiii1, biii1, aiii2, biii2;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);

            //----------------------------------------------------------------------------------------------------------------------
            g.DrawLine(p, ai1, bi1, ai2, bi2);
            g.DrawLine(p, aii1, bii1, aii2, bii2);
            g.DrawLine(p, aiii1, biii1, aiii2, biii2);
            //---------------------------------------------------------------------------------------------------------------------


        }
       
        ///   coordinates to draw triangle
     
        /// <param name="texturestyle"></param>
        /// <param name="bb"></param>
        /// <param name="c1"></param>
        /// <param name="list"></param>
        public override void set(int texturestyle, Brush bb, Color c1, params int[] list)
        {
            //_size1, _size2, xi1,yi1,xi2,yi2,xii1,yii1,xii2,yii2,xiii1,yiii1,xiii2,yiii2
            this.texturestyle = texturestyle;
            this.bb = bb;
            this.c1 = c1;

            this.ai1 = list[0];
            this.bi1 = list[1];
            this.ai2 = list[2];
            this.bi2 = list[3];

            this.aii1 = list[4];
            this.bii1 = list[5];
            this.aii2 = list[6];
            this.bii2 = list[7];

            this.aiii1 = list[8];
            this.biii1 = list[9];
            this.aiii2 = list[10];
            this.biii2 = list[11];
        }
    }
}
