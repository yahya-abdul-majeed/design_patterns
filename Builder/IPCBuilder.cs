//Creational Design pattern
//We can call the builder by itself, or using a director object

//Options builder for PC








public interface IPCBuilder
{
    public void Reset();
    public IPCBuilder OverClockProcessor();
    public IPCBuilder AddVideoCard(int GPU_AmountInGigs);
    public IPCBuilder AddSSD(int SSD_AmountInGigs);
    public IPCBuilder AddHDD(int HDD_AmountInGigs);
    public IPCBuilder AddRAM(int RAM_AmountInGigs);
    public IPCBuilder RemoveSSD();
    public IPCBuilder RemoveHDD();
    public IPCBuilder RemoveVideoCard();
    public IPCBuilder ChangeColor(string color);
    public PC Build();
}
