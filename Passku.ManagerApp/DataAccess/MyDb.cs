using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Passku.ManagerApp.Models;

namespace Passku.ManagerApp.DataAccess
{
    public class MyDb<T> : IMyDb<T> where T : BaseModel
    {
        MongoClient client;
        public IMongoDatabase db;
        string dbName = "DbPasskuApp";
        string collectionName;

        private readonly IMongoCollection<T> mongoCollection;

        public MyDb(string colName)
        {
            client = new MongoClient();
            db = client.GetDatabase(dbName);
            collectionName = colName;
            mongoCollection = db.GetCollection<T>(collectionName);
        }

        public List<T> GetAll()
        {
            return mongoCollection.Find(book => true).ToList();
        }

        public T GetById(string Id)
        {
            var documentId = new ObjectId(Id);
            return mongoCollection.Find(x => x.Id == documentId).FirstOrDefault();
        }

        public void Add(T model)
        {
            mongoCollection.InsertOne(model);
        }

        public void Update(string Id, T model)
        {
            var documentId = new ObjectId(Id);
            mongoCollection.ReplaceOne(x => x.Id == documentId, model);
        }

        public void Delete(string Id)
        {
            var documentId = new ObjectId(Id);
            mongoCollection.DeleteOne(x => x.Id == documentId);
        }

    }
}