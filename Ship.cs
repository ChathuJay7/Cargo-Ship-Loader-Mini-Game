using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShipGUI
{
    class Ship
    {
        // constant values
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;

        const int MAX_WEIGHT = 10;

        // propeties for the class
        public int Capacity { get; set; }

        public int CycleCount { get; set; }

        public int CarCount { get; set; }

        public int TruckCount { get; set; }

        public int TrainCarCount { get; set; }

        Random random = new Random();

        // methods (functions)
        public int getShipLoad()
        {
            // calculate the total weight of the cargo on the ship.
            return CycleCount * CYCLE_WEIGHT + CarCount * CAR_WEIGHT + TruckCount * TRUCK_WEIGHT + TrainCarCount * TRAIN_WEIGHT;
        }

        //constructor - called when a new instance is created
        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            // create a random sized ship
            Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT + random.Next(MAX_WEIGHT) * CAR_WEIGHT + random.Next(MAX_WEIGHT) * TRUCK_WEIGHT + random.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
        }

        public int overUnder()
        {
             // return a value of how loaded the ship is
             return Capacity - getShipLoad();
        }

        public override string ToString()
        {
            return "Capacity = " + Capacity + ", CurrentLoad = " + getShipLoad();
        }
    }
}
