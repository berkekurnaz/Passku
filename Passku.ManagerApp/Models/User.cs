using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.Models
{
    public class User : BaseModel
    {

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("NameSurname")]
        public string NameSurname { get; set; }

        [BsonElement("MailAdress")]
        public string MailAdress { get; set; }

        [BsonElement("CreatedDate")]
        public string CreatedDate { get; set; }

    }
}
