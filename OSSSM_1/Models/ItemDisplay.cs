using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models
{
    public class ItemDisplay<T>
    {
        private int pageCount;
        private int pageSize;
        private int currentPage;
        private List<T> items;
        private int itemCount;

        private String field;
        private String sortOrder;
        private String currentSearchString;
        private String currentSearchField;
        private List<String> searchFieldList;

        private string message;
        private bool isMessage;
        private List<String> link;
        private string sessionVar;

          private Dictionary<string, string> nameVar = new Dictionary<string, string>()
          {
              {"Product_ID", "ID" },
              {"Product_Name", "Tên sản phẩm" },
              {"Product_Cost","Giá nhập vào"},
              {"Product_Price","Giá bán ra"},
              {"Product_Image","Ảnh sản phẩm"},
              {"Product_Text","Mô tả sản phẩm"},
              {"Product_Quanity","Số lượng"},
              {"FK_Category_ID","Danh mục"},
              {"Product_Size","Size"},
              {"Batch_TotalValue","Tổng giá trị lô hàng"},
              {"Batch_Name","Tên lô hàng"},
              {"Batch_BuyDate", "Ngày nhập hàng" },
              {"Batch_ID", "Mã đơn hàng" },
              {"Cost_Name", "Tên chi phí" },
              {"Cost_ID", "Mã chi phí" },
              {"Cost_Date", "Ngày chi" },
              {"Cost_Value", "Giá trị chi" },
              {"Cost_Type", "Loại chi phí" },
              {"Bill_Name", "Tên hóa đơn" },
              {"Bill_ID" , "Mã hóa đơn"},
              {"Bill_SellDate", "Ngày bán" },
              {"Bill_TotalValue", "Tổng giá trị đơn" },
              {"Bill_Address", "Địa chỉ giao hàng" },


          };

        


        public int PageCount { get => pageCount; set => pageCount = value; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public List<T> Items { get => items; set => items = value; }
        public int ItemCount { get => itemCount; set => itemCount = value; }

        public String Field { get => field; set => field = value; }
        public String SortOrder { get => sortOrder; set => sortOrder = value; }
        public String CurrentSearchString { get => currentSearchString; set => currentSearchString = value; }
        public String CurrentSearchField { get => currentSearchField; set => currentSearchField = value; }
        public List<String> SearchFieldList { get => searchFieldList; set => searchFieldList = value; }

        public string Message { get => message; set => message = value; }
        public bool IsMessage { get => isMessage; set => isMessage = value; }
        public string SessionVar { get => sessionVar; set => sessionVar = value; }
        public List<String> Link { get => link; set => link = value; } // Biểu mẫu/Lịch làm việc/Báo lỗi

         public Dictionary<string, string> NameVar { get => nameVar; set => nameVar = value; } 
         /*public Dictionary<string, string> UnitVar { get => unitVar; set => unitVar = value; }
         public Dictionary<string, string> ProcedureVar { get => procedureVar; set => procedureVar = value; }
         public Dictionary<string, string> ColorVar { get => procedureColorVar; set => procedureColorVar = value; }
        */
        public static Boolean IsAddMember = false;

        public ItemDisplay()
        {
            this.pageSize = 10;
            this.currentPage = 1;
            this.searchFieldList = new List<String>();
            foreach (var attr in typeof(T).GetProperties().ToList())
            {
                this.searchFieldList.Add(attr.Name.ToString());
            }

            this.isMessage = false;
            this.message = "";
            this.sessionVar = "";
        }

        

        public void Paging(List<T> members, int pageSize)
        {
            this.items = members;
            this.itemCount = members.Count;
            this.pageSize = pageSize;

            if ((double)((decimal)this.items.Count() % Convert.ToDecimal(this.pageSize)) == 0)
            {
                this.pageCount = this.items.Count() / this.pageSize;
            }
            else
            {
                double page_Count = (double)((decimal)this.items.Count() / Convert.ToDecimal(this.pageSize));
                this.pageCount = (int)Math.Ceiling(page_Count);
            }
        }
    }
}
