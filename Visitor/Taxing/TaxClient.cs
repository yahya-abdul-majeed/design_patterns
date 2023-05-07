using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Taxing
{
    internal class TaxClient
    {
        public void ClientCode(List<IVisitable> elements, IVisitor visitor)
        {
            foreach (IVisitable element in elements)
            {
                element.accept(visitor);
                Console.WriteLine();
            }
        }
    }
}
