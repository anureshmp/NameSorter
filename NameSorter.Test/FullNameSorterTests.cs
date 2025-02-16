using Microsoft.VisualBasic;
using NameSorter.Contracts;
using NameSorter.Models;
using NameSorter.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using Xunit;

namespace NameSorter.Tests
{
	public class BubbleNameSorterTests
	{
		[Fact]
		public void FullNameSorter_ShouldSortNamesCorrectly()
		{
			var names = new List<Name>
			{
				
				new Name("Janet Parsons"),
				new Name("Vaughn Lewis"),
				new Name("Adonis Julius Archer"),
				new Name("Shelby Nathan Yoder"),
				new Name("Marin Alvarez"),
				new Name("London Lindsey"),
				new Name("Beau Tristan Bentley"),
				new Name("Leo Gardner"),
				new Name("Hunter Uriah Mathew Clarke"),
				new Name("Mikayla Lopez"),
				new Name("Frankie Conner Ritter")

			};

			INameSorter nameSorter = new FullNameSorter();
			nameSorter.Sort(names);

			Assert.Equal("Marin Alvarez", names[0].FullName);
			Assert.Equal("Adonis Julius Archer", names[1].FullName);
			Assert.Equal("Beau Tristan Bentley", names[2].FullName);
			Assert.Equal("Hunter Uriah Mathew Clarke", names[3].FullName);
			Assert.Equal("Leo Gardner", names[4].FullName);
			Assert.Equal("Vaughn Lewis", names[5].FullName);
			Assert.Equal("London Lindsey", names[6].FullName);
			Assert.Equal("Mikayla Lopez", names[7].FullName);
			Assert.Equal("Janet Parsons", names[8].FullName);
			Assert.Equal("Frankie Conner Ritter", names[9].FullName);
			Assert.Equal("Shelby Nathan Yoder", names[10].FullName);
		}
	}
}
