using System;
using System.Collections.Generic;
using System.Linq;
namespace IOC_and_DependencyInjection_C_Sharp.DependencyInjection
{
    public class DIContainer
    {
        private List<ServieceDescriptor> servieceDescriptors; 
        public DIContainer(List<ServieceDescriptor> _servieceDescriptors)
        {
            servieceDescriptors = _servieceDescriptors;
        }
        public T GetService<T>()
        {
            var descriptor = servieceDescriptors.SingleOrDefault(x=>x.ServiceType == typeof(T));
            
            if (descriptor == null)
            {
                throw new Exception($"Service with the name of {typeof(T).Name} is not registered"); 
            }
            if (descriptor.Implementation != null)
            {
                return (T)descriptor.Implementation;
            }



            var implementation = (T) Activator.CreateInstance(descriptor.ImplementationType);

            if (descriptor.LifeTime == ServiceLifeTime.Singleton)
            {
                descriptor.Implementation = implementation;
            }
            
            return  implementation;
        }
    }
}