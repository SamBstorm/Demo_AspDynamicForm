using DALMockup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMockup.Repositories
{
    public interface IEmployeeRepository<TKey, T> : IRepository<TKey,T> where T : class
    {
        IEnumerable<T> Get(string lastName);
    }
}
