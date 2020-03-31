using IOC_and_DependencyInjection_C_Sharp.Data;

namespace IOC_and_DependencyInjection_C_Sharp.Services
{
    public class BreakfastService : IFoodService
    {
        private readonly IRandomFoodGenerator _foodGenerator;
        public BreakfastService(IRandomFoodGenerator foodGenerator )
        {
            _foodGenerator = foodGenerator;
        }
        public void eatSomething()
        {
            System.Console.WriteLine(_foodGenerator.getfood());
        }
    }
}