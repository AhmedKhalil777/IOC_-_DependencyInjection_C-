using System;
using System.Collections.Generic;

namespace IOC_and_DependencyInjection_C_Sharp.DependencyInjection
{
    public class DIServiceCollection
    {
        private List<ServieceDescriptor> _ServiceDescriptors = new List<ServieceDescriptor>();
        public void RegisterSingleton<T_Service>(T_Service implementation)
        {
            _ServiceDescriptors.Add(new ServieceDescriptor(implementation , ServiceLifeTime.Singleton));
        }



        internal void RegisterSingleton<T>()
        {
            _ServiceDescriptors.Add(new ServieceDescriptor(typeof(T) , ServiceLifeTime.Singleton));
        }

        public void RegisterTransient<T>()
        {
            _ServiceDescriptors.Add(new ServieceDescriptor(typeof(T), ServiceLifeTime.Transient));
        }

        public void RegisterSingleton<TService , TImplementation>() where TImplementation : TService
        {
            _ServiceDescriptors.Add(new ServieceDescriptor(typeof(TService),typeof(TImplementation) ,ServiceLifeTime.Singleton));
        }   
        public void RegisterTransient<TService , TImplementation>() where TImplementation : TService
        {
            _ServiceDescriptors.Add(new ServieceDescriptor(typeof(TService),typeof(TImplementation) ,ServiceLifeTime.Transient));
        }

        public DIContainer GenerateContainer()
        {
            return new DIContainer(_ServiceDescriptors);
        }
    }
}