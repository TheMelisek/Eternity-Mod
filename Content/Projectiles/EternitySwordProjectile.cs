using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EternityMod.Content.Projectiles
{
    public class EternitySwordProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eternity's sword projectile");
        }

        public override void SetDefaults()
        {
            Projectile.width = 8;
            Projectile.height = 100;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
        }
    }
}