using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DummyDataAccess
    {
        public static async Task<List<EmployeesDummyClass>> GetAllEmployeesAsync()
        {
            await Task.Delay(2000);
            return new List<EmployeesDummyClass>
            {
                new EmployeesDummyClass
                {
                    Age = 15,
                    Id = "1",
                    DateOfBirth = DateTime.Now
                },
                new EmployeesDummyClass
                {
                    Age = 20,
                    Id = "2",
                    DateOfBirth = DateTime.Now
                }
};
        }
        public static async Task<List<UsersDummyClass>> GetAllUsersAsync()
        {
            await Task.Delay(2000);
            return new List<UsersDummyClass>
            {
                new UsersDummyClass
                {
                    Age = 14,
                    FirstName = "Leo",
                    LastName = "Silva"
                },
                new UsersDummyClass
                {
                    Age = 10,
                    FirstName = "Gabriel",
                    LastName = "Huszcza"
                }
            };
        }
    }
}
