using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items
{
    public class CoreofFlight : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flight Artifact");
            Tooltip.SetDefault("Allows you to jump higher\nNegates fall damage\nThe core of prehardmode wings");
        }

        public override void SetDefaults()
        {
            item.Size = new Vector2(34);
            item.rare = 2;
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 55, 0);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.jumpBoost = true;
            player.noFallDmg = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(158, 1);
            recipe.AddIngredient(53, 1);
            recipe.AddIngredient(mod.ItemType("ConcentratedGel"), 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
