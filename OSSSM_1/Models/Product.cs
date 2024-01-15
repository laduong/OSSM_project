using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OSSSM_1.Models
{
    public class Product
    {
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int Product_Cost { get; set; }
        public int Product_Price { get; set; }
        public string Product_Image { get; set; }
        public string Product_Text { get; set; }

        public int Product_Quanity { get; set; }
        public string FK_Category_ID { get; set; }

        public Product()
        {
            this.Product_ID = "0";
            this.Product_Name = "N/a";
            this.Product_Cost = 0;
            this.Product_Price = 0;
            this.Product_Image = "default.png";
            this.Product_Text = "N/a";
            this.Product_Quanity = 0;
            this.FK_Category_ID = "N/a";

        }

        public Product(string id, string name, int cost, int price, string image, string text, int quanity, string category)
        {
            this.Product_ID = id;
            this.Product_Name = name;
            this.Product_Cost = cost;
            this.Product_Price = price;
            this.Product_Image = image;
            this.Product_Text = text;
            this.Product_Quanity = quanity;
            this.FK_Category_ID = category;
        }

        public Product(DataRow row)
        {
            this.Product_ID = (string)row["Product_ID"];
            this.Product_Name = (string)row["Product_Name"];
            this.Product_Cost = (int)row["Product_Cost"];
            this.Product_Price = (int)row["Product_Price"];
            this.Product_Image = (string)row["Product_Image"];
            this.Product_Text = (string)row["Product_Text"];
            this.Product_Quanity = Convert.ToInt32(row["Product_Quanity"]);
            this.FK_Category_ID = (string)row["FK_Category_ID"];
        }

    }
}
