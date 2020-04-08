using DALMockup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMockup.Repositories
{
    public class EmployeeRepository : IEmployeeRepository<int,Employee>
    {
        public void Add(Employee entity)
        {
            int idMax = MockupData.employees.Max(e => e.ID);
            entity.ID = idMax + 1;
            MockupData.employees.Add(entity);
        }

        public void Delete(int id)
        {
            Employee e = this.Get(id);
            MockupData.employees.Remove(e);
        }

        public IEnumerable<Employee> Get()
        {
            return MockupData.employees;
        }

        public Employee Get(int id)
        {
            return MockupData.employees.Where(e => e.ID == id).FirstOrDefault();
        }

        public IEnumerable<Employee> Get(string lastName)
        {
            return MockupData.employees.Where(e => e.LastName == lastName);
        }

        public void Update(int id, Employee entity)
        {
            int index = MockupData.employees.ToList().FindIndex(e => e.ID == id);
            MockupData.employees[index] = entity;
        }
    }
}
