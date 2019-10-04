using MongoDB.Bson;
using Passku.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Models.Concrete
{
    public class MongoBaseModel : IEntity
    {
        public ObjectId Id { get; set; }
    }
}
