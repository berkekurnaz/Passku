using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Abstract.MongoDb
{
    public interface IStoredPasswordService
    {

        List<StoredPassword> GetAll();

        List<StoredPassword> GetByUserId(string userId);

        StoredPassword GetById(string id);

        void Add(StoredPassword model);

        void Update(string id, StoredPassword model);

        void Delete(string id);

        int GetUserPasswordCount(string userId);

        int GetTotalPasswordCount();

    }
}
