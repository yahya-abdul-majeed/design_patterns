using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicles
{
    internal interface IVehicleBuilder
    {
        public IVehicleBuilder SetDoors(int doors);
        public IVehicleBuilder SetFrame(string frame);
        public IVehicleBuilder SetSpeed(float speed);
        public IVehicleBuilder SetWheels(int wheels);
        public IVehicleBuilder SetColor(string color);
        public IVehicleBuilder SetName(string name);
        public void Reset();
        public Vehicle Build();
    }
}
