﻿using System;

namespace PizzaStuff.Recipes
{
    public sealed class PizzaHawaii : PizzaRecipe
    {
        public override string Name => "Hawaii";

        public override Ingredients Ingredients => throw new NotImplementedException("Method is not implemented.");
    }
}
