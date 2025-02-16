using NameSorter.Contracts;
using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
	/// <summary>
	/// Class to sort names using Bubble Sort algorithm
	/// </summary>
	public class FullNameSorter : INameSorter
	{
		/// <summary>
		/// Method to sort names
		/// </summary>
		/// <param name="names"></param>
		public void Sort(List<Name> names)
		{
			// Sorting names using bubble sort algorithm
			for (int i = 0; i < names.Count - 1; i++)
			{
				for (int j = 0; j < names.Count - i - 1; j++)
				{
					if (CompareNames(names[j], names[j + 1]) > 0)
					{
						// Swap names[j] and names[j + 1]
						Name temp = names[j];
						names[j] = names[j + 1];
						names[j + 1] = temp;
					}
				}
			}
		}

		/// <summary>
		/// CompareNames method compares two Name objects based on their last names and
		/// If the last names are the same, then by their first names.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>The method returns an integer value:
		///-1 the first name is less than the second name,
        ///1 if the first name is greater than the second name,
        ///0 if both names are equal.</returns>
		private int CompareNames(Name x, Name y)
		{
			// Compare by last name
			int lastNameComparison = CompareStrings(x.LastName, y.LastName);
			if (lastNameComparison == 0)
			{
				// If last names are the same, compare by first name
				return CompareStrings(x.FirstName, y.FirstName);
			}
			return lastNameComparison;
		}

		/// <summary>
		/// The method compares each character in the two strings one by one, starting from the beginning.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>If a character in the first string is less than the corresponding character 
		/// In the second string, the method returns -1. 
		/// If a character in the first string is greater than the corresponding character 
		/// In the second string, the method returns 1.</returns>
		private int CompareStrings(string a, string b)
		{
			int minLength = Math.Min(a.Length, b.Length);
			for (int i = 0; i < minLength; i++)
			{
				if (a[i] < b[i])
				{
					return -1;
				}
				else if (a[i] > b[i])
				{
					return 1;
				}
			}

			if (a.Length < b.Length)
			{
				return -1;
			}
			else if (a.Length > b.Length)
			{
				return 1;
			}

			return 0;
		}
	}
}
