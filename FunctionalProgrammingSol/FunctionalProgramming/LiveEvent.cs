using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LiveEvent
    {
        public int Id { get; }
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public string Venue { get; private set; }
        public int Availiability { get; private set; }

        public decimal Price { get; private set; }

        public LiveEvent(int id, string name, DateTime date, string venue, int availiability, decimal price)
        {
            ID = id;
            Name = name;
            Date = date;
            Venue = venue;
            Availiability = availiability;
            Price = price;
        }

        public bool TrySellTickets(int numberOfTickets)
        {
            if (Availiability >= numberOfTickets)
            {
                Availiability -= numberOfTickets;
                return true;
            }
            return false;
        }

        public void AddTickets(int numberOfTickets)
        {
            Availiability += numberOfTickets;
        }

        public override string ToString()
        {
            return $"ID: {Id}" + Environment.NewLine
                + $"Name: {Name}" + Environment.NewLine
                + $"Date: {Date}" + Environment.NewLine
                + $"Venue: {Venue}" + Environment.NewLine
                + $"Ticket(s) Left: {Availiability}" + Environment.NewLine
                + $"Price: £{Price}" + Environment.NewLine;

        }
    }
}
