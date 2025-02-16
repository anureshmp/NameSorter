using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Contracts
{
	/// <summary>
	/// Interface for writing names
	/// </summary>
	public interface INameWriter
	{
		void WriteNames(List<Name> names);
	}
}
