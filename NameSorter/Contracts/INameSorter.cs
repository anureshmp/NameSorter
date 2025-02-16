using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Contracts
{
	/// <summary>
	/// Interface for sorting names
	/// </summary>
	public interface INameSorter
	{
		void Sort(List<Name> names);
	}
}
