using IOC_and_DependencyInjection_C_Sharp.Data;

namespace IOC_and_DependencyInjection_C_Sharp.Services
{
    public class LunchService : IFoodService
    {

        private readonly IRandomFoodGenerator _foodGenerator;
        public LunchService(IRandomFoodGenerator foodGenerator )
        {
            _foodGenerator = foodGenerator;
        }
         
        
        public void eatSomething()
        {
            System.Console.WriteLine(_foodGenerator.getfood());
        }
    }
}