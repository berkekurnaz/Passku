using Passku.ManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.DataAccess
{
    public class AnnouncementRepository : MyDb<Announcement>
    {

        public AnnouncementRepository(string colName) : base(colName)
        {

        }

    }
}
