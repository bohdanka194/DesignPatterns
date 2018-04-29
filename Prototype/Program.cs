using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var beerParty = GetExistingEvent();
            var nextFridayEvent = (CalendarEvent)beerParty.Clone();
            nextFridayEvent.StartDateAndTime = new DateTime(2018, 5, 4, 18, 0, 0);
            nextFridayEvent.Attendees[0].EmailAddress = "bohdanka194@gmail.com";
            nextFridayEvent.Priority.SetPriorityValue(0);

            if (beerParty.Attendees != nextFridayEvent.Attendees)
            {
                Console.WriteLine("GOOD: Each event has own list of attendees.");
            }
            if (beerParty.Attendees[0].EmailAddress == nextFridayEvent.Attendees[0].EmailAddress)
            {
                // персональні дані залишаються тими ж
                Console.WriteLine("GOOD: If I updated my e-mail address it will be updated in all events.");
                Console.WriteLine(beerParty.Attendees[0].EmailAddress);
            }
            if (beerParty.Priority.IsHigh() != nextFridayEvent.Priority.IsHigh())
            {
                Console.WriteLine("GOOD: Each event should have own priority object, fully-copied.");
            }

            Console.ReadLine();

        }
        public static CalendarEvent GetExistingEvent()
        {
            var beerParty = new CalendarEvent();
            var friends = new Attendee[1];
            var andriy = new Attendee{ FirstName = "Andriy", LastName = "Andrienko" };
            friends[0] = andriy;

            beerParty.Attendees = friends;
            beerParty.StartDateAndTime = new DateTime(2018,4,29,18,0,0);
            beerParty.Priority = Priority.High();

            return beerParty;
        }
    }
}
