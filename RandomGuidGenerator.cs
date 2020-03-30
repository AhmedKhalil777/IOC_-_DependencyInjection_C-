using System;


namespace IOC_and_DependencyInjection_C_Sharp
{
    public  class RandomGuidGenerator
    {
            public Guid  RandomGuid { get; set; } = Guid.NewGuid();
    }
}

