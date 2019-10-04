using Passku.Business.Abstract.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;
using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Concrete.MongoDb
{
    public class UserManager : IUserService
    {

        private UserRepository _userRepository;

        public UserManager(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(string id)
        {
            return _userRepository.GetById(id);
        }

        public void Add(User model)
        {
            _userRepository.AddModel(model);
        }

        public void Update(string id, User model)
        {
            _userRepository.UpdateModel(id, model);
        }

        public void Delete(string id)
        {
            _userRepository.DeleteModel(id);
        }

        public User Login(User model)
        {
            var result = new User();
            result = _userRepository.GetAll().Find(x => x.Username == model.Username && x.Password == model.Password);
            return result;
        }

    }
}
