using AspDynamicForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspDynamicForm.Helpers;

namespace AspDynamicForm.Services
{
    public class EmployeeService : DALMockup.Repositories.IEmployeeRepository<int, Models.Employee>
    {
        private DALMockup.Repositories.IEmployeeRepository<int, DALMockup.Models.Employee> _globalRepo;

        public EmployeeService()
        {
            _globalRepo = new DALMockup.Repositories.EmployeeRepository();
        }

        public void Add(Employee entity)
        {
            _globalRepo.Add(entity.ToGlobal());
        }

        public void Delete(int id)
        {
            _globalRepo.Delete(id);
        }

        public IEnumerable<Employee> Get()
        {
            return _globalRepo.Get().Select(e => e.ToClient());
        }

        public Employee Get(int id)
        {
            return _globalRepo.Get(id).ToClient();
        }

        public IEnumerable<Employee> Get(string lastName)
        {
            return _globalRepo.Get(lastName).Select(e => e.ToClient());
        }

        public void Update(int id, Employee entity)
        {
            _globalRepo.Update(id, entity.ToGlobal());
        }
    }
}