using BlazorRecipeApp.Models;

namespace BlazorRecipeApp.Adapters;

public class RecipeAdapter(RecipeApiModel apiModel)
{
    public RecipeViewModel ConvertToViewModel()
    {
        return new RecipeViewModel()
        {
            Name = apiModel.Name,
            Ingredients = apiModel.Ingredients,
        };
    }
}
