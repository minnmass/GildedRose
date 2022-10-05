using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests {
	public class SulfurasTests {
		const string Name = "Sulfuras, Hand of Ragnaros";

		[Theory]
		[InlineData(10)]
		[InlineData(1)]
		[InlineData(0)]
		public void SellInIgnored_QualityRemainsAtInitialValue(int sellIn) {
			const int initialQuality = 42;
			var item = new Item { Name = Name, Quality = initialQuality, SellIn = sellIn };

			var sut = new Program { Items = new[] { item } };
			sut.UpdateQuality();

			Assert.Equal(initialQuality, item.Quality);
		}

		[Fact]
		public void SellInNotDecremented() {
			const int initialQuality = 42;
			const int sellIn = 20;
			var item = new Item { Name = Name, Quality = initialQuality, SellIn = sellIn };

			var sut = new Program { Items = new[] { item } };
			sut.UpdateQuality();

			Assert.Equal(sellIn, item.SellIn);
		}
	}
}
