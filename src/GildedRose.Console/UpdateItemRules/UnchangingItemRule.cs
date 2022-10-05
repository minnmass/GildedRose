namespace GildedRose.Console.UpdateItemRules {
	internal class UnchangingItemRule : IUpdateItemRule {
		public void UpdateQuality(Item item) {
			// do nothing
			// quality never changes, sellby never changes
		}

		public void UpdateSellIn(Item item) {
			// do nothing
			// quality never changes, sellby never changes
		}
	}
}
