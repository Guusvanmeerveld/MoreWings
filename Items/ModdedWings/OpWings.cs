using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MoreWings.Items.ModdedWings
{
    [AutoloadEquip(EquipType.Wings)]
    public class OpWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heavenly Wings");
            Tooltip.SetDefault("Flight time: Infinite" + "\nHorizontal speed: 10" + "\nAcceleration: 5");
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 99999999;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.25f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 5f;
            maxAscentMultiplier = 5f;
            constantAscend = 0.135f;
        }
        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 10f;
            acceleration *= 5f;
        }
    }
}