using System;

namespace GildedRose.Console.UpdateItemRules {
	internal class QualityModificationDoublingRule : IUpdateItemRule {
		private readonly IUpdateItemRule _baseRule;

		public QualityModificationDoublingRule(IUpdateItemRule baseRule) {
			_baseRule = baseRule ?? throw new ArgumentNullException(nameof(baseRule));
		}

		public void UpdateQuality(Item item) {
			_baseRule.UpdateQuality(item);
			_baseRule.UpdateQuality(item);
		}

		public void UpdateSellIn(Item item) {
			_baseRule.UpdateSellIn(item);
		}
	}
}
