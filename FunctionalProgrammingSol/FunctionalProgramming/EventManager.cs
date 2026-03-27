using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class EventManager
    {
        static List<LiveEvent> Events = new List<LiveEvent>();
        static int numberOfEventsCreated = 0;

        public void PrintAllEvents()
        {
            Events.ForEach(Console.WriteLine);
        }

        public LiveEvent AddEvents(string name, DateTime date, string venue, int availiability, decimal price)
        {
            numberOfEventsCreated++;
            var newEvent = new LiveEvent(numberOfEventsCreated, name, date, venue, availiability, price);
            Events.Add(newEvent);

            return newEvent;
        }

        public LiveEvent? FindEventByID(int id)
        {
            return (LiveEvent)Events.Where(e => e.Id == id);
        }

        public bool TrySellTicketsFromEvent(LiveEvent liveEvent, int numberOfTickets)
        {
            return liveEvent.TrySellTickets(numberOfTickets);
        }

        public bool TrySellTicketsFromEvent(int id, int numberOfTickets)
        {
            var liveEvent = FindEventByID(id);

            if (liveEvent == null)
            {
                return false;
            }

            return TrySellTicketsFromEvent(liveEvent, numberOfTickets);
        }
    }
}
