using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySystem.lib
{
    public class UserService
    {

        public bool CheckUser(string log, string pass)
        {
          EntityModel entityModel = new EntityModel();

            return entityModel.User.Any(w => w.Password == pass & w.Login == log);
        }
    }
}
