public class RoadLogistics : Logistics
{
    public Transport createTransport()
    {
        return new Truck();
    }
}
