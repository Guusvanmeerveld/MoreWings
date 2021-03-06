using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.ModdedWings
{
    [AutoloadEquip(EquipType.Wings)]
    public class HoneyWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Honey Wings");
            Tooltip.SetDefault("Flight time: 37\nHorizontal speed: 5\nAcceleration: 0.8\nBad vertical speed\nReleases bee's when damaged");
        }


        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.accessory = true;
            item.rare = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 37;
            if (player.velocity.Y < player.oldVelocity.Y && player.wingFrame != 0 && Main.rand.Next(3) == 0)
                Dust.NewDust(player.position + new Vector2(-player.direction * 18, 0), player.width, player.height, 64, 0f, 0f, 150, default(Color), 1.5f);
            player.bee = true;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.50f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1.2f;
            constantAscend = 0.08f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 5f;
            acceleration *= 0.8f;
        }

        class MyGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.QueenBee)
                {
                    if (Main.rand.Next(3) == 0 && !Main.expertMode)
                        Item.NewItem(npc.getRect(), mod.ItemType("HoneyWings"), 1);
                }
            }
        }

    }
}