using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Military
{
    public class Colonel : IVisitable
    {
        public void accept(IVisitor visitor)
        {
            visitor.visit(this);
        }

        public override string ToString() {
            return "this is colonel";
        }
    }
}
