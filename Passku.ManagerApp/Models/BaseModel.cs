using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.Models
{
    public class BaseModel
    {
        public ObjectId Id { get; set; }
    }
}
