using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystemTask
{
    public class ClassLogin
    {
        public void RegisterOrLogin()
        {
            Console.WriteLine("----CINEMA BOOKING SYSTEM TASK----");
            Console.WriteLine("Login to any of the following:");
            Console.WriteLine("1. ClassAdmin");
            Console.WriteLine("2. ClassCustomer");
            Console.WriteLine("");

            int choice = Convert.ToInt32(Console.ReadLine());
            ClassLogin classLogin = new ClassLogin();
            ClassCustomer classCustomer = new ClassCustomer();
            ClassAdmin classAdmin = new ClassAdmin();

            switch (choice)
            {

                case 1:
                    Console.WriteLine("--- ClassAdmin Portal---");
                    Console.WriteLine("");
                    Console.WriteLine("Choose any one option:");
                    Console.WriteLine("a. Update the movie portal");
                    Console.WriteLine("b. Booking Files");

                    char choice1 = Convert.ToChar(Console.ReadLine());
                    switch (choice1)
                    {
                        case 'a':
                            Console.WriteLine("");
                            classAdmin.AddAvailableMovie();
                            Console.WriteLine();
                            break;
                        case 'b':
                            classAdmin.BookingFiles();
                            break;

                    }

                    break;
                case 2:
                TOP1:

                    Console.WriteLine("\t---ClassCustomer Portal---\t");
                    Console.WriteLine("");
                    Console.WriteLine("Choose any one option:");
                    Console.WriteLine("a. Search a movie");
                    Console.WriteLine("b. Book a movie");
                    Console.WriteLine("c. Cancel ticket");
                    Console.WriteLine("d. Check Booking Status");
                    char choice2 = Convert.ToChar(Console.ReadLine());
                    switch (choice2)
                    {
                        case 'a':
                            classCustomer.SearchMovie();
                            break;
                        case 'b':
                            classCustomer.BookAMovie();
                            break;
                        case 'c':
                            classCustomer.CancleYourTicket();
                            break;
                        case 'd':
                            Console.WriteLine("Enter Booking Id");
                            int bookingId = Convert.ToInt32(Console.ReadLine());
                            classCustomer.BookingStatus(bookingId);
                            break;

                    }
                    goto TOP1;
            }
        }
    }
}
