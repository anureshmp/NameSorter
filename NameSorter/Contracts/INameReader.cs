using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NameSorter.Contracts
{
	/// <summary>
	/// Interface for reading names
	/// </summary>
	public interface INameReader
	{
		List<Name> ReadNames();
	}
}
