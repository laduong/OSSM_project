using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OSSSM_1.Models.Login
{
    // Lưu thông tin đăng nhập vào Session
    [Serializable]
    public class UserLogin
    {
        public string UserName { set; get; }
    }
}
