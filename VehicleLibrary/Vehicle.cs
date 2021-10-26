using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public int VehicleId { get; private set; }
        public string VehicleType { get; private set; }
        public DateTime EnterTime { get; private set; }
        public DateTime ExitTime { get; private set; }

        public Vehicle(int vehicleId, string vehicleType, DateTime enterTime, DateTime exitTime)
        {
            VehicleId = vehicleId;
            VehicleType = vehicleType;
            EnterTime = enterTime;
            ExitTime = exitTime;
        }
    }
}
