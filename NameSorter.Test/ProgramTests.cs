using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.IO;
using Xunit;

namespace NameSorter.Tests
{
	public class ProgramTests
	{
	
		[Fact]
		public void Program_ShouldHandleFileNotFound()
		{
			var nonExistentFilePath = @"C:\DyeDurham\Assessment\NameSorter\path.txt";
			Assert.False(File.Exists(nonExistentFilePath));
		}

		
	}
}
