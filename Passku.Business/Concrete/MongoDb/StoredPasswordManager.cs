using MongoDB.Bson;
using Passku.Business.Abstract.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;
using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Concrete.MongoDb
{
    public class StoredPasswordManager : IStoredPasswordService
    {

        StoredPasswordRepository _storedPasswordRepository;

        public StoredPasswordManager(StoredPasswordRepository storedPasswordRepository)
        {
            _storedPasswordRepository = storedPasswordRepository;
        }



        public List<StoredPassword> GetAll()
        {
            return _storedPasswordRepository.GetAll();
        }

        public List<StoredPassword> GetByUserId(string userId)
        {
            var user = new ObjectId(userId);
            return _storedPasswordRepository.GetAll().FindAll(x => x.UserId == user);
        }

        public StoredPassword GetById(string id)
        {
            return _storedPasswordRepository.GetById(id);
        }

        public void Add(StoredPassword model)
        {
            _storedPasswordRepository.AddModel(model);
        }

        public void Update(string id, StoredPassword model)
        {
            _storedPasswordRepository.UpdateModel(id, model);
        }

        public void Delete(string id)
        {
            _storedPasswordRepository.DeleteModel(id);
        }

    }
}
