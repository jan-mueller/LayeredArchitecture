using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.CrossCutting.DataClasses;

namespace LayeredArchitecture.Logic.PersonManagement.Contracts
{
	/// <summary>
	/// Implements the interface for PersonManager.
	/// </summary>
	public interface IPersonManager
	{
		/// <summary>
		/// Gets all adults.
		/// </summary>
		/// <returns>A collection of all adults.</returns>
		IEnumerable<Person> GetAllAdults();

		/// <summary>
		/// Gets all childs.
		/// </summary>
		/// <returns>A collection of all childs.</returns>
		IEnumerable<Person> GetAllChilds();
	}
}
