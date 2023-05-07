//Creational Design pattern
//We can call the builder by itself, or using a director object

//Options builder for PC





public class PCBuilder : IPCBuilder
{
    private PC PC { get; set; }
    public PCBuilder()
    {
        PC = new PC();
    }
    public IPCBuilder AddHDD(int HDD_AmountInGigs)
    {
        PC.HDD = HDD_AmountInGigs;
        PC.hasHDD= true;
        return this;
    }

    public IPCBuilder AddRAM(int RAM_AmountInGigs)
    {
        PC.RAM = PC.RAM + RAM_AmountInGigs;
        return this;
    }

    public IPCBuilder AddSSD(int SSD_AmountInGigs)
    {
        PC.SSD = SSD_AmountInGigs;  
        PC.hasSSD= true;
        return this;
    }

    public IPCBuilder AddVideoCard(int GPU_AmountInGigs)
    {
        PC.VideoCard= GPU_AmountInGigs;
        PC.hasVideoCard= true;
        return this;
    }

    public IPCBuilder ChangeColor(string color)
    {
        PC.Color = color;
        return this;
    }

    public IPCBuilder OverClockProcessor()
    {
        PC.isOverClocked= true;
        return this;
    }

    public IPCBuilder RemoveSSD()
    {
        PC.hasSSD= false;
        PC.SSD = 0;
        return this;
    }

    public IPCBuilder RemoveHDD()
    {
        PC.hasHDD = false;
        PC.HDD = 0;
        return this;
    }

    public IPCBuilder RemoveVideoCard()
    {
        PC.VideoCard = 0;
        PC.hasVideoCard = false;
        return this;
    }

    public PC Build()
    {
        var pc = this.PC;
        this.Reset();
        return pc;
    }

    public void Reset()
    {
        this.PC = new PC();
    }
}