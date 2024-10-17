using GuitarApp.Models;
using GuitarApp.Types;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddGuitar("1", 20000, Builder.COLLINGS, "model2", 7, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);  
            inventory.AddGuitar("2", 25000, Builder.COLLINGS, "model2", 7, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);  
            inventory.AddGuitar("3", 22000, Builder.COLLINGS, "model2", 7, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("4", 30500, Builder.FENDER, "model1", 7, Types.Types.ELECTRIC, Wood.ADIRONDACK, Wood.ALDER);
            inventory.AddGuitar("5", 1500, Builder.GIBSON, "model3", 6, Types.Types.ACOUSTIC, Wood.ADIRONDACK, Wood.INDIAN_ROSEWOOD);
            inventory.AddGuitar("6", 1000, Builder.GIBSON, "model4", 7, Types.Types.ACOUSTIC, Wood.SITKA, Wood.ALDER);
            inventory.AddGuitar("7", 15000, Builder.COLLINGS, "model2", 7, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventory.AddGuitar("8", 11000, Builder.COLLINGS, "model2", 8, Types.Types.ELECTRIC, Wood.ALDER, Wood.ALDER);

            FindGuitarTester tester = new FindGuitarTester();
            List<Guitar> listOfGuitars = tester.FindGuitar();
            if (listOfGuitars != null && listOfGuitars.Count > 0)  
            {
                Console.WriteLine("----Similar Guitars with your given specifications----");
                foreach (Guitar a in listOfGuitars)
                {
                    Console.WriteLine(a.PrintDetails());  
                }
            }
            else
            {
                Console.WriteLine("No guitars matched your specifications.");
            }
        }
    }
}
