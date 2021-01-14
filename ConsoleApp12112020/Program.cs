using System;


namespace ConsoleApp12112020
{

    class Program
    {
        static void Main(string[] args)
        {
          
            Hotel marriot = new Hotel(2, 1, "Taipei",0);
            Hotel hilton = new Hotel(4, 2, "Kaohsiung",8);
            BNB howard = new BNB(3,2, "Taoyuan", 0);//BNB可以繼承Hotel 的建構式嗎？

            

            Console.WriteLine(marriot.guestNum +" guests need " +marriot.roomNum + " room(s) in "+ marriot.location +".");
            Console.WriteLine("Is Marriot available?");
            Console.WriteLine(marriot.Avail());
            Console.ReadLine();


            Console.WriteLine(hilton.guestNum + " guests need " + hilton.roomNum + " room(s) in " + hilton.location + ".");
            Console.WriteLine("Is Hilton available?");
            Console.WriteLine(hilton.Avail());
            Console.ReadLine();

            
           
            Console.WriteLine(howard.guestNum + " guests need " + howard.roomNum + " room(s) in " + howard.location + ".");
            Console.WriteLine("Is Howard available?");
            Console.WriteLine(howard.Avail());
            Console.ReadLine();
        }
            
          

    }

    
}
