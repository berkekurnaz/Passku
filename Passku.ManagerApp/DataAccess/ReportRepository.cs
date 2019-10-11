using Passku.ManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.DataAccess
{
    public class ReportRepository : MyDb<Report>
    {

        public ReportRepository(string colName) : base(colName)
        {

        }

    }
}
