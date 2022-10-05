using System;

namespace GildedRose.Console.UpdateItemRules {
	internal class GenericItemRule : IUpdateItemRule {
		public void Update(Item item) {
			int newQuality = item.Quality - (item.SellIn > 0 ? 1 : 2);
			item.Quality = Math.Max(ItemRuleDefaults.MinQuality, newQuality);

			--item.SellIn;
		}
	}
}
