namespace Visitor.Taxing
{
    public class Tobacco:IVisitable
    {
        public double Price { get; set; } = 2;

        public void accept(IVisitor v)
        {
            Console.WriteLine(v.Visit(this));
        }
    }
}