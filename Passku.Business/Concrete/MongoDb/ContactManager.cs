using Passku.Business.Abstract.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;
using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Concrete.MongoDb
{
    public class ContactManager : IContactService
    {

        private ContactRepository _contactRepository;

        public ContactManager(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }



        public List<Contact> GetAll()
        {
            return _contactRepository.GetAll();
        }

        public Contact GetById(string id)
        {
            return _contactRepository.GetById(id);
        }

        public void Add(Contact model)
        {
            _contactRepository.AddModel(model);
        }

        public void Update(string id, Contact model)
        {
            _contactRepository.UpdateModel(id, model);
        }

        public void Delete(string id)
        {
            _contactRepository.DeleteModel(id);
        }

    }
}
