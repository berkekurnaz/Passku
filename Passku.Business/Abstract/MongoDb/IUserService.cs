using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Abstract.MongoDb
{
    public interface IUserService
    {

        List<User> GetAll();

        User GetById(string id);

        void Add(User model);

        void Update(string id, User model);

        void Delete(string id);

        User Login(User model);

        User CheckByUsername(User model);

        User CheckByMail(User model);

    }
}
