using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Models.Concrete
{
    public class Contact : MongoBaseModel
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
