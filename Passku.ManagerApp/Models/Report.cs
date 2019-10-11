using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Passku.ManagerApp.Models
{
    public class Report : BaseModel
    {

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        [BsonElement("Date")]
        public string Date { get; set; }

        [BsonElement("UserId")]
        public ObjectId UserId { get; set; }
    }
}
