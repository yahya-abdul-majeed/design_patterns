public class SeaLogistics : Logistics
{
    public Transport createTransport()
    {
        return new Ship();
    }
}
