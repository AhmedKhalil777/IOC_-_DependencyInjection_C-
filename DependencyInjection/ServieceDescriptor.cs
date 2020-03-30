using System;
namespace IOC_and_DependencyInjection_C_Sharp.DependencyInjection
{
    public class ServieceDescriptor
    {
        public Type  ServiceType { get;  }

        public Type  ImplementationType { get;  }
        public object Implementation { get; internal set; }
        public ServiceLifeTime LifeTime { get; }
        public ServieceDescriptor(object Implementation ,  ServiceLifeTime lifeTime)
        {
            this.Implementation = Implementation;
            ServiceType = Implementation.GetType();
            LifeTime = lifeTime;
        }

        public ServieceDescriptor(Type type,  ServiceLifeTime lifeTime)
        {
            ServiceType = type;
            LifeTime = lifeTime;
        }
        public ServieceDescriptor(Type ServiceType  , Type ImplementationType  , ServiceLifeTime lifeTime)
        {
            this.ServiceType = ServiceType;
            LifeTime = lifeTime;
            this.ImplementationType = ImplementationType;
        }
    }
}