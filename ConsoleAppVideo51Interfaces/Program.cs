using System;

namespace ConsoleAppVideo51Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // SAMPLE BUILDING FOR JESSHAEL

            NotificationsTrafic trafic1 = new NotificationsTrafic();
            NotificationsTrafic trafic2 = new NotificationsTrafic("Location Fort Worth", "Speed Velocity", DateTime.Now.ToString() );

            trafic1.showNotification();

            Console.WriteLine(trafic2.getDate());

            trafic2.showNotification();

            

        }

    }
}
