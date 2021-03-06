using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreWings.Tiles
{
    public class ZincOre : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 675;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 975;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Zinc Ore");
            AddMapEntry(new Color(152, 171, 198), name);

            dustType = 53;
            drop = mod.ItemType("ZincOre");
            soundType = 21;
            soundStyle = 1;
            mineResist = 1f;
            minPick = 60;
        }
    }
}