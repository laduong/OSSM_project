using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace OSSSM_1.Models
{
    public class BatchDetail
    {
        public string id { get; set; }
        public string FK_Batch_ID { get; set; }
        public string FK_Product_ID { get; set; }
        public int BatchDetail_Quanity { get; set; }

        public BatchDetail()
        {
            this.id = "N/a";
            this.FK_Batch_ID = "N/a";
            this.FK_Product_ID = "N/a";
            this.BatchDetail_Quanity = 0;
        }

        public BatchDetail(string id, string batch, string product, int quanity)
        {
            this.id = id;
            this.FK_Batch_ID = batch;
            this.FK_Product_ID = product;
            this.BatchDetail_Quanity = quanity;
        }
        public BatchDetail (DataRow row)
        {
            this.id = (string)row["Id"];
            this.FK_Batch_ID = (string)row["FK_Batch_ID"];
            this.FK_Product_ID = (string)row["FK_Product_ID"];
            this.BatchDetail_Quanity = Convert.ToInt32(row["BatchDetail_Quanity"]);
        }
    }
}

