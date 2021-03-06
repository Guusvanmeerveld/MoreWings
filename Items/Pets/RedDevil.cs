using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.Pets
{
	public class RedDevil : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chunk of Flesh");
			Tooltip.SetDefault("Summons a Red Devil to follow you around");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 24));
        }

		public override void SetDefaults()
		{
            Item refItem = new Item();
            refItem.SetDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("RedDevil");
			item.buffType = mod.BuffType("RedDevil");
            item.rare = 4;
            item.value = Item.sellPrice(0, 2, 50, 0);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.killGuide = true;
        }
        class MyGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.WallofFlesh)
                {
                    if (Main.rand.NextFloat() < .25f && !Main.expertMode)
                        Item.NewItem(npc.getRect(), mod.ItemType("Chunk of Flesh"), 1);
                }
            }
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