//Creational Design pattern
//We can call the builder by itself, or using a director object

//Options builder for PC





public class PC
{
    public PC()
    {
        Color = "default_black";
        Processor = "Intel Core i5";
        RAM = 4;
        HDD = 500;
        SSD = 0;
        VideoCard= 0;
        isOverClocked= false;
        hasVideoCard=false;
        hasSSD=false;
        hasHDD = true;
    }
    public string Color { get; set; }
    public string Processor { get; set; }
    public bool isOverClocked { get; set; }
    public bool hasVideoCard { get; set; }
    public bool hasSSD { get; set; }    
    public bool hasHDD { get;set; }
    public int RAM { get; set; }
    public int SSD { get; set; }
    public int HDD { get; set; }    
    public int VideoCard { get; set; }  
}
