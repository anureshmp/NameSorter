using NameSorter.Contracts;
using NameSorter.Models;
using NameSorter.Services;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace NameSorter.Tests
{
	public class FileNameWriterTests
	{
		[Fact]
		public void FileNameWriter_ShouldWriteNamesCorrectly()
		{
			var filePath = "test-output.txt";
			var names = new List<Name>
			{
				new Name("Mikayla Lopez"),
				new Name("Frankie Conner Ritter")
			};

			INameWriter nameWriter = new FileNameWriter(filePath);
			nameWriter.WriteNames(names);

			var writtenNames = File.ReadAllLines(filePath);
			Assert.Equal(2, writtenNames.Length);
			Assert.Equal("Mikayla Lopez", writtenNames[0]);
			Assert.Equal("Frankie Conner Ritter", writtenNames[1]);

			File.Delete(filePath); // Clean up test file
		}
	}
}
