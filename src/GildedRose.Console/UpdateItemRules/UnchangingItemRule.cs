namespace GildedRose.Console.UpdateItemRules {
	internal class UnchangingItemRule : IUpdateItemRule {
		public void Update(Item item) {
			// do nothing
			// quality never changes, sellby never changes
		}
	}
}
