using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Models.Concrete
{
    public class Announcement : MongoBaseModel
    {

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Date")]
        public string Date { get; set; }

    }
}
