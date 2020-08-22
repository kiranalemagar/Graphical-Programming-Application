using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranAle_CompI
{
    class ShapeFactory
    {
       
        /// checking the type of shape
     
        /// <param name="shapeType"></param>
        /// <returns>return shape object </returns>
        public Shape GetShape(string shapeType)
        {
            if (shapeType == "circle")
            {
                return new Circle();
            }
            else if (shapeType == "rectangle")
            {
                return new Rectangle();
            }
            
            else if (shapeType == "triangle")
            {
                return new Triangle();
            }
            return null;
        }
    }
}
