//Visitor Pattern - Behavioral
//Place the behavior intended for a Type, into a new class called visitor.
//The original object is not passed as an argument, providing the method access
//to all of it's data

//Technique called "Double-Dispatch"

using Visitor.Military;
using Visitor.Taxing;

var Client = new MilitaryClient();
var ranks = new List<Visitor.Military.IVisitable>()
{
    new Major(),
    new Colonel(),
    new Admiral(),
    new Captain()
};

var visitor1 = new ConcreteVisitor1();
var visitor2 = new ConcreteVisitor2();

Client.ClientCode(ranks, visitor1);
Client.ClientCode(ranks, visitor2);

Console.WriteLine("Taxing starts here:");
var taxClient = new TaxClient();
var items = new List<Visitor.Taxing.IVisitable>()
{
    new Liquor(),
    new Tobacco(),
    new Necessity()
};

var taxVisitor = new TaxVisitor();

taxClient.ClientCode(items, taxVisitor);    

