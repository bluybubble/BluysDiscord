using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BluysDiscord.Content.Materials
{
    internal class Bubble : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bubble"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("no matter how hard you try it wont pop.");
        }

        public override void SetDefaults()
        {
            Item.rare = 3;
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 15);
            recipe.AddIngredient(ItemID.PinkGel, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}
