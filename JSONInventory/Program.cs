namespace JSONInventory 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            string path = "C:\\Users\\Admin\\Documents\\Day11&12\\JSONInventory\\JSONInventory\\jsconfig1.json";
            RateTheData readTheData = new RateTheData();
            InventoryDetails data = readTheData.Read(path);
            Console.WriteLine("Types of Rice");
            for(int i=0;i<data.typesOfRice.Count;i++) 
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine("------------------------------");
                Console.WriteLine("______________________________");

            }
            Console.WriteLine("Types of Wheet");
            for (int i = 0; i < data.typesOfWheet.Count; i++)
            {
                Console.WriteLine(data.typesOfWheet[i].name);
                Console.WriteLine(data.typesOfWheet[i].weight);
                Console.WriteLine(data.typesOfWheet[i].price);
                Console.WriteLine("------------------------------");
                Console.WriteLine("______________________________");

            }
            Console.WriteLine("Types of Pulses");
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
                Console.WriteLine("------------------------------");
                Console.WriteLine("______________________________");

            }

        }
    }
}