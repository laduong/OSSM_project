using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models
{
    public class Items
    {
        public Product Item { get; set; }
        public int Number { get; set; }
        public Items(Product products, int number)
        {
            this.Item = products;
            this.Number = number;
        }
    }
}
