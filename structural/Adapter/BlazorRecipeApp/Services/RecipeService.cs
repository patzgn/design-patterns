using BlazorRecipeApp.Models;

namespace BlazorRecipeApp.Services;

public class RecipeService
{
    public RecipeApiModel GetRecipe()
    {
        return new RecipeApiModel()
        {
            Id = 1,
            Name = "Spaghetti Carbonara",
            Ingredients = "Spaghetti, Eggs, Parmesan, Bacon",
            Calories = 500,
        };
    }
}
