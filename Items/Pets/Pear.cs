using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.Pets
{
	public class Pear : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pear");
			Tooltip.SetDefault("Summons a Pear that follows you around and exposes nearby treasure");
		}

		public override void SetDefaults()
		{
			item.damage = 0;
			item.useStyle = 1;
			item.shoot = mod.ProjectileType("Pear");
			item.width = 16;
			item.height = 30;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 1;
			item.noMelee = true;
			item.value = Item.sellPrice(0, 0, 25, 0);
			item.buffType = mod.BuffType("Pear");
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 10);
            recipe.AddIngredient(3002, 20);
            recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}