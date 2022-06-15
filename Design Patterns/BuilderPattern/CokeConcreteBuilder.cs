using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    public class CokeConcreteBuilder: AbstractBuilder
    {
        /// <summary>
        /// Concrete builder class follows the builder abstract class and provide specific implementations 
        /// </summary>
        public override void SetProductType()
        {
            Console.WriteLine("Nutritional value for Coke");
        }

        public override void SetServingPerContainer()
        {
            Console.WriteLine("Serving per Can : 1 can");

        }

        public override void SetServingSize()
        {
            Console.WriteLine("Serving size: 250ml");
        }

        public void setSodiumLevel()
        {
            Console.WriteLine("Sodium: 35mg"); 
        }

        public override void SetOtherFacts()
        {
            Console.WriteLine("Sodium: 35mg");

        }
    }
}
