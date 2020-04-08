using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMockup.Repositories
{
    public interface IUserRepository
    {
        bool Check(string username, string password);
    }
}
