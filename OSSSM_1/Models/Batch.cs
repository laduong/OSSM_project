using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace OSSSM_1.Models
{
    public class Batch
    {
        public string Batch_ID { get; set; }
        public string Batch_Name { get; set; }
        public DateTime? Batch_BuyDate { get; set; }
        public int Batch_TotalValue { get; set; }

        

        public Batch(string id, string name , DateTime? buydate, int totalvalue)
        {
            this.Batch_ID = id;
            this.Batch_Name = name;
            this.Batch_BuyDate = buydate;
            this.Batch_TotalValue = totalvalue;
        }
        public Batch(DataRow row)
        {
            this.Batch_ID = (string)row["Batch_ID"];
            this.Batch_Name = (string)row["Batch_Name"];
            this.Batch_BuyDate = (DateTime?)row["Batch_BuyDate"];
            this.Batch_TotalValue = (int)row["Batch_TotalValue"];
        }
    }

}
