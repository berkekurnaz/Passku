using Passku.ManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.DataAccess
{
    public class ContactRepository : MyDb<Contact>
    {

        public ContactRepository(string colName) : base(colName)
        {

        }

    }
}
