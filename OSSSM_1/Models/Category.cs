using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace OSSSM_1.Models
{
    public class Category
    {
        public string Category_ID { get; set; }
        public string Category_Name { get; set; }

        public Category()
        {
            this.Category_ID = "N/a";
            this.Category_Name = "N/a";

        }

        public Category(string id, string name)
        {
            this.Category_ID = id;
            this.Category_Name = name;
        }
        public Category(DataRow row)
        {
            this.Category_ID = (string)row["Category_ID"];
            this.Category_Name = (string)row["Category_Name"];
        }
    }
}
