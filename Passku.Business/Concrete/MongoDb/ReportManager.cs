using Passku.Business.Abstract.MongoDb;
using Passku.DataAccess.Concrete.MongoDb;
using Passku.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passku.Business.Concrete.MongoDb
{
    public class ReportManager : IReportService
    {

        private ReportRepository _reportRepository;

        public ReportManager(ReportRepository reportRepository)
        {
            _reportRepository = reportRepository;
        }



        public List<Report> GetAll()
        {
            return _reportRepository.GetAll();
        }

        public Report GetById(string id)
        {
            return _reportRepository.GetById(id);
        }

        public void Add(Report model)
        {
            _reportRepository.AddModel(model);
        }

        public void Update(string id, Report model)
        {
            _reportRepository.UpdateModel(id, model);
        }

        public void Delete(string id)
        {
            _reportRepository.DeleteModel(id);
        }

    }
}
