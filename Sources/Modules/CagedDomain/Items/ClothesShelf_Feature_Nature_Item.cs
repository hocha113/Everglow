using Everglow.CagedDomain.Tiles;

namespace Everglow.CagedDomain.Items;

public class ClothesShelf_Feature_Nature_Item : ModItem
{
	public override string LocalizationCategory => Everglow.Commons.Utilities.LocalizationUtils.Categories.Placeables;

	public override void SetDefaults()
	{
		Item.DefaultToPlaceableTile(ModContent.TileType<ClothesShelf_Feature_Nature>());
		Item.width = 56;
		Item.height = 38;
	}
}