using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipApp
{
   public class Ship
    {
        const int CycleWeight = 3;
        const int CarWeight = 5;
        const int TruckWeight = 11;
        const int TrainWeight =17;

        const int MaxWeight = 10;

        //Property
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCount { get; set; }
        public int Capacity { get; set; }

        Random random = new Random();
        //Method
        public int GetShipLoad()
        {
            return CycleCount * CycleWeight + CarCount * CarWeight + TruckCount * TruckWeight + TrainCount * TrainWeight;
        }
        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TrainCount = 0;
            TruckCount = 0;

            Capacity = random.Next(MaxWeight) * CycleWeight + random.Next(MaxWeight) * CarCount + random.Next(MaxWeight) * TrainWeight + random.Next(MaxWeight) * TruckWeight;
        }
        public int OverUnder()
        {
            return Capacity - GetShipLoad();
        }
        public override string ToString()
        {
            return "Capacity = " + Capacity + ", CurrentLoad = " + GetShipLoad();
        }
    }
}
