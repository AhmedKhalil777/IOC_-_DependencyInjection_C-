namespace IOC_and_DependencyInjection_C_Sharp.Services
{
    public class BreakfastService : IFoodService
    {
        public void eatSomething()
        {
            System.Console.WriteLine("Eating Breakfast 🥞 ");
        }
    }
}