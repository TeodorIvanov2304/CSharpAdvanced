﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public class PassengerCar : Vehicle
    {
        private const double PassengerCarMaxMileage = 450;
        public PassengerCar(string brand, string model, string licensePlateNumber) : base(brand, model, PassengerCarMaxMileage, licensePlateNumber)
        {

        }
    }
}
