using System;

namespace GildedRose.Console.UpdateItemRules {
	internal class BackstagePassRule : IUpdateItemRule {
		public void UpdateQuality(Item item) {
			int newQuality = 0;
			if (item.SellIn > 10) {
				newQuality = item.Quality + 1;
			} else if (item.SellIn > 5) {
				newQuality = item.Quality + 2;
			} else if (item.SellIn > 0) {
				newQuality = item.Quality + 3;
			}
			item.Quality = Math.Min(ItemRuleDefaults.MaxQuality, newQuality);
		}

		public void UpdateSellIn(Item item) {
			--item.SellIn;
		}
	}
}
