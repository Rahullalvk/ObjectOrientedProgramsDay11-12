using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONInventory
{
    public class RateTheData
    {

        public InventoryDetails Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            } 
        }
    }
}
            