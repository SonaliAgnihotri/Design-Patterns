using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    public class Director
    {
        /// <summary>
        /// Director class is responsible for executong the building steps in a particular sequence. Is is helpful while creating 
        /// products according to specific order or configuration. 
        /// Director class is optional. Client can directly controls builders.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public Product NutritionalFactDirectorMethod(AbstractBuilder builder)
        {
            builder.createNutritioanlFact();
            builder.SetProductType();
            builder.SetServingSize();
            builder.SetServingPerContainer();
            builder.SetOtherFacts();
            return builder.getProductType();
        }
    }
}
