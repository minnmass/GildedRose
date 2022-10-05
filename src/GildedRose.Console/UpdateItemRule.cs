using GildedRose.Console.UpdateItemRules;
using System.Collections.Generic;
using System.Linq;

namespace GildedRose.Console {
	internal static class UpdateItemRuleFactory {
		private static readonly IUpdateItemRule GenericUpdateRule;

		private static readonly IReadOnlyCollection<ReadOnlyKeyValuePair<string, IUpdateItemRule>> _rules;

		static UpdateItemRuleFactory() {
			GenericUpdateRule = new GenericItemRule();

			_rules = new List<ReadOnlyKeyValuePair<string, IUpdateItemRule>> {
				new ReadOnlyKeyValuePair<string, IUpdateItemRule>("Sulfuras", new UnchangingItemRule()),
				new ReadOnlyKeyValuePair<string, IUpdateItemRule>("Aged Brie", new AgedBrieRule()),
				new ReadOnlyKeyValuePair<string, IUpdateItemRule>("Backstage passes", new BackstagePassRule()),
				new ReadOnlyKeyValuePair<string, IUpdateItemRule>("Conjured", new QualityModificationDoublingRule(GenericUpdateRule)),
			};
		}

		public static void Update(Item item) {
			var rule = _rules.FirstOrDefault(r => item.Name.StartsWith(r.Key))?.Value ?? GenericUpdateRule;
			rule.UpdateQuality(item);
			rule.UpdateSellIn(item);
		}

		private class ReadOnlyKeyValuePair<TKey, TValue> {
			public readonly TKey Key;
			public readonly TValue Value;

			public ReadOnlyKeyValuePair(TKey key, TValue value) {
				Key = key;
				Value = value;
			}
		}
	}

	internal interface IUpdateItemRule {
		void UpdateQuality(Item item);
		void UpdateSellIn(Item item);
	}
}
