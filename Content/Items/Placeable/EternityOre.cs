using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EternityMod.Content.Items.Placeable
{
    public class EternityOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Eternity Ore");
            Tooltip.SetDefault("You can feel the emptiness of it");
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.EternityOre>();
            Item.width = 12;
            Item.height = 12;
        }
    }
}