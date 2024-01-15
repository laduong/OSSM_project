using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models
{
    public class Dashboard
    {
        public int Profit { get; set; }
        public int Number_Bill { get; set; }
        public int Cost_Value { get; set; }
        public int Bill_Value { get; set; }
        List<Product> Product { get; set; }
        List<BillDetail> BillDetails { get; set; }
        List<BatchDetail> BatchDetails { get; set; }
        public Dashboard(int profit, int cost, int bill, int number)
        {
            this.Profit = profit;
            this.Number_Bill = number;
            this.Bill_Value = bill;
            this.Cost_Value = cost;
        }

    }
}
