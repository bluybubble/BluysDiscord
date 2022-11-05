using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace InsulinPen.Content.Materials;
public class Insulin : ModItem
{

    public override void SetStaticDefaults()
    {
        DisplayName.SetDefault("Insulin");
        Tooltip.SetDefault("Used for the care of diabetics but... what if.");
    }

    public override void SetDefaults()
    {
        Item.width = 12;
        Item.height = 12;

        Item.rare = ItemRarityID.Blue;
        Item.value = Item.sellPrice(0, 0, 1, 15);
        Item.maxStack = 999;

    }

    public override void AddRecipes()
    {
        Recipe recipe = Recipe.Create(ItemType<Insulin>(), 16);
        recipe.AddIngredient(ItemType<Pancreas>(), 1);
        recipe.AddTile(TileID.DemonAltar);
        recipe.Register();
    }
}
