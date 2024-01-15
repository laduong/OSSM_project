using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using OSSSM_1.Models;

namespace OSSSM_1.DAO
{
    public class BatchDAO
    {
        private static BatchDAO instance;
        public static BatchDAO Instance
        {
            get { if (instance == null) instance = new BatchDAO(); return BatchDAO.instance; }
            private set { BatchDAO.instance = value; }
        }

        private BatchDAO() { }
        // Lấy thông tin chi tiết lô hàng
        public List<BatchDetail> GetBatchDetail(string batch_id)
        {
            List<BatchDetail> batchDetails = new List<BatchDetail>();
            DataTable data = DataProvider<BatchDetail>.Instance.ExcuteQuery(String.Format("select * from dbo.BatchDetail where FK_Batch_ID = '{0}'", batch_id));
            foreach(DataRow row in data.Rows)
            {
                BatchDetail detail = new BatchDetail(row);
                batchDetails.Add(detail);
                

            }
            return batchDetails;
        }
        // Lưu tổng giá trị lô hàng vào bảng
        public void UpdateTotalValue()
        {
            List<Batch> batch_list = DataProvider<Batch>.Instance.GetListItem("Batch");
            foreach(Batch batch in batch_list)
            {
                List<BatchDetail> batchDetails = GetBatchDetail(batch.Batch_ID);

                int totalValue = 0;
                foreach (BatchDetail item in batchDetails)
                {
                    Product product = DataProvider<Product>.Instance.GetItem("Product_ID", item.FK_Product_ID, "Product");
                    totalValue += product.Product_Cost * item.BatchDetail_Quanity;
                }
                DataProvider<Batch>.Instance.ExcuteQuery(String.Format("update dbo.Batch set Batch_TotalValue = {0} where Batch_ID = '{1}'", totalValue, batch.Batch_ID));
            }
           
        }
        public void AddBatch(Batch batch)
        {
            string buydate = batch.Batch_BuyDate.ToString();

            string query = String.Format("insert into dbo.batch(Batch_ID, Batch_Name, Batch_BuyDate, Batch_TotalValue) values ('{0}', N'{1}','{2}',{3})", batch.Batch_ID, batch.Batch_Name, batch.Batch_BuyDate, batch.Batch_TotalValue);
            DataProvider<Batch>.Instance.ExcuteQuery(query);
        }
        public void InsertToBatch(Product product, string batch_id, int quanity)
        {
            List<BatchDetail> batchdetail_list = DataProvider<BatchDetail>.Instance.GetListItem("BatchDetail");
            int max = 0;
            string Max;
            foreach(BatchDetail item in batchdetail_list)
            {
                if(max < Int32.Parse(item.id))
                {
                    max = Int32.Parse(item.id);
                    
                }
            }
            max = max + 1;
            Max = max.ToString();
            string query = String.Format("insert into dbo.BatchDetail(Id, FK_Product_ID, FK_Batch_ID, BatchDetail_Quanity) values ('{0}','{1}','{2}', {3})",Max, product.Product_ID, batch_id, quanity);
            DataProvider<BatchDetail>.Instance.ExcuteQuery(query);
        }
        public void DeleteItemFromBatch(string product_id, string batch_id)
        {
            string query = String.Format("delete from dbo.BatchDetail where FK_Product_ID = '{0}' and FK_Batch_ID = '{1}'", product_id, batch_id);
            DataProvider<BatchDetail>.Instance.ExcuteQuery(query);
        }
        public string getMaxID()
        {
            List<BatchDetail> batchdetail_list = DataProvider<BatchDetail>.Instance.GetListItem("BatchDetail");
            int max = 0;
            string Max;
            foreach (BatchDetail item in batchdetail_list)
            {
                if (max < Int32.Parse(item.id))
                {
                    max = Int32.Parse(item.id);

                }
            }
            max = max + 1;
            Max = max.ToString();
            return Max;
        }

    }
}
