using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace MoreWings.Items.Tiles
{
	public class SunplateAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to craft powerful wings\nStill acts as a normal anvil");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("SunplateAnvil");
            item.rare = 2;
            item.value = Item.sellPrice(0, 2, 70, 0);
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(824, 20);
            recipe.AddIngredient(ItemID.IronAnvil, 1);
            recipe.AddIngredient(null, "ZincBar", 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}