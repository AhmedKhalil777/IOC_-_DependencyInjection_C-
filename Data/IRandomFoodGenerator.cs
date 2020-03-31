using System.Collections.Generic;
using System;
namespace IOC_and_DependencyInjection_C_Sharp.Data {
    public interface IRandomFoodGenerator {
        string Food { get; }
        string getfood();
         string RandomGuid {get;}
    }

    public class RandomFoodGenerator : IRandomFoodGenerator {
        private static List<string> FoodList = new List<string> () {
            "Hamburger 🍔",
            "🥞 Pancakes" ,
            "🧇 Waffle",
            "🧀 Cheese Wedge",
            "🍖 Meat on Bone",
            "🍗 Poultry Leg",
            "🥩 Cut of Meat",
            "🥓 Bacon",
            "🍟 French Fries",
            "🍕 Pizza",
            "🌭 Hot Dog",
            "🥪 Sandwich"
        };
        public string RandomGuid {get;set;} = Guid.NewGuid().ToString();
        public string Food { get; set; } = FoodList.ToArray()[ (int)(new Random().NextDouble()*12)];

        

        public string getfood()
        {

            return Food+ RandomGuid;
        }
    }
}