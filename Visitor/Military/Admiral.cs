using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Military
{
    public class Admiral : IVisitable
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public override string ToString()
        {
            return "This is admiral";
        }
    }
}
