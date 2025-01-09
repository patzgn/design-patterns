## Blazor Recipe App Exercise

### Goal:
Create an implementation of the **Adapter** design pattern in a Blazor Web App to adapt data from an external API into a simplified view model for display in the UI.

### Description:

1. **Model `RecipeApiModel`:**
   - Represents the data structure returned by the external API.
   - Contains fields such as `Id`, `Name`, `Ingredients`, and `Calories`.

2. **Model `RecipeViewModel`:**
   - Simplified model for the UI.
   - Contains only the fields `Name` and `Ingredients`.

3. **Adapter Class:**
   - Converts `RecipeApiModel` into `RecipeViewModel`.
   - Simplifies the data structure for UI presentation.

4. **Service `RecipeService`:**
   - Fetches recipe data.

5. **Blazor Component:**
   - Displays the simplified recipe data in the UI.

### Objective:
Understand how the Adapter pattern allows adapting external data structures to match the requirements of your application without modifying the original data or the external source.
