using EternityMod.Content.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EternityMod.Content.Items.Materials
{
    public class EternityScale : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eternity Scale");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            Item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<EternityOre>(4)
                .AddTile(TileID.AdamantiteForge)
                .Register();
        }
    }
}
