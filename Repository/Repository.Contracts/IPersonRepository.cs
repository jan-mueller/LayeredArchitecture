using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.CrossCutting.DataClasses;

namespace LayeredArchitecture.Data.Repository.Contracts
{
	/// <summary>
	/// Implements a interface for the PersonRepository.
	/// </summary>
	public interface IPersonRepository
	{
		/// <summary>
		/// Gets all persons.
		/// </summary>
		/// <returns>A collection of persons.</returns>
		IEnumerable<Person> GetAll();
	}
}
