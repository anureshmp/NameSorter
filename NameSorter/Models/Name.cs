using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Models
{
	/// <summary>
	/// Class to represent a Name
	/// </summary>
	public class Name
	{
		public string FullName { get; } // Full name of the person
		public string LastName { get; } // Last name of the person
		public string FirstName { get; } // First name of the person

		// Constructor to initialize the Name object
		public Name(string fullName)
		{
			FullName = fullName;
			var nameParts = fullName.Split(' ');
			LastName = nameParts[nameParts.Length - 1];
			FirstName = nameParts[0];
		}
	}
}
