using System;
using System.Collections.Generic;

namespace ДЗ_18._11._2023
{
    internal class Buildings
    {
        public int BuildingNumber { get; private set; }
        public int Height { get; private set; }
        public int NumberOfFloors { get; private set; }
        public int NumberOfApartments { get; private set; }
        public int NumberOfEntrances { get; private set; }
        internal Buildings(int buildingNumber, int height, int numberOfFloors, int numberOfApartments, int numberOfEntrances) 
        {
            BuildingNumber = buildingNumber;
            Height = height;
            NumberOfFloors = numberOfFloors;
            NumberOfApartments = numberOfApartments;
            NumberOfEntrances = numberOfEntrances;
        }
        internal class BuildingFactory
        {
            private static Dictionary<int, Buildings> buildings = new Dictionary<int, Buildings>();
            public static Buildings CreateBuild(int buildingNumber,int height, int numberOfFloors, int numberOfApartments, int numberOfEntrances)
            {
                Buildings buildings = new Buildings(buildingNumber, height, numberOfFloors,numberOfApartments, numberOfFloors);
                buildings.Add(buildingNumber, height, numberOfFloors, numberOfApartments, numberOfFloors);
                return buildings;
            }

            public static void RemoveBuildings(int buildingNumber)
            {
                buildings.Remove(buildingNumber);
            }

            internal void RemoveBuildings(Buildings buildingNumber)
            {
                throw new NotImplementedException();
            }
        }

        private void Add(int buildingNumber, int height, int numberOfFloors1, int numberOfApartments, int numberOfFloors2)
        {
            throw new NotImplementedException();
        }

        
    }
}
