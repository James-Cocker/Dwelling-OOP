using System;

namespace Dwelling_OOP
{
    class Bungalow : Dwelling          // Using : to denote inheritance
    {
        public bool dormer { get; set; }            // Automatically creating the get and set methods

        // Upon the creation of a new bungalow...
        public Bungalow(string newAddress, int newNumRooms, bool newDormer) : base(newAddress, newNumRooms)
        {
            dormer = newDormer;
        }

        // Use override to replace a method in the parent class.
        public override void outputData()
        {
            base.outputData();          // Use base in to refer to methods in the parent class
            Program.PrintCentreText("Dormer?: " + dormer);
        }
    }
}
