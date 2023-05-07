using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicles
{
    internal class BicycleBuilder : IVehicleBuilder
    {
        private Vehicle bicycle;
        public BicycleBuilder()
        {
            bicycle= new Vehicle("Bicycle");
        }

        public void Reset()
        {
            this.bicycle = new Vehicle("Bicycle");
        }

        public IVehicleBuilder SetColor(string color)
        {
            bicycle.color = color;
            return this;
        }

        public IVehicleBuilder SetDoors(int doors)
        {
            bicycle.doors= doors;
            return this;
        }

        public IVehicleBuilder SetFrame(string frame)
        {
            bicycle.frame = frame;
            return this;
        }

        public IVehicleBuilder SetName(string name)
        {
            throw new NotImplementedException();
        }

        public IVehicleBuilder SetSpeed(float speed)
        {
            bicycle.speed = speed;
            return this;
        }

        public IVehicleBuilder SetWheels(int wheels)
        {
            bicycle.Wheels = wheels;
            return this;
        }

        public Vehicle Build()
        {
            var bicycle = this.bicycle;
            this.Reset();
            return bicycle;
        }
    }
}
