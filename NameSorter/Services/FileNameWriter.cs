using NameSorter.Contracts;
using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Services
{
	// Class to write names to a file
	public class FileNameWriter : INameWriter
	{
		private readonly string _filePath;

		// Constructor to initialize the file path
		public FileNameWriter(string filePath)
		{
			_filePath = filePath;
		}

		/// <summary>
		/// Method to write names to the file
		/// </summary>
		/// <param name="names"></param>
		public void WriteNames(List<Name> names)
		{
			using (StreamWriter writer = new StreamWriter(_filePath))
			{
				foreach (var name in names)
				{
					writer.WriteLine(name.FullName);
				}
			}
		}
	}
}
