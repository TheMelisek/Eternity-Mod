using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace EternityMod.Content.Tiles
{
    public class EternityOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 410;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 975;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            DustType = 84;
            ItemDrop = ModContent.ItemType<Items.Placeable.EternityOre>();
            SoundType = SoundID.Tink;
            SoundStyle = 1;
            MinPick = 200;
            MineResist = 4f;
        }
    }
}