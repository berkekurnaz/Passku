using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Models.Concrete
{
    public class StoredPassword : MongoBaseModel
    {

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("CreatedDate")]
        public string CreatedDate { get; set; }

        [BsonElement("UserId")]
        public ObjectId UserId { get; set; }

    }
}
