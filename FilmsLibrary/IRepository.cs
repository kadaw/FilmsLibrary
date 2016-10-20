using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary
{
   public interface IRepository<T>
    {
        T[] GetAllEntities();
        T GetEntity(int id);
        void 
    }
}
