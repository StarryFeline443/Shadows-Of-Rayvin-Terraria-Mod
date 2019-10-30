
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace SOFR
{

    public class SOFRplayer : ModPlayer
    {
        public float AnimosityDamage = 1f;
        private const int saveVersion = 0;
        public bool SOFRpet = false;
        public static bool hasProjectile;
        public override void ResetEffects()

        {
            SOFRpet = false;
            AnimosityDamage = 1f;
        }
    }
}