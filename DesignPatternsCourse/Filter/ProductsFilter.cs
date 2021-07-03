using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class ProductsFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach(var item in items)
            {
                if(spec.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}
