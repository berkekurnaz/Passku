using Passku.Business.Abstract.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;
using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Concrete.MongoDb
{
    public class AnnouncementManager : IAnnouncementService
    {

        AnnouncementRepository _announcementRepository;

        public AnnouncementManager(AnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }



        public List<Announcement> GetAll()
        {
            return _announcementRepository.GetAll();
        }

        public Announcement GetById(string id)
        {
            return _announcementRepository.GetById(id);
        }

        public void Add(Announcement model)
        {
            _announcementRepository.AddModel(model);
        }

        public void Update(string id, Announcement model)
        {
            _announcementRepository.UpdateModel(id, model);
        }

        public void Delete(string id)
        {
            _announcementRepository.DeleteModel(id);
        }

        public int GetAnnouncementCount()
        {
            return _announcementRepository.GetAll().Count;
        }

    }
}
