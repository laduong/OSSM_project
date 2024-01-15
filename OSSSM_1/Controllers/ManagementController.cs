using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using OSSSM_1.Models;
using OSSSM_1.DAO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace OSSSM_1.Controllers
{
    public class ManagementController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Shared/ManagementHome.cshtml");
        }
        // Quản lý sản phẩm

        // Hiển thị 
        public IActionResult Product()
        {
            // Khởi tạo
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            // Update số hàng tồn
            ProductDAO.Instance.UpdateProductQuanity();
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Name" : sortOrder; ;
            searchField = searchField == null ? "Product_Name" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Product> productList = new ItemDisplay<Product>();
            productList.SortOrder = sortOrder;
            productList.CurrentSearchField = searchField;
            productList.CurrentSearchString = searchString;
            productList.CurrentPage = currentPage;


            List<Product> product;
            product = DataProvider<Product>.Instance.GetListItem("Product");

            product = Function.Instance.searchItems(product, productList);
            product = Function.Instance.sortItems(product, productList.SortOrder);

            productList.Paging(product, 10);

            if (productList.PageCount > 0)
            {
                if (productList.CurrentPage > productList.PageCount) productList.CurrentPage = productList.PageCount;
                if (productList.CurrentPage < 1) productList.CurrentPage = 1;
                if (productList.CurrentPage != productList.PageCount)
                    try
                    {
                        productList.Items = productList.Items.GetRange((productList.CurrentPage - 1) * productList.PageSize, productList.PageSize);
                    }
                    catch { }

                else
                    productList.Items = productList.Items.GetRange((productList.CurrentPage - 1) * productList.PageSize, productList.Items.Count % productList.PageSize == 0 ? productList.PageSize : productList.Items.Count % productList.PageSize);
            }
            
            return View("~/Views/Shared/Product.cshtml", productList);
        }
        [HttpPost]
        public IActionResult Product(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            return RedirectToAction("Product", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }

        // Thêm 

        public IActionResult AddProduct()
        {
            var category = DataProvider<Category>.Instance.GetListItem("Category");   
            return View("~/Views/Shared/AddProduct.cshtml" , category);
        }

        [HttpPost]
        public IActionResult AddProduct(string id, string name, int cost, int price, string image, string text, int quanity, string category)
        {
            var product = new Product(id, name, cost, price, "defaul.png" , text, quanity, category);
            

            ProductDAO.Instance.AddProduct(product);

            return RedirectToAction("Product");
        }
        // Xóa sản phẩm

        public IActionResult DeleteProduct()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string product_id_delete = urlQuery["product_id"];

            ProductDAO.Instance.DeleteProduct(product_id_delete);

            return RedirectToAction("Product");
        }
        // Hiển thị nội dung chi tiết sản phẩm
        public IActionResult ProductDetail()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string ID = urlQuery["product_id"];
            Product product;
            
            product = DataProvider<Product>.Instance.GetItem("Product_ID",ID,"Product");
            return View("~/Views/Shared/ProductDetail.cshtml", product);
        }
        // Sửa thông tín sản phẩm
        [HttpPost]
        public IActionResult EditProduct( string name, int cost, int price, string image, string text, int quanity, string category)
        {
            var urlQuery = Request.HttpContext.Request.Query;
            String CurrentID = urlQuery["ID"];
            String Image= urlQuery["image"];

            var product = new Product(CurrentID, name, cost, price, Image, text, quanity, category); 
         
            ProductDAO.Instance.EditProduct(product);

            return RedirectToAction("Product");
        }
        [HttpPost]
        public virtual IActionResult UploadImg(string var, string id, IFormFile file, [FromServices] IWebHostEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}/img/product/{file.FileName}";
            // Dẩy file vào thư mục
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            TempData["img"] = file.FileName; // Lưu tên vào TempData => Lưu vào Excel
            if (var == "edit")
                return RedirectToAction("ProductDetail", new { image = file.FileName,ID = id});
            else
            {
                return RedirectToAction("AddProduct", new { image = file.FileName });
            }
        }
        // Thông tin lô hàng
        public IActionResult Batch()
        {
            // Khởi tạo
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "ID" : sortOrder; ;
            searchField = searchField == null ? "Batch_ID" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Batch> batchList = new ItemDisplay<Batch>();
            batchList.SortOrder = sortOrder;
            batchList.CurrentSearchField = searchField;
            batchList.CurrentSearchString = searchString;
            batchList.CurrentPage = currentPage;


            List<Batch> batch;
            BatchDAO.Instance.UpdateTotalValue();
            batch = DataProvider<Batch>.Instance.GetListItem("Batch");
            
            batch = Function.Instance.searchItems(batch, batchList);
            batch = Function.Instance.sortItems(batch, batchList.SortOrder);

            batchList.Paging(batch, 10);

            if (batchList.PageCount > 0)
            {
                if (batchList.CurrentPage > batchList.PageCount) batchList.CurrentPage = batchList.PageCount;
                if (batchList.CurrentPage < 1) batchList.CurrentPage = 1;
                if (batchList.CurrentPage != batchList.PageCount)
                    try
                    {
                        batchList.Items = batchList.Items.GetRange((batchList.CurrentPage - 1) * batchList.PageSize, batchList.PageSize);
                    }
                    catch { }

                else
                    batchList.Items = batchList.Items.GetRange((batchList.CurrentPage - 1) * batchList.PageSize, batchList.Items.Count % batchList.PageSize == 0 ? batchList.PageSize : batchList.Items.Count % batchList.PageSize);
            }
            BatchDAO.Instance.UpdateTotalValue();

            return View("~/Views/Shared/Batch.cshtml", batchList);
        }
        [HttpPost]
        public IActionResult Batch(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            
            return RedirectToAction("Batch", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }
        // Nhập lô hàng mới
        public IActionResult AddBatch()
        {
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Product_Name" : sortOrder; ;
            searchField = searchField == null ? "Product_Name" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Product> productList = new ItemDisplay<Product>();
            productList.SortOrder = sortOrder;
            productList.CurrentSearchField = searchField;
            productList.CurrentSearchString = searchString;
            productList.CurrentPage = currentPage;


            List<Product> product;
            product = DataProvider<Product>.Instance.GetListItem("Product");

            product = Function.Instance.searchItems(product, productList);
            product = Function.Instance.sortItems(product, productList.SortOrder);

            productList.Paging(product, 10);

            if (productList.PageCount > 0)
            {
                if (productList.CurrentPage > productList.PageCount) productList.CurrentPage = productList.PageCount;
                if (productList.CurrentPage < 1) productList.CurrentPage = 1;
                if (productList.CurrentPage != productList.PageCount)
                    try
                    {
                        productList.Items = productList.Items.GetRange((productList.CurrentPage - 1) * productList.PageSize, productList.PageSize);
                    }
                    catch { }

                else
                    productList.Items = productList.Items.GetRange((productList.CurrentPage - 1) * productList.PageSize, productList.Items.Count % productList.PageSize == 0 ? productList.PageSize : productList.Items.Count % productList.PageSize);
            }
            return View("~/Views/Shared/AddBatch.cshtml", productList);

        }
        // Nhâp hàng
        [HttpPost]
        public IActionResult AddBatch( string isAdd,string name, string buytime, string SendVar, String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            if (isAdd == "y")
            {
                DateTime buyTime = new DateTime();
                buyTime = DateTime.Parse(buytime);
                
                

                int i = 0;
                string ID = BatchDAO.Instance.getMaxID();
                Batch batch = new Batch(ID, name,buyTime, 0);
                BatchDAO.Instance.AddBatch(batch);
                // SendVar: 1.15:1-2.30:1-3.20:0-.....
                
                foreach (string item in SendVar.Split("-"))
                {
                    
                    if (item.Split(":").Last() == "1")
                    {
                        int quanity = Convert.ToInt32(item.Split(":").First().Split(".").Last());
                        i++;
                        Product product = ProductDAO.Instance.GetProductModelbyId(item.Split(".").First());

                        BatchDAO.Instance.InsertToBatch(product, ID, quanity);
                    }   
                }
                BatchDAO.Instance.UpdateTotalValue();
                CostDAO.Instance.UpdateBatchtoCost(batch.Batch_ID);
                return RedirectToAction("Batch");
            }
            return RedirectToAction("AddBatch", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });

        }

        // Xóa lô hàng
        public IActionResult DeleteBatch()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string batch_id_delete = urlQuery["batch_id"];
            // Xóa các phần tử trong BatchDetail
            DataProvider<BatchDetail>.Instance.DeleteItem("FK_Batch_ID", batch_id_delete, "BatchDetail");
            // Xóa Batch
            DataProvider<Batch>.Instance.DeleteItem("Batch_ID", batch_id_delete, "Batch");
            // Xóa chi phí nhập
            string name = "Nhập lô hàng số: " + batch_id_delete;
            CostDAO.Instance.DeleteBatchCost(name);

            return RedirectToAction("Batch");
        }

        // Thông tin chi tiết lô hàng
        public IActionResult BatchDetail()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string batch_id = urlQuery["batch_id"];
            // Lây danh sách các sản phẩm trong lô hàng
            List<BatchDetail> batchDetails = DataProvider<BatchDetail>.Instance.GetListItem("FK_Batch_ID", batch_id, "BatchDetail");
            List < Items > items_list = new List<Items>();
            Batch batch = DataProvider<Batch>.Instance.GetItem("Batch_ID", batch_id, "Batch");
            // Thêm danh sách sản phẩm và số lượng vào ItemDetail
            foreach(var item in batchDetails)
            {
                Product product = DataProvider<Product>.Instance.GetItem("Product_ID", item.FK_Product_ID, "Product");
                int number = item.BatchDetail_Quanity;
                Items items = new Items(product, number);
                items_list.Add(items);
            }
            
            ItemDetail itemDetail = new ItemDetail(items_list, batch.Batch_ID, batch.Batch_BuyDate, batch.Batch_Name);
            return View("~/Views/Shared/BatchDetail.cshtml",itemDetail);
        }

        public IActionResult DeleteItemFromBatch()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string batch_id = urlQuery["batch_id"];
            string product_id = urlQuery["product_id"];

            BatchDAO.Instance.DeleteItemFromBatch(product_id, batch_id);

            return RedirectToAction("Batch");
        }

        public IActionResult Cost()
        {
            // Khởi tạo
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "ID" : sortOrder; ;
            searchField = searchField == null ? "Cost_ID" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Cost> costList = new ItemDisplay<Cost>();
            costList.SortOrder = sortOrder;
            costList.CurrentSearchField = searchField;
            costList.CurrentSearchString = searchString;
            costList.CurrentPage = currentPage;


            List<Cost> cost;
            cost = DataProvider<Cost>.Instance.GetListItem("Cost");

            cost = Function.Instance.searchItems(cost, costList);
            cost = Function.Instance.sortItems(cost, costList.SortOrder);

            costList.Paging(cost, 10);

            if (costList.PageCount > 0)
            {
                if (costList.CurrentPage > costList.PageCount) costList.CurrentPage = costList.PageCount;
                if (costList.CurrentPage < 1) costList.CurrentPage = 1;
                if (costList.CurrentPage != costList.PageCount)
                    try
                    {
                        costList.Items = costList.Items.GetRange((costList.CurrentPage - 1) * costList.PageSize, costList.PageSize);
                    }
                    catch { }

                else
                    costList.Items = costList.Items.GetRange((costList.CurrentPage - 1) * costList.PageSize, costList.Items.Count % costList.PageSize == 0 ? costList.PageSize : costList.Items.Count % costList.PageSize);
            }

            return View("~/Views/Shared/Cost.cshtml", costList);
        }
        [HttpPost]
        public IActionResult Cost(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {

            return RedirectToAction("Cost", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }

        public IActionResult AddCost()
        {
            var category = DataProvider<Category>.Instance.GetListItem("Category");
            return View("~/Views/Shared/AddCost.cshtml", category);
        }

        [HttpPost]
        public IActionResult AddCost(string id, string name, int value, int type, DateTime? date)
        {
            date = DateTime.Now;
            var cost = new Cost(id, name, value, type, date);
            CostDAO.Instance.AddCost(cost);

            return RedirectToAction("Cost");
        }
        // Xóa sản phẩm

        public IActionResult DeleteCost()
        {
            var urlQuery = HttpContext.Request.Query;
            string cost_id_delete = urlQuery["cost_id"];
            Cost cost = DataProvider<Cost>.Instance.GetItem("Cost_ID", cost_id_delete, "Cost");
            string id;
            if(cost.Cost_Name.Contains("Nhập lô hàng số: "))
            {
                id = cost.Cost_Name.Split(":").Last().Split(" ").Last();
                DataProvider<BatchDetail>.Instance.DeleteItem("FK_Batch_ID", id, "BatchDetail");
                // Xóa Batch
                DataProvider<Batch>.Instance.DeleteItem("Batch_ID", id, "Batch");
            }
            // Xóa các phần tử trong BatchDetail
            
            CostDAO.Instance.DeleteCost(cost_id_delete);

            return RedirectToAction("Cost");
        }
        // Hiển thị nội dung chi tiết sản phẩm
        public IActionResult CostDetail()
        {
            var urlQuery = HttpContext.Request.Query;
            string ID = urlQuery["cost_id"];
            Cost cost;

            cost = DataProvider<Cost>.Instance.GetItem("Cost_ID", ID, "Cost");
            return View("~/Views/Shared/CostDetail.cshtml", cost);
        }
        [HttpPost]
        public IActionResult EditCost()
        {
            var urlQuery = HttpContext.Request.Query;
            string ID = urlQuery["cost_id"];
            Cost cost;

            cost = DataProvider<Cost>.Instance.GetItem("Cost_ID", ID, "Cost");
            return View("~/Views/Shared/CostDetail.cshtml", cost);
        }
        public IActionResult Bill()
        {
            // Khởi tạo
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Bill_ID" : sortOrder; ;
            searchField = searchField == null ? "Bill_ID" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Bill> billList = new ItemDisplay<Bill>();
            billList.SortOrder = sortOrder;
            billList.CurrentSearchField = searchField;
            billList.CurrentSearchString = searchString;
            billList.CurrentPage = currentPage;


            List<Bill> bill;
            BillDAO.Instance.UpdateTotalValue();
            bill = DataProvider<Bill>.Instance.GetListItem("Bill");

            bill = Function.Instance.searchItems(bill, billList);
            bill = Function.Instance.sortItems(bill, billList.SortOrder);

            billList.Paging(bill, 10);

            if (billList.PageCount > 0)
            {
                if (billList.CurrentPage > billList.PageCount) billList.CurrentPage = billList.PageCount;
                if (billList.CurrentPage < 1) billList.CurrentPage = 1;
                if (billList.CurrentPage != billList.PageCount)
                    try
                    {
                        billList.Items = billList.Items.GetRange((billList.CurrentPage - 1) * billList.PageSize, billList.PageSize);
                    }
                    catch { }

                else
                    billList.Items = billList.Items.GetRange((billList.CurrentPage - 1) * billList.PageSize, billList.Items.Count % billList.PageSize == 0 ? billList.PageSize : billList.Items.Count % billList.PageSize);
            }
         

            return View("~/Views/Shared/Bill.cshtml", billList);
        }
        [HttpPost]
        public IActionResult Bill(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {

            return RedirectToAction("Bill", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }
        // Nhập lô hàng mới
        public IActionResult AddBill()
        {
            String field;
            String sortOrder;
            String searchField;
            String searchString;
            String page;

            /// Lấy query, không có => đặt mặc định
            var urlQuery = Request.HttpContext.Request.Query; // Url: .../Member?Sort={sortOrder}&searchField={searchField}...
            field = urlQuery["field"];
            sortOrder = urlQuery["sort"];
            searchField = urlQuery["searchField"];
            searchString = urlQuery["SearchString"];
            page = urlQuery["page"];
            field = field == null ? "All" : field;

            sortOrder = sortOrder == null ? "Product_Name" : sortOrder; ;
            searchField = searchField == null ? "Product_Name" : searchField;
            searchString = searchString == null ? "" : searchString;
            page = page == null ? "1" : page;
            int currentPage = Convert.ToInt32(page);

            ItemDisplay<Product> productList = new ItemDisplay<Product>();
            productList.SortOrder = sortOrder;
            productList.CurrentSearchField = searchField;
            productList.CurrentSearchString = searchString;
            productList.CurrentPage = currentPage;


            List<Product> product;
            product = DataProvider<Product>.Instance.GetListItem("Product");

            product = Function.Instance.searchItems(product, productList);
            product = Function.Instance.sortItems(product, productList.SortOrder);

            productList.Paging(product, 10);

            if (productList.PageCount > 0)
            {
                if (productList.CurrentPage > productList.PageCount) productList.CurrentPage = productList.PageCount;
                if (productList.CurrentPage < 1) productList.CurrentPage = 1;
                if (productList.CurrentPage != productList.PageCount)
                    try
                    {
                        productList.Items = productList.Items.GetRange((productList.CurrentPage - 1) * productList.PageSize, productList.PageSize);
                    }
                    catch { }

                else
                    productList.Items = productList.Items.GetRange((productList.CurrentPage - 1) * productList.PageSize, productList.Items.Count % productList.PageSize == 0 ? productList.PageSize : productList.Items.Count % productList.PageSize);
            }
            return View("~/Views/Shared/AddBill.cshtml", productList);

        }
        // Nhâp hàng
        [HttpPost]
        public IActionResult AddBill(string isAdd,string buytime, string address, string name, string SendVar, String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            if (isAdd == "y")
            {
                DateTime buyTime = new DateTime();
                buyTime = DateTime.Parse(buytime);


                int i = 0;
                string ID = BillDAO.Instance.getMaxID();
                Bill bill = new Bill(ID, name, address,buyTime, 0);
                BillDAO.Instance.AddBill(bill);
                // SendVar: 1.15:1-2.30:1-3.20:0-.....

                foreach (string item in SendVar.Split("-"))
                {

                    if (item.Split(":").Last() == "1")
                    {
                        int quanity = Convert.ToInt32(item.Split(":").First().Split(".").Last());
                        i++;
                        Product product = ProductDAO.Instance.GetProductModelbyId(item.Split(".").First());
                        int product_quanity = product.Product_Quanity;
                        if (product_quanity > quanity)
                        {
                            BillDAO.Instance.InsertToBill(product, ID, quanity);
                        }
                        else
                        {
                            BillDAO.Instance.InsertToBill(product, ID, product_quanity);
                        }
                        

                    }
                }
                BillDAO.Instance.UpdateTotalValue();
                return RedirectToAction("Bill");
            }
            return RedirectToAction("AddBill", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });

        }

        // Xóa lô hàng
        public IActionResult DeleteBill()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string bill_id_delete = urlQuery["bill_id"];
            // Xóa các phần tử trong BillDetail
            DataProvider<BillDetail>.Instance.DeleteItem("FK_Bill_ID", bill_id_delete, "BillDetail");
            // Xóa Bill
            DataProvider<Bill>.Instance.DeleteItem("Bill_ID", bill_id_delete, "Bill");

            return RedirectToAction("Bill");
        }

        // Thông tin chi tiết lô hàng
        public IActionResult BillDetail()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string bill_id = urlQuery["bill_id"];
            // Lây danh sách các sản phẩm trong lô hàng
            List<BillDetail> billDetails = DataProvider<BillDetail>.Instance.GetListItem("FK_Bill_ID", bill_id, "BillDetail");
            List<Items> items_list = new List<Items>();
            Bill bill = DataProvider<Bill>.Instance.GetItem("Bill_ID", bill_id, "Bill");
            // Thêm danh sách sản phẩm và số lượng vào ItemDetail
            foreach (var item in billDetails)
            {
                Product product = DataProvider<Product>.Instance.GetItem("Product_ID", item.FK_Product_ID, "Product");
                int number = item.BillDetail_Quanity;
                Items items = new Items(product, number);
                items_list.Add(items);
            }

            ItemDetail itemDetail = new ItemDetail(items_list, bill.Bill_ID, bill.Bill_SellDate, bill.Bill_Name, bill.Bill_Address);
            return View("~/Views/Shared/BillDetail.cshtml", itemDetail);
        }

        public IActionResult DeleteItemFromBill()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string bill_id = urlQuery["bill_id"];
            string product_id = urlQuery["product_id"];

            BillDAO.Instance.DeleteItemFromBill(product_id, bill_id);

            return RedirectToAction("Bill");
        }
        public IActionResult Dashboard()
        {
            List < Bill > bill_list = DataProvider<Bill>.Instance.GetListItem("Bill");
            int number_bill = bill_list.Count();
            int total_cost = CostDAO.Instance.TotalValue();
            int total_renvenue = BillDAO.Instance.TotalValue();
            int total_profit = total_renvenue - total_cost;
            Dashboard dashboard = new Dashboard(total_profit, total_cost, total_renvenue, number_bill);
            DateTime end_date = DateTime.Now;
            DateTime start_date = end_date.AddDays(-30);
            List<int> data = BillDAO.Instance.getTotalValueFromDate(start_date, end_date);
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i <= 30; i++)
            {
                dates.Add(start_date.AddDays(i));
            }

            ViewBag.Dates = string.Join(",", dates.Select(date => "'" + date.ToString("dd-MM-yyyy") + "'"));
            ViewBag.GrowChart = string.Join(",", data);
            return View("~/Views/Shared/Dashboard.cshtml", dashboard);
        }
    }
}
