﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNuts { get; set; }
        public double GramsofFlour { get; set; }


        public Cookie()
        { 
        
        }
       

        public Cookie(string name, bool hasNuts, double gramsofFlour)
        {
            Name = name;
            HasNuts = hasNuts;
            GramsofFlour = gramsofFlour;

        }

    }
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

    }

    public class Order
    { 
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
            
    }
}
