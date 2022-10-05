using System;

namespace GildedRose.Console.UpdateItemRules {
	internal class AgedBrieRule : IUpdateItemRule {
		public void Update(Item item) {
			int newQuality = item.Quality + (item.SellIn > 0 ? 1 : 2);
			item.Quality = Math.Min(ItemRuleDefaults.MaxQuality, newQuality);

			--item.SellIn;
		}
	}
}
