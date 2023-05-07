using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Military
{
    internal class ConcreteVisitor2 : IVisitor
    {
        public void visit(Admiral admiral)
        {
            Console.Write(admiral.ToString()+ " 2");
        }

        public void visit(Captain captain)
        {
            Console.Write(captain.ToString() + " 2");
        }

        public void visit(Colonel colonel)
        {
            Console.Write(colonel.ToString() + " 2");
        }

        public void visit(Major major)
        {
            Console.Write(major.ToString() + " 2");
        }
    }
}
