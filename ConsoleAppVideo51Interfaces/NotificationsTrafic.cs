using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppVideo51Interfaces
{
    //CREATED BY Jesshael

    //CALL OF THE INTERFACE NOTIFICATIONS
    class NotificationsTrafic : INotifications
    {
        // DECLARATION OF VARIABLES

        private string foward;
        private string message;
        private string date;

        // CONSTRUCTOR
        public NotificationsTrafic()
        {
            foward = "DGT";

            message = "Ticket of Sanction: Pay before 3 days and deduce of your ticket on 50%";

            date = "";
        }

        //CONSTRUCTOR OVERLOADED
        public NotificationsTrafic(string foward, string message, string date)
        {
            this.foward = foward;
            this.message = message;
            this.date = date;
        }



        public string getDate()
        {
            return date;
        }

        public void showNotification()
        {
            Console.WriteLine("Message {0} has been send for {1} the day {2}", message, foward, date);
        }
    }
}
