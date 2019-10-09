using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Abstract.MongoDb
{
    public interface IContactService
    {

        List<Contact> GetAll();

        Contact GetById(string id);

        void Add(Contact model);

        void Update(string id, Contact model);

        void Delete(string id);

    }
}
