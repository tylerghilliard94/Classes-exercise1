using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building BuildingOne = new Building("512 8th Avenue")
            {
                Width = 200,
                Depth = 125,
                Stories = 30
            };
            Building BuildingTwo = new Building("300 East Ave.")
            {
                Width = 290,
                Depth = 200,
                Stories = 15
            };
            Building BuildingThree = new Building("158 North East Ave. South")
            {
                Width = 150,
                Depth = 150,
                Stories = 50
            };
            BuildingOne.Construct();
            BuildingTwo.Construct();
            BuildingThree.Construct();

            BuildingOne.Purchase("Gregory Parks");
            BuildingTwo.Purchase("Melissa Reynolds");
            BuildingThree.Purchase("Manny Zappy");

            City Nashville = new City()
            {
                Name = "Nashville",
                Mayor = "Brenda Long",
                Year = 2020,


            };
            Nashville.Add(BuildingOne);
            Nashville.Add(BuildingTwo);
            Nashville.Add(BuildingThree);

            foreach (Building building in Nashville.cityBuildings)
            {

                building.ListBuilding();
            }

        }
    }
}
