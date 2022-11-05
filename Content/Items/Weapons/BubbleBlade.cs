using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Terraria.GameContent.UI;
using Terraria.Localization;
   

namespace BluysDiscord.Content.Items.Weapons
{
    public class BubbleBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("BubbleBlade"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("a sword made of a bubble. i wonder how it never pops.\nMaterial.");
        }

        public override void SetDefaults()
        {
            Item.damage = 75;
            Item.DamageType = DamageClass.Melee;
            Item.width = 80;
            Item.height = 80;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 4;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }

        //public override void AddRecipes()
        //{
        //Recipe recipe = CreateRecipe();
        // recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
        // recipe.AddIngredient(ItemID.Bubble, 10);
        // recipe.AddTile(TileID.MythrilAnvil);
        // recipe.Register();
        //}
    }
}