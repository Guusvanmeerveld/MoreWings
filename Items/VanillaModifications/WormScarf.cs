using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace MoreWings.Items.VanillaModifications
{
    public class WormScarf : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.mod == "Terraria" && tooltipLine.Name == "Tooltip0" && item.type == ItemID.WormScarf)
                {
                    tooltipLine.text = "Reduces damage taken by 12%";
                }
            }
        }
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
           {
               player.endurance += 0.12f;
           }
    }
}