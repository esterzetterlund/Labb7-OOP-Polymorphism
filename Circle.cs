using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
         // A subclass that represents a circle 
    public class Circle : Geometry
    {
         //Property, that holds radius
        public double _radius { get; set; }
        public Circle()
        {//constructor, who gives a solid value
            _radius = 8;
        }
         //A override of the virtual method
        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
