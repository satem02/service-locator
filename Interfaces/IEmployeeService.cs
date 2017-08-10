using ServiceLocater.TransferObjects;
using System;
using System.Collections.Generic;

namespace ServiceLocater.Interfaces
{
    public interface IEmployeeService : IService
    {
        // Service specific functions must be defined
        void SaveEmployee(EmployeeTransferObject request);
        EmployeeTransferObject Get(Func<EmployeeTransferObject, bool> condition);
    }
}
