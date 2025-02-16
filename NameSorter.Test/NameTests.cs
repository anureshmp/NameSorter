using NameSorter.Models;
using Xunit;

namespace NameSorter.Tests
{
	public class NameTests
	{
		[Fact]
		public void Name_ShouldParseCorrectly()
		{
			var name = new Name("Marin Alvarez");
			Assert.Equal("Marin Alvarez", name.FullName);
			Assert.Equal("Alvarez", name.LastName);
			Assert.Equal("Marin", name.FirstName);
		}
	}
}
