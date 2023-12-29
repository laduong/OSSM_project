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

            return View("~/Views/Shared/Product.cshtml", productList);
        }
        [HttpPost]
        public IActionResult Product(String sortOrder, String searchString, String searchField, int currentPage = 1)
        {
            return RedirectToAction("Product", new { sort = sortOrder, searchField = searchField, searchString = searchString, page = currentPage });
        }


        public IActionResult AddProduct()
        {
            return View("~/Views/Shared/AddProduct.cshtml");
        }

        [HttpPost]
        public IActionResult AddProduct(string id, string name, string cost, string price, string image, string text, string quanity, string size, string category)
        {
            var product = new Product(id, name, cost, price, image, text, quanity, size, category);

            ProductDAO.Instance.AddProduct(product);

            return RedirectToAction("Product");
        }

        public IActionResult DeleteProduct()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string product_id_delete = urlQuery["product_id"];

            ProductDAO.Instance.DeleteProduct(product_id_delete);

            return RedirectToAction("Product");
        }

        public IActionResult ProductDetail()
        {
            var urlQuery = Request.HttpContext.Request.Query;
            string ID = urlQuery["product_id"];
            Product product;
            
            product = DataProvider<Product>.Instance.GetItem("Product_ID",ID,"Product");
            return View("~/Views/Shared/ProductDetail.cshtml", product);
        }
        [HttpPost]
        public IActionResult EditProduct( string name, string cost, string price, string image, string text, string quanity, string size, string category)
        {
            var urlQuery = Request.HttpContext.Request.Query;
            String CurrentID = urlQuery["ID"];
            String Image= urlQuery["image"];

            var product = new Product(CurrentID, name, cost, price, Image, text, quanity, size, category); 
         
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


    }
}
