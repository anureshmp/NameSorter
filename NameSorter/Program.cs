using System;
using System.Collections.Generic;
using System.IO;
using NameSorter.Models;
using NameSorter.Contracts;
using NameSorter.Services;
using System.Text.RegularExpressions;

namespace NameSorter
{
	class Program
	{
		static void Main()
		{
			//Main loop to process input file till the user selects 'N'
			do
			{
				Console.WriteLine("Please enter the input file path:");
				string? inputFilePath = Console.ReadLine();

				//Check if the file exists. If not then user will be asked whether he wants to continue or not
				if (!File.Exists(inputFilePath))
				{
					Console.WriteLine("File not found. Please ensure the file path is correct.");
					if (!AskToContinue()) break;
					continue;
				}

				//Read the input file path
				string inputDirectory = Path.GetDirectoryName(inputFilePath);
				//Build output file path which is same as the working directory
				string outputFilePath = Path.Combine(inputDirectory, "sorted-names-list.txt");

				//Newing up reader, sorter and writer
				INameReader nameReader = new FileNameReader(inputFilePath);
				INameSorter nameSorter = new FullNameSorter();
				INameWriter nameWriter = new FileNameWriter(outputFilePath);

				//Read, sort and write names
				List<Name> names = nameReader.ReadNames();
				nameSorter.Sort(names);
				nameWriter.WriteNames(names);

				//Print the sorted names to the console
				foreach(Name name in names)
				{
					Console.WriteLine(name.FullName);
				}

				//After output is printed, user is asked if he wants to continue or not
				if (!AskToContinue()) break;
				
			} while (true);

			Console.WriteLine("Exiting program..have a good one!!");
		}

		/// <summary>
		/// Method to ask the user if they want to continue
		/// </summary>
		/// <returns>User preference in terms of a boolean value</returns>
		static bool AskToContinue()
		{
			Console.WriteLine("Do you want to process another file? (Y/N)");
			return Console.ReadLine().Trim().ToUpper() == "Y";
		}
	}









	




}
