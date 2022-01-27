using System;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory.Meals
{
    public class ameal : IMeal
    {
        public void ShowAmountOfCalories()
        {
            Console.Write("Calories: 2");
        }
        public void ShowDescription()
        {
            Console.Write("nice meal");
        }
    }
}
