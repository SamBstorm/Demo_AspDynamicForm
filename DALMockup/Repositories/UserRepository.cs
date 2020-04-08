using DALMockup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMockup.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool Check(string username, string password)
        {
            return MockupData.users.Where(u => u.UserName == username && u.Password ==password).SingleOrDefault() != null;
        }
    }
}
