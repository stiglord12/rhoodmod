using System.Numerics;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rhood.Content.Items.Weapons
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class PurpleMethod : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.rhood.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 132;
			Item.DamageType = DamageClass.Melee;
			Item.width = 56;
			Item.height = 56;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 3;
			Item.value = Item.buyPrice(gold: 4);
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item15;
			Item.autoReuse = true;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox) {
    if (Main.rand.Next(0) == 0) { //There is a 1/6 chance of dust occurring. Experiment with the chances by changing the 6
        Dust.NewDust(new Microsoft.Xna.Framework.Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Electric); //DustID.Electric is the dust that I use, but can be freely changed to another dust that glows
    }
}
		
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PurplePhasesaber);
			recipe.AddIngredient(ItemID.Actuator, 50);
			recipe.AddIngredient(ItemID.TitaniumBar, 10);
			recipe.AddIngredient<Items.Weapons.PurpleMethod>(); //makes uncraftable without cheats
			recipe.AddTile(TileID.Containers);
			recipe.Register();

		}
	}
}
