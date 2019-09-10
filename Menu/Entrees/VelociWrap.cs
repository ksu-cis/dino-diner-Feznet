﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class VelociWrap
    {
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (lettuce) ingredients.Add("Lettuce");
                if (dressing) ingredients.Add("Dressing");
                if (cheese) ingredients.Add("Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }
        
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}