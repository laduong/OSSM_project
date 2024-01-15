using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace OSSSM_1.Models
{
    public class BillDetail
    {
        public string id { get; set; }
        public string FK_Bill_ID { get; set; }
        public string FK_Product_ID { get; set; }
        public int BillDetail_Quanity { get; set; }

        public BillDetail()
        {
            this.id = "N/a";
            this.FK_Bill_ID = "N/a";
            this.FK_Product_ID = "N/a";
            this.BillDetail_Quanity = 0;
        }

        public BillDetail(string id, string batch, string product, int quanity)
        {
            this.id = id;
            this.FK_Bill_ID = batch;
            this.FK_Product_ID = product;
            this.BillDetail_Quanity = quanity;
        }
        public BillDetail(DataRow row)
        {
            this.id = (string)row["Id"];
            this.FK_Bill_ID = (string)row["FK_Bill_ID"];
            this.FK_Product_ID = (string)row["FK_Product_ID"];
            this.BillDetail_Quanity = Convert.ToInt32(row["BillDetail_Quanity"]);
        }
    }
}
