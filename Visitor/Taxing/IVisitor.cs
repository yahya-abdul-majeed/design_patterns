using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Taxing
{
    public interface IVisitor
    {
        public double Visit(Liquor liquorItem);
        public double Visit(Tobacco tobaccoItem);
        public double Visit(Necessity necessityItem);
    }
}
