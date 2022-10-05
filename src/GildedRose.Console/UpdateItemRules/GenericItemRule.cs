using System;

namespace GildedRose.Console.UpdateItemRules {
	internal class GenericItemRule : IUpdateItemRule {
		private static int MinQuality = 0;

		public void Update(Item item) {
			throw new Exception("boom - not ready for use in refactoring");
			int newQuality = item.Quality - (item.SellIn > 0 ? 1 : 2);
			item.Quality = Math.Max(MinQuality, newQuality);

			--item.SellIn;
		}
	}
}
