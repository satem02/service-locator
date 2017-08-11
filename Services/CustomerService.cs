using ServiceLocater.Interfaces;
using ServiceLocater.TransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLocater.Services
{
    public class CustomerService : ICustomerService
    {

        List<CustomerTransferObject> customerList = new List<CustomerTransferObject>();

        public CustomerService()
        {
            FillCustomerLis();
        }

        private void FillCustomerLis()
        {
            customerList.Add(new CustomerTransferObject()
            {
                CustomerId = 1,
                CreateDate = DateTime.Today.AddDays(-15)
            });

            customerList.Add(new CustomerTransferObject()
            {
                CustomerId = 2,
                CreateDate = DateTime.Today.AddDays(-10)
            });

            customerList.Add(new CustomerTransferObject()
            {
                CustomerId = 3,
                CreateDate = DateTime.Today.AddDays(-5)
            });

            customerList.Add(new CustomerTransferObject()
            {
                CustomerId = 4,
                CreateDate = DateTime.Today.AddDays(-1)
            });
        }


        public void SaveCustomer(CustomerTransferObject request)
        {
            customerList.Add(request);
        }

        public CustomerTransferObject Get(Func<CustomerTransferObject, bool> condition)
        {
            return customerList.Where(condition).FirstOrDefault();
        }

        public List<CustomerTransferObject> GetList(Func<CustomerTransferObject, bool> condition)
        {
            return customerList.Where(condition).ToList<CustomerTransferObject>();
        }
    }
}
