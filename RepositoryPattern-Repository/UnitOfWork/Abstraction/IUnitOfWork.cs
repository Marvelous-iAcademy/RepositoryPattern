using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Repository.UnitOfWork.Abstraction
{
    public interface IUnitOfWork
    {
        Task Save();
        void Dispose();
    }
}
