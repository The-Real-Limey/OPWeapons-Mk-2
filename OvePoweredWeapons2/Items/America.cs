using Terraria.ID;
using Terraria.ModLoader;

namespace OvePoweredWeapons2.Items
{
	public class America : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The America Book"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("*Star Spangled Banner*");
		}

		public override void SetDefaults() 
		{
			item.damage = 1337;
			item.width = 24;
			item.height = 30;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 5;
			item.knockBack = 100;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
			item.shoot = 167;
			item.shootSpeed = 10f;
			item.magic = true;
			
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}