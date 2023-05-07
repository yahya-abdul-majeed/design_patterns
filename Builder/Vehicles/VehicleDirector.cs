using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicles
{
    internal class VehicleDirector
    {
        public IVehicleBuilder _builder;
        public VehicleDirector(IVehicleBuilder builder)
        {
            _builder = builder; 
        }

        public Vehicle BuildBlueVehicle()
        {
            var resultVehicle = _builder.SetColor("blue").Build();
            _builder.Reset();
            return resultVehicle;
        }

        public Vehicle Build3WheelerWith48Speed() {
            var resultVehicle = _builder.SetWheels(3).SetSpeed(48).Build();
            _builder.Reset();
            return resultVehicle;
        }
    }
}
