using Terraria;
using Terraria.ModLoader;

namespace ExampleMod.Items.ExampleDamageClass
{
    // This class stores necessary player info for our custom damage class, such as damage multipliers and additions to knockback and crit.
    public class AnimosityPlayer : ModPlayer
    {
        public static AnimosityPlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<AnimosityPlayer>();
        }

        // Vanilla only really has damage multipliers in code
        // And crit and knockback is usually just added to
        // As a modder, you could make separate variables for multipliers and simple addition bonuses
        public float AnimosityDamageAdd;
  


        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

        private void ResetVariables()
        {
            AnimosityDamageAdd = 0f;
 
         
        }
    }
}