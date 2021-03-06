using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Items.VanillaModifications
{
    public class WallOfFleshBossBag : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (Main.rand.NextFloat() < .25f && arg == ItemID.WallOfFleshBossBag && context == "bossBag")
            {
                player.QuickSpawnItem(mod.ItemType("RedDevil"));
            }
        }
    }
}