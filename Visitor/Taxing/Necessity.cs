namespace Visitor.Taxing
{
    public class Necessity:IVisitable
    {
        public double Price { get; set; } = 20;

        public void accept(IVisitor v)
        {
            Console.WriteLine(v.Visit(this));
        }
    }
}