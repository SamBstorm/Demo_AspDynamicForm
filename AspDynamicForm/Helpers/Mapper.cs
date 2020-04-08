using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDynamicForm.Helpers
{
    public static class Mapper
    {
        public static Models.Employee ToClient(this DALMockup.Models.Employee entity)
        {
            return new Models.Employee()
            {
                ID = entity.ID,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
        public static DALMockup.Models.Employee ToGlobal(this Models.Employee entity)
        {
            return new DALMockup.Models.Employee()
            {
                ID = entity.ID,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
    }
}