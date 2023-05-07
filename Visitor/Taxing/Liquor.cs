namespace Visitor.Taxing
{
    public class Liquor:IVisitable
    {
        public double Price { get; set; } = 5;

        public void accept(IVisitor v)
        {
            Console.WriteLine(v.Visit(this));
        }
    }
}