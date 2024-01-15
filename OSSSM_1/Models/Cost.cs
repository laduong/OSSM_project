using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace OSSSM_1.Models
{
    public class Cost
    {
        public string Cost_ID { get; set; }
        public string Cost_Name { get; set; }
        public int Cost_Value { get; set; }
        public int Cost_Type { get; set; } // 0: Chi phi co dinh, 1: Chi phi biến đổi, 2: Nợ
        public DateTime? Cost_Date { get; set; }



        public Cost(string id, string name, int value, int type, DateTime? date)
        {
            this.Cost_ID = id;
            this.Cost_Name = name;
            this.Cost_Value = value;
            this.Cost_Type = type;
            this.Cost_Date = date;

        }
        public Cost(DataRow row)
        {
            this.Cost_ID = (string)row["Cost_ID"];
            this.Cost_Name = (string)row["Cost_Name"];
            this.Cost_Value = Convert.ToInt32(row["Cost_Value"]);
            this.Cost_Date = (DateTime?)row["Cost_Date"];
            this.Cost_Type = Convert.ToInt32(row["Cost_Type"]);
        }
    }
}
