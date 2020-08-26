using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }
        public List<Building> cityBuildings = new List<Building>();
        public void Add(Building build)
        {
            cityBuildings.Add(build);
        }
    }



}