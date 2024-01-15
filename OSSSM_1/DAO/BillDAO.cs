using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OSSSM_1.Models;
using System.Data;

namespace OSSSM_1.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        // Lấy thông tin chi tiết đơn hàng
        public List<BillDetail> GetBillDetail(string bill_id)
        {
            List<BillDetail> billDetails = new List<BillDetail>();
            DataTable data = DataProvider<BillDetail>.Instance.ExcuteQuery(String.Format("select * from dbo.BillDetail where FK_Bill_ID = '{0}'", bill_id));
            foreach (DataRow row in data.Rows)
            {
                BillDetail detail = new BillDetail(row);
                billDetails.Add(detail);


            }
            return billDetails;
        }
        // Lưu tổng giá trị hóa đơn
        public void UpdateTotalValue()
        {
            List<Bill> bill_list = DataProvider<Bill>.Instance.GetListItem("Bill");
            foreach (Bill bill in bill_list)
            {
                List<BillDetail> billDetails = GetBillDetail(bill.Bill_ID);

                int totalValue = 0;
                foreach (BillDetail item in billDetails)
                {
                    Product product = DataProvider<Product>.Instance.GetItem("Product_ID", item.FK_Product_ID, "Product");
                    totalValue += product.Product_Price * item.BillDetail_Quanity;
                }
                DataProvider<Bill>.Instance.ExcuteQuery(String.Format("update dbo.Bill set Bill_TotalValue = {0} where Bill_ID = '{1}'", totalValue, bill.Bill_ID));
            }

        }
        public void AddBill(Bill bill)
        {
            string buydate = bill.Bill_SellDate.ToString();

            string query = String.Format("insert into dbo.bill(Bill_ID, Bill_Name, Bill_Address, Bill_SellDate, Bill_TotalValue) values ('{0}', N'{1}',N'{2}','{3}',{4})", bill.Bill_ID, bill.Bill_Name, bill.Bill_Address, bill.Bill_SellDate, bill.Bill_TotalValue);
            DataProvider<Bill>.Instance.ExcuteQuery(query);
        }
        public void InsertToBill(Product product, string bill_id, int quanity)
        {
            List<BillDetail> billdetail_list = DataProvider<BillDetail>.Instance.GetListItem("BillDetail");
            int max = 0;
            string Max;
            foreach (BillDetail item in billdetail_list)
            {
                if (max < Int32.Parse(item.id))
                {
                    max = Int32.Parse(item.id);

                }
            }
            max = max + 1;
            Max = max.ToString();
            string query = String.Format("insert into dbo.BillDetail(id, FK_Product_ID, FK_Bill_ID, BillDetail_Quanity) values ('{0}','{1}','{2}', {3})", Max, product.Product_ID, bill_id, quanity);
            DataProvider<BillDetail>.Instance.ExcuteQuery(query);
        }
        public void DeleteItemFromBill(string product_id, string bill_id)
        {
            string query = String.Format("delete from dbo.BillDetail where FK_Product_ID = '{0}' and FK_Bill_ID = '{1}'", product_id, bill_id);
            DataProvider<BillDetail>.Instance.ExcuteQuery(query);
        }
        public string getMaxID()
        {
            List<Bill> billdetail_list = DataProvider<Bill>.Instance.GetListItem("Bill");
            int max = 0;
            string Max;
            foreach (Bill item in billdetail_list)
            {
                if (max < Int32.Parse(item.Bill_ID))
                {
                    max = Int32.Parse(item.Bill_ID);

                }
            }
            max = max + 1;
            Max = max.ToString();
            return Max;
        }
        public int TotalValue()
        {
            List<Bill> bill_list = DataProvider<Bill>.Instance.GetListItem("Bill");
            int sum = 0;
            foreach (Bill bill in bill_list)
            {
                List<BillDetail> billDetails = GetBillDetail(bill.Bill_ID);

                int totalValue = 0;
                foreach (BillDetail item in billDetails)
                {
                    Product product = DataProvider<Product>.Instance.GetItem("Product_ID", item.FK_Product_ID, "Product");
                    totalValue += product.Product_Price * item.BillDetail_Quanity;
                }
                sum += totalValue;

            }
            return sum;
        }

        public List<int> getTotalValueFromDate(DateTime startdate, DateTime endate)
        {
            List<int> totalvalue_list = new List<int>();

            int sum = 0;
            for (DateTime date = startdate; date <= endate; date = date.AddDays(1))
            {
                List<Bill> bill_list = new List<Bill>();
                DateTime date_day = date.Date;
                string query = String.Format("Select * from dbo.Bill where Bill_SellDate between '{0}' and '{1}'", date_day.ToString("yyyy-MM-dd HH:mm:ss"), date_day.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"));
                DataTable data = DataProvider<Bill>.Instance.ExcuteQuery(query);
                foreach (DataRow dr in data.Rows)
                {
                    Bill item = (Bill)Activator.CreateInstance(typeof(Bill), dr);
                    bill_list.Add(item);
                }


                foreach (Bill bill in bill_list)
                {
                    sum += bill.Bill_TotalValue;

                }
                totalvalue_list.Add(sum);

            }
            return totalvalue_list;

        }
        // Lấy ra tổng số sản phẩm bán được
        public int GetTotalSell(string id)
        {
            List<BillDetail> billDetails = DataProvider<BillDAO>.Instance.ExcuteQuery
        }


    }
}
