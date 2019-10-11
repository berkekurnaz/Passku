using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.Models
{
    public class Contact : BaseModel
    {

        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Subject")]
        public string Subject { get; set; }

        [BsonElement("Message")]
        public string Message { get; set; }

        [BsonElement("Date")]
        public string Date { get; set; }

    }
}
