using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.Tiles
{
    public class PinkBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.SortingPriorityMaterials[item.type] = 59;
            Tooltip.SetDefault("Feels very smooth");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 750;
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("PinkBar");
            item.placeStyle = 0;
            item.rare = 5;
            item.value = Item.sellPrice(0, 0, 60, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PinkQuartz"), 3);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}