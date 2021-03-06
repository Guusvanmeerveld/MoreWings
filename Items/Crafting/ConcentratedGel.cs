using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace MoreWings.Items.Crafting
{
    public class ConcentratedGel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Concentrated Gel");
            Tooltip.SetDefault("Dense and still lightweight");
        }
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 1, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Gel, 100);
            recipe.AddTile(220);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}