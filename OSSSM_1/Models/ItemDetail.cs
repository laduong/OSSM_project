using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models
{
    public class ItemDetail
    {
       
        public List<Items> Item_List { get; set; }
        public string ID { get; set; }
        public DateTime? BuyDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ItemDetail(List<Items> items, string ID, DateTime? buydate, string name)
        {
            this.Item_List = items;
            this.ID = ID;
            this.BuyDate = buydate;
            this.Name = name;
        }
        public ItemDetail(List<Items> items, string ID, DateTime? buydate, string name, string address)
        {
            this.Item_List = items;
            this.ID = ID;
            this.BuyDate = buydate;
            this.Name = name;
            this.Address = address;
        }
    }
}
