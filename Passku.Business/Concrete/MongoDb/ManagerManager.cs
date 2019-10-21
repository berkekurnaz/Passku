using Passku.Business.Abstract.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;
using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Concrete.MongoDb
{
    public class ManagerManager : IManagerService
    {

        private ManagerRepository _managerRepository;

        public ManagerManager(ManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }



        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }

        public Manager GetById(string id)
        {
            return _managerRepository.GetById(id);
        }

        public void Add(Manager model)
        {
            _managerRepository.AddModel(model);
        }

        public void Update(string id, Manager model)
        {
            _managerRepository.UpdateModel(id, model);
        }

        public void Delete(string id)
        {
            _managerRepository.DeleteModel(id);
        }

        public Manager CheckByApikey(string apikey)
        {
            var result = new Manager();
            result = _managerRepository.GetAll().Find(x => x.Username == apikey);
            return result;
        }

        public Manager Login(Manager model)
        {
            var result = new Manager();
            result = _managerRepository.GetAll().Find(x => x.Username == model.Username && x.Password == model.Password);
            return result;
        }

    }
}
