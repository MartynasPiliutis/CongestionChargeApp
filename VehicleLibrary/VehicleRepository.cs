using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    class VehicleRepository
    {
        private List<Vehicle> VehiclePassList;

        public VehicleRepository()
        {
            VehiclePassList = new List<Vehicle>();
            VehiclePassList.Add(new Vehicle(321123, "Car", new DateTime(2008, 4, 24, 11, 32, 0), new DateTime(2008, 4, 24, 14, 42, 0)));
            VehiclePassList.Add(new Vehicle(123321, "Motorbike", new DateTime(2008, 4, 24, 17, 0, 0), new DateTime(2008, 4, 24, 22, 11, 0)));
            VehiclePassList.Add(new Vehicle(112233, "Van", new DateTime(2008, 4, 25, 10, 23, 0), new DateTime(2008, 4, 28, 9, 2, 0)));
        }

    }
}
