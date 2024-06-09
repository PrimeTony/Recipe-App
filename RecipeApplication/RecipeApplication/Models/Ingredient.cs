namespace RecipeApplication
{
    // class for ingredients
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; } = "unit"; // Default value
        public double Calories { get; set; }
        public string FoodGroup { get; set; } = "unknown"; // Default value
    }
}
