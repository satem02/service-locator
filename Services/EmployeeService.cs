using ServiceLocater.Interfaces;
using ServiceLocater.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLocater.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<EmployeeTransferObject> employeeList = new List<EmployeeTransferObject>();

        public EmployeeService()
        {
            FillEmployeeList();
        }

        private void FillEmployeeList()
        {
            employeeList.Add(new EmployeeTransferObject()
            {
                EmployeeId = 1,
                CreateDate = DateTime.Today.AddDays(-15)
            });

            employeeList.Add(new EmployeeTransferObject()
            {
                EmployeeId = 2,
                CreateDate = DateTime.Today.AddDays(-10)
            });

            employeeList.Add(new EmployeeTransferObject()
            {
                EmployeeId = 3,
                CreateDate = DateTime.Today.AddDays(-5)
            });

            employeeList.Add(new EmployeeTransferObject()
            {
                EmployeeId = 4,
                CreateDate = DateTime.Today.AddDays(-1)
            });
        }

        public void SaveEmployee(EmployeeTransferObject request)
        {
            employeeList.Add(request);
        }

        public EmployeeTransferObject Get(Func<EmployeeTransferObject, bool> condition)
        {
            return employeeList.Where(condition).FirstOrDefault();
        }
    }
}
