using System;

namespace GildedRose.Console.UpdateItemRules {
	internal class GenericItemRule : IUpdateItemRule {
		public void UpdateQuality(Item item) {
			int newQuality = item.Quality - (item.SellIn > 0 ? 1 : 2);
			item.Quality = Math.Max(ItemRuleDefaults.MinQuality, newQuality);
		}

		public void UpdateSellIn(Item item) {
			--item.SellIn;
		}
	}
}
