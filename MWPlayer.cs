using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace MoreWings
{
    public class MWPlayer : ModPlayer
    {
        public bool pear = false;
        public bool redDevil = false;

        public override void ResetEffects()
        {
            redDevil = false;
            pear = false;
        }
    }
}
