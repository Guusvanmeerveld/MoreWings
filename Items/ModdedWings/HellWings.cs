using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.ModdedWings
{
	[AutoloadEquip(EquipType.Wings)]
	public class HellWings : ModItem
	{
		public override void SetStaticDefaults()
		{
            Tooltip.SetDefault("Flight time: 45\nHorizontal speed: 6\nAcceleration: 1"); 
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
            item.value = Item.sellPrice(0, 2, 80, 0);
            item.rare = 3;
			item.accessory = true;
		}	

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 45;
            if (player.velocity.Y < player.oldVelocity.Y && player.wingFrame != 0)
                Dust.NewDust(player.position + new Vector2(-player.direction * 18, 0), player.width, player.height, 6, 0f, 10f, 150, default(Color), 1.5f);
        }

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.86f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 1.7f;
			constantAscend = 0.12f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 6f;
			acceleration *= 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CoreofFlight"), 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.Bone, 60);            
            recipe.AddIngredient(ItemID.Feather, 10);
            recipe.AddTile(null, "SunplateAnvil");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}