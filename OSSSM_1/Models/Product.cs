using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models
{
    public class Product
    {
        public string Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Cost { get; set; }
        public string Product_Price { get; set; }
        public string Product_Image { get; set; }
        public string Product_Text { get; set; }

        public string Product_Quanity { get; set; }
        public string Product_Size { get; set; }
        public string Product_Category { get; set; }

        public Product()
        {
            this.Product_ID = "0";
            this.Product_Name = "N/a";
            this.Product_Cost = "0";
            this.Product_Price = "0";
            this.Product_Image = "N/a";
            this.Product_Text = "N/a";
            this.Product_Quanity = "0";
            this.Product_Size = "N/a";
            this.Product_Category = "N/a";

        }

        public Product(string id, string name, string cost, string price, string image, string text, string quanity, string size, string category)
        {
            this.Product_ID = id;
            this.Product_Name = name;
            this.Product_Cost = cost;
            this.Product_Price = price;
            this.Product_Image = image;
            this.Product_Text = text;
            this.Product_Quanity = quanity;
            this.Product_Size = size;
            this.Product_Category = category;
        }
    }
}
