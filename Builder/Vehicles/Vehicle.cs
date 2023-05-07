using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Vehicles
{
    internal class Vehicle
    {
        public Vehicle(string name) {
            Name = name;
            Wheels = 4;
            doors = 4;
            frame = "car frame";
            color = "white";
            speed = 28.5f;
        }
        public string Name { get; set; }
        public int Wheels { get;set; }
        public int doors { get; set; }  
        public string frame { get; set; }   
        public string color { get; set; }
        public float speed { get; set; }
    }
}
