using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MoreWings.Items.ModdedWings
{
	[AutoloadEquip(EquipType.Wings)]
	public class MechanicalWaders : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Demonic Waders");
            Tooltip.SetDefault("Counts as wings\nFlight time: 130\nHorizontal speed: 8\nAcceleration: 1.2\nAllows flight, super fast running and extra mobility on ice");     
		}

		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 10;
            item.value = Item.sellPrice(0, 30, 50, 0);
            item.rare = 6;
			item.accessory = true;
		}	

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 130;
            player.accRunSpeed = 6.25f;
            player.iceSkate = true;
            player.moveSpeed += 07;
        }

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.86f;
			ascentWhenRising = 0.2f;
			maxCanAscendMultiplier = 1.2f;
			maxAscentMultiplier = 2f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 8f;
			acceleration *= 1.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
            recipe.AddIngredient(492, 1);
            recipe.AddIngredient(ItemID.CursedFlame, 5);
            recipe.AddIngredient(521, 10);
            recipe.AddIngredient(1508, 10);
            recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}