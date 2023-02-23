using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace VanillaAdditions.Content.Items
{
	public class DirtPlatform : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("DirtPlatform");
			Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 20;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 2;
            Item.useTime = 2;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = TileType<Tiles.DirtPlatform>();
        }
        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ItemID.DirtBlock, 1)
                .Register();
        }
    }
}