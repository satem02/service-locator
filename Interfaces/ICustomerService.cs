using ServiceLocater.TransferObjects;
using System;
using System.Collections.Generic;

namespace ServiceLocater.Interfaces
{
    public interface ICustomerService : IService
    {
        // Service specific functions must be defined
        void SaveCustomer(CustomerTransferObject request);
        CustomerTransferObject Get(Func<CustomerTransferObject, bool> condition);
        List<CustomerTransferObject> GetList(Func<CustomerTransferObject, bool> condition);
    }
}
