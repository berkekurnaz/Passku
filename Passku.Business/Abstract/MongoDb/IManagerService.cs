using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Abstract.MongoDb
{
    public interface IManagerService
    {

        List<Manager> GetAll();

        Manager GetById(string id);

        void Add(Manager model);

        void Update(string id, Manager model);

        void Delete(string id);

        Manager CheckByApikey(string apikey);

        Manager Login(Manager model);

    }
}
