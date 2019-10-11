using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Abstract.MongoDb
{
    public interface IAnnouncementService
    {

        List<Announcement> GetAll();

        Announcement GetById(string id);

        void Add(Announcement model);

        void Update(string id, Announcement model);

        void Delete(string id);

        int GetAnnouncementCount();

    }
}
