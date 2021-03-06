using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.ModdedWings
{
    [AutoloadEquip(EquipType.Wings)]
    public class LifeWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wings of Life");
            Tooltip.SetDefault("Flight time: 160\nHorizontal speed: 6.5\nAcceleration: 1.75\nGood vertical speed\nIncreases max life by +20\nIncreases life regeneration by +2 when flying");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = Item.sellPrice(0, 3, 40, 0);
            item.rare = 7;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 160;
            if (player.velocity.Y < player.oldVelocity.Y && player.wingFrame != 0)
                player.lifeRegen += 2;
            if (player.velocity.Y < player.oldVelocity.Y && player.wingFrame != 0 && Main.rand.Next(5) == 0)
                Dust.NewDust(player.position + new Vector2(-player.direction * 18, 0), player.width, player.height, mod.DustType("Heart"));
            player.statLifeMax2 += 20;
        }
        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.50f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1.5f;
            constantAscend = 0.1f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 6.5f;
            acceleration *= 1.75f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("PinkBar"), 10);
            recipe.AddIngredient(ItemID.LifeFruit, 4);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.AddIngredient(49, 1);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}