using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONInventory
{
    public class InventoryDetails
    {
        public List<TypesOfRice> typesOfRice;
        public List<TypesOfWheet> typesOfWheet;
        public List<TypesOfPulses> typesOfPulses;

    }
    public class TypesOfRice
    {
        public string name;
        public string weight;
        public string price;
    }
    public class TypesOfWheet
    {
        public string name;
        public string weight;
        public string price;
    }
    public class TypesOfPulses
    {
        public string name;
        public string weight;
        public string price;
    }
}

