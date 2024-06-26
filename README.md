# RecipeApplication

This application allows users to create recipes, add ingredients, and display recipes. Users can also filter recipes based on ingredient name, food group, or maximum calories.

## Changes Made

1. **Separation of Classes**:
    - `Ingredient` class is in `Ingredient.cs`.
    - `Recipe` class is in `Recipe.cs`.

2. **WPF Integration**:
    - Created a WPF project structure.

3. **UI Design**:
    - Added buttons for adding recipes, displaying recipes, and filtering recipes.
    - Added text boxes for user input.
    - Added list views to display recipes and ingredients.

4. **Event Handling**:
    - Handled button clicks to add recipes and ingredients.
    - Implemented logic to filter recipes based on user criteria.

5. **Filtering Logic**:
    - Users can filter the list of recipes by entering the name of an ingredient, selecting a food group, or setting a maximum number of calories.

## How to Compile and Run

### IDE

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/)

### Steps

1. **Clone the Repository**

    ```bash
    git clone https://github.com/your-repository/RecipeApplication.git
    cd RecipeApplication
    ```

2. **Open the Project**

    Open the solution file `RecipeApplication.sln` in Visual Studio or your preferred IDE.

3. **Build the Solution**

    Build the solution to restore the NuGet packages and compile the code.

4. **Run the Application**

    Run the application by pressing `F5`.



