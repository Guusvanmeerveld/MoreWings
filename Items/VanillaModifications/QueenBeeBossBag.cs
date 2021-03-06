using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.VanillaModifications
{
    public class QueenBeeBossBag : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (Main.rand.Next(3) == 0 && arg == ItemID.QueenBeeBossBag && context == "bossBag")
            {
                player.QuickSpawnItem(mod.ItemType("HoneyWings"));
            }
        }
    }
}