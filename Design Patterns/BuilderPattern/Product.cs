using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    public  class Product
    {
        public int serving { get; set; }            //Mandatory
        public double servingSize { get; set; }     //Mandatory
        public double  calories { get; set; }       //Optional
        public double fats { get; set; }            //Optional
        public double sodium { get; set; }          //Optional

        public string showFacts()
        {
            return ("Here are some of the nutritional facts");
        }
    }
}
