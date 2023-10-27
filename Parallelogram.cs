using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
         // A subclass that represents a parallelogram
    internal class Parallelogram : Geometry
    {
         //Propertys, that holds width and height
        public double _width { get; set; }
        public double _height { get; set; }
        public Parallelogram()
        {//constructor, who gives a solid value
            _width = 6;
            _height = 3;
        }
         //A override of the virtual method
        public override double Area()
        {
            return _width * _height;
        }
    }
}
