using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
         // A subclass that represents a ellipse
    internal class Ellipse : Geometry
    {
         //Propertys, that holds small axis and big axis
        public double _smallAxis;
        public double _bigAxis;
        public Ellipse()
        {//constructor, who gives a solid value
            _smallAxis = 5;
            _bigAxis = 7;
        }
         //A override of the virtual method
        public override double Area()
        {
            return Math.PI * (_smallAxis/2) * (_bigAxis/2);
        }
    }
}
