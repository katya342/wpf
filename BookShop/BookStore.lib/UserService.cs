using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.lib
{
    public class UserService
    {
        
        public bool UserCheckin(string username, string password)
        {
            
                EntityModel model1 = new EntityModel();
                var data = model1.Users.Any(w => w.Login == username & w.Password == password);
                return data;
        }
       
    }
}
