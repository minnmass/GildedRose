﻿namespace GildedRose.Console.UpdateItemRules {
	internal class LegacyItemRule : IUpdateItemRule {
		public void Update(Item item) {
			if (item.Name != "Backstage passes to a TAFKAL80ETC concert") {
				if (item.Quality > 0) {
					item.Quality = item.Quality - 1;
				}
			} else {
				if (item.Quality < 50) {
					item.Quality = item.Quality + 1;

					if (item.Name == "Backstage passes to a TAFKAL80ETC concert") {
						if (item.SellIn < 11) {
							if (item.Quality < 50) {
								item.Quality = item.Quality + 1;
							}
						}

						if (item.SellIn < 6) {
							if (item.Quality < 50) {
								item.Quality = item.Quality + 1;
							}
						}
					}
				}
			}

			item.SellIn = item.SellIn - 1;

			if (item.SellIn < 0) {
				if (item.Name != "Backstage passes to a TAFKAL80ETC concert") {
					if (item.Quality > 0) {
						item.Quality = item.Quality - 1;
					}
				} else {
					item.Quality = item.Quality - item.Quality;
				}
			}
		}
	}
}
