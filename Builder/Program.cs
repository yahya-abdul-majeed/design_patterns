//Creational Design pattern
//We can call the builder by itself, or using a director object

//Options builder for PC



using Builder.Vehicles;

var builder = new PCBuilder();
PC defaultPC = builder.Build();
PC greenPC_overclocked = builder.ChangeColor("green").OverClockProcessor().Build();
PC fullySpecced = builder.ChangeColor("blue").OverClockProcessor().AddHDD(1000)
                .AddSSD(500).AddVideoCard(16).AddRAM(16).RemoveSSD().Build();


var v_builder = new BusBuilder();
var director = new VehicleDirector(v_builder);
var vehicle = director.Build3WheelerWith48Speed();
var another_vehicle = director.BuildBlueVehicle();

var special_vehicle = v_builder.SetColor("red").SetName("yahya's bus").SetFrame("large").Build();


 Console.ReadLine();
