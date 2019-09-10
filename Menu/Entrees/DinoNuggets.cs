using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class DinoNuggets
    {
        private int count = 6;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * (uint)count;
        }

        /* Increment count, so the next time we access the Ingredients property, we will get one more nugget */
        public void AddNugget()
        {
            this.count++;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}
