using NameSorter.Contracts;
using NameSorter.Models;
using NameSorter.Services;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace NameSorter.Tests
{
	public class FileNameReaderTests
	{
		[Fact]
		public void FileNameReader_ShouldReadNamesCorrectly()
		{
			var filePath = "test-input.txt";
			File.WriteAllLines(filePath, new[] { "Mikayla Lopez", "Frankie Conner Ritter"});

			INameReader nameReader = new FileNameReader(filePath);
			List<Name> names = nameReader.ReadNames();

			Assert.Equal(2, names.Count);
			Assert.Equal("Mikayla Lopez", names[0].FullName);
			Assert.Equal("Frankie Conner Ritter", names[1].FullName);

			File.Delete(filePath); // Clean up test file
		}
	}
}
