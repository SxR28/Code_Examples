using System;

namespace Coding
{
    public class ChefTeller
    {
        private string[] foods = new String[]
        {
            // Italian food
            "Pasta carbonnara",
            "Pizza Quatro Formaggi",
            "Beef Lasagna",
            "Pork Lasagna",
            
            // American Foods
            "Beef Burger", 
            "Cripsy",
            "Pork Burger",
            "French Fries"
        };

        public void Foods(string chef)
        {
            if (chef == "Italian")
            {
                for (int i = 1; i <= foods.Length; i++)
                {
                    Console.WriteLine("Dish : " + i + " is " + foods[i]);
                }
            }
        }
    }
}