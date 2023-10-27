using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
        //Baseclass : Geometry
    public class Geometry
    {
        // A virtual method, to calculate Area
        public virtual double Area()
        {
            return 0;
        }
    }
}
