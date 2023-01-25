using Sumeet_Ankita_HW5.DAL;
using System;
using System.Linq;


namespace Sumeet_Ankita_HW5.Utilities
{
    public static class GenerateNextOrderNumber
    {
        public static Int32 GetNextOrderNumber(AppDbContext _context)
        {
            //set a constant to designate where the order numbers 
            //should start
            const Int32 START_NUMBER = 70001;

            Int32 intMaxOrderNumber; //the current maximum order number
            Int32 intNextOrderNumber; //the course number for the next order

            if (_context.Orders.Count() == 0) //there are no orders in the database yet
            {
                intMaxOrderNumber = START_NUMBER; //Order numbers start at 70001
            }
            else
            {
                intMaxOrderNumber = _context.Orders.Max(c => c.OrderNumber); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxOrderNumber < START_NUMBER)
            {
                intMaxOrderNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextOrderNumber = intMaxOrderNumber + 1;

            //return the value
            return intNextOrderNumber;
        }

    }
}