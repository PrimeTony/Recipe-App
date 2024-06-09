using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RecipeApplication
{
    public partial class MainWindow : Window
    {
        private List<Recipe> recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            // Populate recipes (add your own logic here)
            recipes.Add(new Recipe("Recipe 1", 250));
            recipes.Add(new Recipe("Recipe 2", 350));
            recipes.Add(new Recipe("Recipe 3", 280));
            recipes.Add(new Recipe("Recipe 4", 400));
            recipes.Add(new Recipe("Recipe 5", 320));

            UpdateRecipeList();
        }

        private void UpdateRecipeList()
        {
            // Apply filters
            var filteredRecipes = recipes;

            if (!string.IsNullOrEmpty(txtIngredientFilter.Text))
                filteredRecipes = filteredRecipes.Where(r => r.Ingredients.Any(i => i.Name.ToLower().Contains(txtIngredientFilter.Text.ToLower()))).ToList();

            if (cmbFoodGroupFilter.SelectedIndex > 0)
            {
                var selectedFoodGroup = (cmbFoodGroupFilter.SelectedItem as ComboBoxItem)?.Content.ToString().ToLower();
                filteredRecipes = filteredRecipes.Where(r => r.Ingredients.Any(i => i.FoodGroup.ToLower() == selectedFoodGroup)).ToList();
            }

            // Update ListView
            lvRecipes.ItemsSource = filteredRecipes;
        }

        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            UpdateRecipeList();
        }
    }
}
