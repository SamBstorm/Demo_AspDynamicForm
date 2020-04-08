using DALMockup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMockup
{
    internal static class MockupData
    {
        public static IList<Employee> employees = new List<Employee>()
        {
                new Employee(){ ID=1, FirstName="Jhon", LastName="Person"},
                new Employee(){ ID=2, FirstName="Fitz", LastName="Morre"},
                new Employee(){ ID=3, FirstName="Gérald", LastName="Meurice"},
                new Employee(){ ID=4, FirstName="Ken", LastName="Gillis"},
                new Employee(){ ID=5, FirstName="Eddy", LastName="Delange"}
        };

        public static IList<User> users = new List<User>()
        {
            new User() { ID = 1, UserName="Sam", Password="test1234="}
        };
    }
}
