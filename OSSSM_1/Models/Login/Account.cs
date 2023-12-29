using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OSSSM_1.Models
{
    // Model chung cho Account
    public class Account
    {
        private string username;
        private string password;

        public string ID { get; set; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; } 

        public Account (string ID, string username, string password)
        {
            this.ID = ID;
            this.Username = username;
            this.Password = password;
        }
        public Account(DataRow row)
        {
            this.Username = (string)row["Account_Username"];
            this.Password = (string)row["Account_PassWord"];
        }
    }
}
