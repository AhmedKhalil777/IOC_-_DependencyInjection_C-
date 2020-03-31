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

        public object GetService(Type serviceType)
        {
            var descriptor = servieceDescriptors.SingleOrDefault(x=>x.ServiceType == serviceType);
            
            if (descriptor == null)
            {
                throw new Exception($"Service with the name of {serviceType.Name} is not registered"); 
            }
            if (descriptor.Implementation != null)
            {
                return descriptor.Implementation;
            }
            var actualtype = descriptor.ImplementationType ?? descriptor.ServiceType;
             
            if (actualtype.IsAbstract || actualtype.IsInterface )
            {
                throw new Exception($" Can't istentiate the abstract or interfaces {actualtype}");
            }

            var constructorInfo =  actualtype.GetConstructors().First();
            var parameters = constructorInfo.GetParameters().Select(x=>GetService(x.ParameterType))
                .ToArray();

            var implementation =  Activator.CreateInstance(actualtype , parameters);

            if (descriptor.LifeTime == ServiceLifeTime.Singleton)
            {
                descriptor.Implementation = implementation;
            }
            
            return  implementation;
        }
        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }
    }
}