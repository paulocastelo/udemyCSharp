using CustomException.Entities;
using CustomException.Entities.Exceptions;
using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                DateTime checkIn = DateTime.Now, checkOut = DateTime.Now;
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                Reservation r = new Reservation(roomNumber, checkIn, checkOut);

                Console.WriteLine(r);
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                r.UpdateDates(checkIn, checkOut);
            }catch(DomainException d)
            {
                Console.WriteLine("Error in reservation! " + d.Message);
            }catch(FormatException f)
            {
                Console.WriteLine("Error in reservation! "+ f.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Unexpected error! Please contact the support!");
            }
        }
    }
}
