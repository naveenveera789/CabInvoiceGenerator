using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        public double distance;
        public int time;
        public const double COST_PER_KILOMETER = 10.0, COST_PER_MINUTE = 1.0, MINIMUM_FARE = 5.0;
        public double CalculateCabFare(double distance, int time)
        {
            double totalFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
            if (totalFare < MINIMUM_FARE)
            {
                return MINIMUM_FARE;
            }
            return totalFare;
        }
    }
}