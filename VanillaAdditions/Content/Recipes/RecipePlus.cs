using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaAdditions.Recipes
{
    public class RecipePlus : ModSystem
    {


        public override void AddRecipes() //could make it use a material type
        {

            //The following recipes makes the Finch staff. Using ID instead of ItemID.name
            Recipe recipe = Recipe.Create(4281, 1);
            recipe.AddIngredient(ItemID.Wood, 8); 
            recipe.AddIngredient(ItemID.Hay, 14); 
            recipe.AddRecipeGroup("BasicBird");
            recipe.Register(); // When you're done, call this to register the recipe.

            //glowing mushroom seed recipe.
            recipe = Recipe.Create(194, 2);
            recipe.AddIngredient(ItemID.GlowingMushroom, 1);
            recipe.Register();

        }
    }
}
