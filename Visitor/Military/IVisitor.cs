namespace Visitor.Military
{
    public interface IVisitor
    {
        void visit(Major major);
        void visit(Captain captain);
        void visit(Colonel colonel);
        void visit(Admiral admiral);
    }
}