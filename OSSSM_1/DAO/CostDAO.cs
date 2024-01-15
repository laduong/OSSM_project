using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OSSSM_1.Models;

namespace OSSSM_1.DAO
{
    public class CostDAO
    {
        private static CostDAO instance;
        public static CostDAO Instance
        {
            get { if (instance == null) instance = new CostDAO(); return CostDAO.instance; }
            private set { CostDAO.instance = value; }
        }

        public List<Cost> GetCostList()
        {
            List<Cost> cost_list = DataProvider<Cost>.Instance.GetListItem("Cost");
            return cost_list;
        }

        public void AddCost(Cost cost)
        {
            DataProvider<Cost>.Instance.ExcuteQuery(String.Format("insert into dbo.Cost(Cost_ID, Cost_Name, Cost_Value, Cost_Type, Cost_Date) values ('{0}', N'{1}', {2}, {3}, '{4}')", cost.Cost_ID, cost.Cost_Name, cost.Cost_Value, cost.Cost_Type, cost.Cost_Date));

        }
        public void EditCost(Cost cost)
        {

        }
        public void DeleteCost(string id)
        {
            DataProvider<Cost>.Instance.DeleteItem("Cost_ID", id, "Cost");
        }
        public void UpdateBatchtoCost(string id)
        {
            Batch batch = DataProvider<Batch>.Instance.GetItem("Batch_ID", id, "Batch");
            List<Cost> cost_list = DataProvider<Cost>.Instance.GetListItem("Cost");
            int max = 0;
            string Max;
            foreach (var item in cost_list)
            {
                if (max < Int32.Parse(item.Cost_ID))
                {
                    max = Int32.Parse(item.Cost_ID);

                }
            }
            max = max + 1;
            Max = max.ToString();
            string name = "Nhập lô hàng số: " + batch.Batch_ID;
            string query = String.Format("insert into dbo.Cost(Cost_ID, Cost_Name, Cost_Value, Cost_Type, Cost_Date) values ('{0}', N'{1}', {2}, {3}, '{4}')", Max, name, batch.Batch_TotalValue, 1 , batch.Batch_BuyDate);
            DataProvider<Cost>.Instance.ExcuteQuery(query);
        }
        public void DeleteBatchCost(string name)
        {
            string query = String.Format("delete from dbo.Cost where Cost_Name = N'{0}'", name);
            DataProvider<Cost>.Instance.ExcuteQuery(query);
        }
        public int TotalValue()
        {
            List<Cost> cost_list = DataProvider<Cost>.Instance.GetListItem("Cost");
            int sum = 0;
            foreach (Cost cost in cost_list)
            {

                sum += cost.Cost_Value;

            }
            return sum;
        }
    }
}
