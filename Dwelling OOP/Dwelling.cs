using System;

namespace Dwelling_OOP
{
    public class Dwelling       // (Parent) Class to denote the address and number of rooms the dwelling contains
    {
        private string address;         // Using encapsulation so they can only be modified in this program
        private int numRooms;

        // Upon the creation of a dwelling...
        public Dwelling(string newAddress, int newNumRooms)
        {
            address = newAddress;
            numRooms = newNumRooms;
        }

        // Virtual allows subclasses to override it
        public virtual void outputData()
        {
            Program.PrintCentreText("Address: " + address);
            Program.PrintCentreText("No. Rooms: " + numRooms);
        }

        // Manually creating getters and setters 
        public string getAddress()
        {
            return address;
        }
        public int getNumRooms()
        {
            return numRooms;
        }
        public void setAddress(string newAddress)
        {
            address = newAddress;
        }
        public void setNumRooms(int newNumRooms)
        {
            numRooms = newNumRooms;
        }

    }
}
