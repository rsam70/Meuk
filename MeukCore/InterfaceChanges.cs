using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeukCore
{

    // see https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/default-interface-methods-versions
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }

        // Version 1:
        //public decimal ComputeLoyaltyDiscount()
        //{
        //    DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
        //    if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))
        //    {
        //        return 0.10m;
        //    }
        //    return 0;
        //}

        // Version 2:
        public static void SetLoyaltyThresholds(
            TimeSpan ago,
            int minimumOrders = 10,
            decimal percentageDiscount = 0.10m)
        {
            length = ago;
            orderCount = minimumOrders;
            discountPercent = percentageDiscount;
        }
        private static TimeSpan length = new TimeSpan(365 * 2, 0, 0, 0); // two years
        private static int orderCount = 10;
        private static decimal discountPercent = 0.10m;

        //public decimal ComputeLoyaltyDiscount()
        //{
        //    DateTime start = DateTime.Now - length;

        //    if ((DateJoined < start) && (PreviousOrders.Count() > orderCount))
        //    {
        //        return discountPercent;
        //    }
        //    return 0;
        //}

        /// Version 3
        public decimal ComputeLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
        protected static decimal DefaultLoyaltyDiscount(ICustomer c)
        {
            DateTime start = DateTime.Now - length;

            if ((c.DateJoined < start) && (c.PreviousOrders.Count() > orderCount))
            {
                return discountPercent;
            }
            return 0;
        }
    }

    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }


    public class Cust : ICustomer
    {
        public IEnumerable<IOrder> PreviousOrders => throw new NotImplementedException();

        public DateTime DateJoined => throw new NotImplementedException();

        public DateTime? LastOrder => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public IDictionary<DateTime, string> Reminders => throw new NotImplementedException();

        public decimal ComputeLoyaltyDiscount()
        {
            if (PreviousOrders.Any() == false)
                return 0.50m;
            else
                return ICustomer.DefaultLoyaltyDiscount(this);
        }
    }

}
