using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    /// <summary>
    /// Concrete Builders are supposed to provide their own methods for retrieving results, because several types of builders 
    /// may create entirely differet products that don follow the abstract class or same interface.So such methods are 
    /// not placed in abstract builders
    /// </summary>
    public class MaggieConcreteBuilder: AbstractBuilder
    {
        public override void SetProductType()
        {
            Console.WriteLine("Nutritional value for Maggie");
        }
        public override void SetServingPerContainer()
        {
            Console.WriteLine("Serving per packet : 200gms");
        }

        public override void SetServingSize()
        {
            Console.WriteLine("Serving size: 100gms");
        }

        public void setFatsLevel()
        {
            Console.WriteLine("Fats: 300gms");
        }

        public override void SetOtherFacts()
        {
            Console.WriteLine("Fats: 300gms");

        }

    }
}
