using GildedRose.Console.UpdateItemRules;
using System.Collections.Generic;

namespace GildedRose.Console {
	internal static class UpdateItemRuleFactory {
		private static readonly IReadOnlyDictionary<string, IUpdateItemRule> _rules = new Dictionary<string, IUpdateItemRule> {
			
		};

		private static readonly IUpdateItemRule GenericUpdateRule = new LegacyItemRule();

		public static void Update(Item item) {
			(_rules.TryGetValue(item.Name, out var rule) ? rule : GenericUpdateRule).Update(item);
		}
	}

	internal interface IUpdateItemRule {
		void Update(Item item);
	}
}
