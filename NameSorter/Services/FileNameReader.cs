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
	/// // Class to read names from a file
	/// </summary>
	public class FileNameReader : INameReader
	{
		private readonly string _filePath;

		// Constructor to initialize the file path
		public FileNameReader(string filePath)
		{
			_filePath = filePath;
		}

		/// <summary>
		/// Method to read names from the file
		/// </summary>
		/// <returns>List of names read from the input file</returns>
		public List<Name> ReadNames()
		{
			var names = new List<Name>();
			foreach (var line in File.ReadAllLines(_filePath))
			{
				names.Add(new Name(line));
			}
			return names;
		}
	}
}
