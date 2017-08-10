using ServiceLocater.Interfaces;
using ServiceLocater.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLocater
{
    public class ServiceLocator : IServiceManager
    {
        Dictionary<object, IService> serviceContainer = null;

        public ServiceLocator()
        {
            serviceContainer = new Dictionary<object, IService>();
            serviceContainer.Add(typeof(IEmployeeService), new EmployeeService());
            serviceContainer.Add(typeof(ICustomerService), new CustomerService());
        }

        public T GetService<T>()
        {
            try
            {
                return (T)serviceContainer[typeof(T)];
            }

            catch (Exception ex)
            {
                throw new Exception("Service out.");
            }
        } 
    }
}
