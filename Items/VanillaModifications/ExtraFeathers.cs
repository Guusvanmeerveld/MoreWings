using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items
{
    public class Feather : GlobalItem
    {
        class MyGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Bird)
                {
                    if (Main.rand.NextFloat() < .20f)
                        Item.NewItem(npc.getRect(), ItemID.Feather, 1 + Main.rand.Next(1));
                }
            }
        }
    } 
}