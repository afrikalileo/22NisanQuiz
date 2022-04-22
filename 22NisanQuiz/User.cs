using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22NisanQuiz
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }

        public string Email { get; set; }

        public dynamic Addres { get; set; }

        string password = "";
        public string Password
        {
            get
            {
                return password UserPassword.CreateMD5(value); ;
            }
         
        }

    }
}
