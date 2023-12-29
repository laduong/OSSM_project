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

        public List<Product> GetProductList(string unit, string var = "")
        {
            List<Product> items = DataProvider<Product>.Instance.GetListItem("Unit", unit);
            return items;
        }

        public Product GetProductModelbyId(string ID)
        {
            Product item = DataProvider<Product>.Instance.GetItem("ID", ID);
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
    }
}

