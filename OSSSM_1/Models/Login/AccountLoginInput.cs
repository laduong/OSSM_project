using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models.Login
{
    // Lưu thông tin người dùng nhập vào khi đăng nhập
    public class AccountLoginInput
    {
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}
