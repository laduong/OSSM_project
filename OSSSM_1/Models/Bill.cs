using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace OSSSM_1.Models
{
    public class Bill
    {
        public string Bill_ID { get; set; }
        public string Bill_Name { get; set; }
        public string Bill_Address { get; set; }
        public DateTime? Bill_SellDate { get; set; }
        public int Bill_TotalValue { get; set; }



        public Bill(string id, string name, string address,  DateTime? selldate, int totalvalue)
        {
            this.Bill_ID = id;
            this.Bill_Name = name;
            this.Bill_Address = address;
            this.Bill_SellDate = selldate;
            this.Bill_TotalValue = totalvalue;
        }
        public Bill(DataRow row)
        {
            this.Bill_ID = (string)row["Bill_ID"];
            this.Bill_Name = (string)row["Bill_Name"];
            this.Bill_Address = (string)row["Bill_Address"];
            this.Bill_SellDate = (DateTime?)row["Bill_SellDate"];
            this.Bill_TotalValue = Convert.ToInt32(row["Bill_TotalValue"]);
        }
    }
}
