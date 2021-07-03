using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public class AndSpecification: ISpecification<Product>
    {
        private IEnumerable<ISpecification<Product>> _specifications;
        public AndSpecification(IEnumerable<ISpecification<Product>> specifications)
        {
            _specifications = specifications;
        }
        public bool IsSatisfied(Product t)
        {
            foreach (var specification in _specifications)
            {
                if(!specification.IsSatisfied(t))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
