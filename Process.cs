using ServiceLocater.Interfaces;
using ServiceLocater.Services;
using ServiceLocater.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLocater
{
    public class Process
    {
        public Process()
        {
            ServiceLocator serviceLocator = new ServiceLocator();

            var customerService = serviceLocator.GetService<ICustomerService>();
            var customerList = customerService.GetList(c => c.CreateDate > DateTime.Today.AddDays(-7));
            

            var employeeService = serviceLocator.GetService<IEmployeeService>();
            var employee = employeeService.Get(e => e.EmployeeId == 222);
        }

    }
}
