namespace BlazorRecipeApp.Models;

public class RecipeApiModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Ingredients { get; set; }
    public int Calories { get; set; }
}
