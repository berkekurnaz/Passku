using Passku.ManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passku.ManagerApp.DataAccess
{
    public interface IMyDb<T> where T : BaseModel
    {

        List<T> GetAll();

        T GetById(string id);

        void Add(T model);

        void Update(string id, T model);

        void Delete(string id);


    }
}
