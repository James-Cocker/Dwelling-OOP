using System;

namespace Dwelling_OOP
{
    class House : Dwelling          // Using : to denote inheritance
    {
        public string type { get; set; }            // Automatically creating the get and set methods
        public int numFloors { get; private set; }  // Private set, as we do not want to be able to set the value outside this code (to ensure the value is valid)

        // Upon the creation of a new house...
        public House(string newAddress, int newNumRooms, string newType, int newNumFloors) : base(newAddress,newNumRooms)
        {
            type = newType;
            numFloors = newNumRooms;
        }

        public override void outputData()           // Use override to replace a method in the parent class.
        {
            base.outputData();                      // Use base in to refer to methods in the parent class
            Program.PrintCentreText("Type: " + type);
            Program.PrintCentreText("Floors: " + numFloors);
        }

        public void setNumFloors(int newNumFloors)          // Manual set method to set a new number of floors
        {
            if(newNumFloors > 0 && newNumFloors <= 200)     // Validation
            {
                numFloors = newNumFloors;
            }
            else
            {
                Program.PrintCentreText("Invalid number of floors");
            }
        }
    }
}
