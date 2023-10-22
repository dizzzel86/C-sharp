using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Manager : Consultant
    {
        public Manager() { }

        


        public  User SetInfo(User user)
        {

            User user1 = new User();
            user1.SetUserInfo(user1);
            

            return user1;
         
        }

    }
}
