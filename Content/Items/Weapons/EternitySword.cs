using EternityMod.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EternityMod.Content.Items.Weapons
{
	public class EternitySword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eternity Sword");
			Tooltip.SetDefault("It holds mysterious dark powers inside...");
		}

		public override void SetDefaults()
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Expert;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.EternitySwordProjectile>();
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<EternityScale>(25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}