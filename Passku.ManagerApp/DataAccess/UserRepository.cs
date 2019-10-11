using Passku.ManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.DataAccess
{
    public class UserRepository : MyDb<User>
    {

        public UserRepository(string colName) : base(colName)
        {

        }

    }
}
