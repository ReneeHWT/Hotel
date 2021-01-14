using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12112020
{
    public class Hotel
    {
        public int guestNum;
        public int roomNum;
        public string location;
        public int roomLeft;


        public Hotel(int guestNum1, int roomNum1, string location1, int roomLeft1)
        {
            guestNum = guestNum1;
            roomNum = roomNum1;
            location = location1;
            roomLeft = roomLeft1;
        }

        public void MakeReservation()
        {
            Console.WriteLine("Make a reservation now.");
        }

        public bool Avail()
        {
            if (roomLeft < 1)
            {
                return false;
            }
            return true;
        }


    }

    

   
}
