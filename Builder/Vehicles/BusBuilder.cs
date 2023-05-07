using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicles
{
    internal class BusBuilder : IVehicleBuilder
    {
        private Vehicle Bus;
        public BusBuilder()
        {
            Bus = new Vehicle("Bus");
        }
        public void Reset()
        {
            this.Bus = new Vehicle("Bus");
        }

        public IVehicleBuilder SetColor(string color)
        {
            Bus.color = color;
            return this;
        }

        public IVehicleBuilder SetDoors(int doors)
        {
            Bus.doors = doors;
            return this;
        }

        public IVehicleBuilder SetFrame(string frame)
        {
            Bus.frame = frame;
            return this;
        }

        public IVehicleBuilder SetName(string name)
        {
            Bus.Name = name;
            return this;
        }

        public IVehicleBuilder SetSpeed(float speed)
        {
            Bus.speed = speed;
            return this;
        }

        public IVehicleBuilder SetWheels(int wheels)
        {
            Bus.Wheels = wheels;
            return this;
        }

        public Vehicle Build()
        {
            var bus = this.Bus;
            this.Reset();
            return bus;
        }
    }
}
