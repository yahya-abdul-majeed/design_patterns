using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Taxing
{
    internal class TaxVisitor : IVisitor
    {
        public double Visit(Liquor liquorItem)
        {
            return liquorItem.Price * .2;
        }

        public double Visit(Tobacco tobaccoItem)
        {
            return tobaccoItem.Price * .5;
        }

        public double Visit(Necessity necessityItem)
        {
            return necessityItem.Price * .45;
        }
    }
}
