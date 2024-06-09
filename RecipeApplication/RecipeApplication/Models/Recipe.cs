using System;
using System.Collections.Generic;

namespace RecipeApplication
{
    // Class for recipes
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public double TotalCalories { get; private set; }

        public Recipe(string name, double totalCalories)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
            TotalCalories = totalCalories;
        }

        // Method to add an ingredient to the recipe
        public void AddIngredient(string name, double quantity, string unit, double calories, string foodGroup)
        {
            Ingredient ingredient = new Ingredient
            {
                Name = name,
                Quantity = quantity,
                Unit = unit,
                Calories = calories,
                FoodGroup = foodGroup
            };
            Ingredients.Add(ingredient);
        }
    }
}
