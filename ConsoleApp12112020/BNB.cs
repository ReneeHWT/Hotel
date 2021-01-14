using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12112020
{
    class BNB : Hotel
    {
        public BNB() : this(1, 888, "Taichung", 1)
        {
            Console.WriteLine("Initialization by default construct");
        }
        public BNB(int guestNum1, int roomNum1, string location1, int roomLeft1) : base(guestNum1, roomNum1, location1, roomLeft1)
        {
            Console.WriteLine("Initialization by parameter construct");
        }
    }
}
