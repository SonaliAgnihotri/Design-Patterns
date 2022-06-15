using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BuilderPattern
{
    /// <summary>
    /// Specifies methods for creating different parts of Product object
    /// </summary>
    public abstract class AbstractBuilder
    {
        protected Product product;

        public void createNutritioanlFact()
        {
            product = new Product();
        }

        public Product getProductType()
        {
            return product;
        }

        public abstract void SetProductType();

        public abstract void SetServingPerContainer();
        public abstract void SetServingSize();
        public abstract void SetOtherFacts();

    }
}
