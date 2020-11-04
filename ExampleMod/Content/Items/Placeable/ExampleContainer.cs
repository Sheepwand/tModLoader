﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Content.Items.Placeable
{
	public class ExampleContainer : ModItem
	{
		public override void SetDefaults() {
			item.width = 22;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.Swing;
			item.consumable = true;
			item.rare = ItemRarityID.Red;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.createTile = ModContent.TileType<Tiles.ExampleContainer>();
		}

		public override void AddRecipes() {
			// recipe.AddIngredient(ModContent.ItemType<VoidMonolith>());
			// recipe.AddIngredient(ModContent.ItemType<ElementResidue>());
			// recipe.AddTile(TileID.CrystalBall);
			CreateRecipe().AddIngredient(ItemID.DirtBlock, 10).Register();
		}
	}
}