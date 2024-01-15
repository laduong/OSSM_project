using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;
using OSSSM_1.Models;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Globalization;

namespace OSSSM_1.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        private ProductDAO() { }

        
        
        public List<Product> GetProductList()
        {
            List<Product> items = DataProvider<Product>.Instance.GetListItem();
            return items;
        }

        public Product GetProductModelbyId(string ID)
        {
            Product item = DataProvider<Product>.Instance.GetItem("Product_ID", ID);
            return item;
        }

        public void EditProduct(Product product)
        {
            DataTable data = DataProvider<Product>.Instance.LoadData();
            DataRow newProduct = data.Select("ID=" + product.Product_ID).FirstOrDefault();

            if (newProduct != null)
            {
                var allAttr = typeof(Product).GetProperties(); // Lấy danh sách attributes của class Product
                foreach (var attr in allAttr)
                    newProduct[attr.Name] = attr.GetValue(product);
            }

            DataProvider<Product>.Instance.UpdateData(data);

        }

        public void AddProduct(Product product) // Thêm mới quy trình vào sheetName
        {
            DataTable data = DataProvider<Product>.Instance.LoadData();
            DataRow newProduct = data.NewRow();

            var allAttr = typeof(Product).GetProperties(); // Lấy danh sách attributes của class Product

            foreach (var attr in allAttr)
                newProduct[attr.Name] = attr.GetValue(product);


            data.Rows.Add(newProduct);

            DataProvider<Product>.Instance.UpdateData(data);
        }

        public void DeleteProduct(String ID)
        {
            DataProvider<Product>.Instance.DeleteItem("Product_ID", ID);
        }
        public void UpdateProductQuanity()
        {
            List<Product> products = DataProvider<Product>.Instance.GetListItem("Product");
            foreach(Product item in products)
            {
                int sum_import = 0;
                int sum_export = 0;
                List<BatchDetail> batches = DataProvider<BatchDetail>.Instance.GetListItem("FK_Product_ID", item.Product_ID, "BatchDetail");
                foreach(BatchDetail batch in batches)
                {
                    sum_import += batch.BatchDetail_Quanity;
                }
                List<BillDetail> bills  = DataProvider<BillDetail>.Instance.GetListItem("FK_Product_ID", item.Product_ID, "BillDetail");
                foreach (BillDetail bill in bills)
                {
                    sum_export += bill.BillDetail_Quanity;
                }
                int sum = sum_import - sum_export > 0 ? sum_import - sum_export : 0;
                DataProvider<Product>.Instance.ExcuteQuery(String.Format("Update dbo.Product set Product_Quanity = {0} where Product_ID = {1}", sum, item.Product_ID));
                
            }
            
            
        }
    }
}

