using System;

namespace Dwelling_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating our objects (dwellings) off the classes
            Dwelling dwelling1 = new Dwelling("13 Queen Street", 2);
            Dwelling dwelling2 = new Dwelling("56 Smith Avenue", 1);
            Dwelling dwelling3 = new Dwelling("12 Macey Terrace", 4);

            Bungalow bungalow1 = new Bungalow("24 Copper Lane", 4, true);
            Bungalow bungalow2 = new Bungalow("5 Mary Road", 5, false);

            House house1 = new House("12 Perry Avenue", 3, "Detached", 2);

            // Calling the output methods in the Dwelling class
            Console.WriteLine("");
            PrintCentreText("Dwelling 1");
            dwelling1.outputData();
            Console.WriteLine("");
            PrintCentreText("Dwelling 2");
            dwelling2.outputData();
            Console.WriteLine("");

            // An example of how to use the getters
            PrintCentreText("Dwelling 3");
            PrintCentreText(dwelling3.getAddress() + " has " + dwelling3.getNumRooms() + " rooms.\n");

            // Using inheritance and overriding to call the output method
            PrintCentreText("Bungalow 1");
            bungalow1.outputData();
            Console.WriteLine("");
            PrintCentreText("Bungalow 2");
            bungalow2.outputData();
            Console.WriteLine("");

            // Example of before and after using the set methods
            PrintCentreText("House 1");
            house1.outputData();
            Console.WriteLine("");
            PrintCentreText("** Setting house to semi-detached, with 5 floors instead of 3 **\n");
            PrintCentreText("House 1 [updated]");
            house1.setNumFloors(5);     // As num floors needs to be validated, it has been set to private and given its own method
            house1.type = "Semi-Detached";
            // After setting values
            house1.outputData();
            Console.WriteLine("");

            Console.ReadLine();         // To prevent the screen instantly closing
        }
        public static void PrintCentreText(string textToEnter)        // Sending text to print in the centre of the screen
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
        }
    }
}
