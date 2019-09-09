﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Entrees
{
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldPepper()
        {
            this.peppers = false;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}