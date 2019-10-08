using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Abstract.MongoDb
{
    public interface IReportService
    {

        List<Report> GetAll();

        Report GetById(string id);

        void Add(Report model);

        void Update(string id, Report model);

        void Delete(string id);

    }
}
