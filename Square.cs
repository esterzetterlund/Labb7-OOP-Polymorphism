using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
         // A subclass that represents a square
    internal class Square : Geometry
    {
         //Property, that holds side
        public double _side { get; set; }
        public Square()
        {//constructor, who gives a solid value
            _side = 7;
        }
         //A override of the virtual method
        public override double Area()
        {
            return _side * _side;
        }
    }
}
