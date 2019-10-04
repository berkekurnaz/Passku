using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.DataAccess.Concrete.MongoDb
{
    public class UserRepository : BaseMongoRepository<User>
    {

        public UserRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }

    }
}
