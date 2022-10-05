﻿namespace GildedRose.Console.UpdateItemRules {
	internal class LegacyItemRule : IUpdateItemRule {
		public void Update(Item item) {
			if (item.Quality > 0) {
				item.Quality = item.Quality - 1;
			}

			item.SellIn = item.SellIn - 1;

			if (item.SellIn < 0) {
				if (item.Quality > 0) {
					item.Quality = item.Quality - 1;
				}
			}
		}
	}
}
