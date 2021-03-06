using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.ModdedWings
{
    [AutoloadEquip(EquipType.Wings)]
    public class DirtWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Flight time: 25" + "\nHorizontal speed: 4" + "\nAcceleration: 0.6\nVery bad vertical speed"); 
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 1, 50);
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 20;
            if (player.velocity.Y < player.oldVelocity.Y && player.wingFrame != 0 && Main.rand.Next(4) == 0)
                Dust.NewDust(player.position + new Vector2(-player.direction * 18, 0), player.width, player.height, mod.DustType("Dirt"));
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.25f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1f;
            constantAscend = 0.06f;
        }
        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 4f;
            acceleration *= 0.6f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("CoreofFlight"), 1);
            recipe.AddIngredient(ItemID.DirtBlock, 100);
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddTile(null, "SunplateAnvil");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}