using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.CrossCutting.DataClasses;
using LayeredArchitecture.Data.Repository.Contracts;
using LayeredArchitecture.Logic.PersonManagement.Contracts;

namespace LayeredArchitecture.Logic.PersonManagement
{
	/// <summary>
	/// Implements the PersonManager.
	/// </summary>
	public class PersonManager : IPersonManager
	{
		/// <summary>
		/// The repo.
		/// </summary>
		public IPersonRepository _repo;

		/// <summary>
		/// Initializes a new instance of the <see cref="LayeredArchitecture.Logic.PersonManagement.PersonManager"/> class.
		/// </summary>
		/// <param name="repo">The person repo.</param>
		public PersonManager(IPersonRepository repo)
		{
			_repo = repo;
		}

		/// <summary>
		/// Implements GetAllAdults.
		/// </summary>
		/// <returns>A collection of all adults.</returns>
		public IEnumerable<Person> GetAllAdults()
		{
			var data = _repo.GetAll().Where(p => p.Age >= 18);
			return data;
		} 

		/// <summary>
		/// Implements GetAllChilds.
		/// </summary>
		/// <returns>A collection of all childs.</returns>
		public IEnumerable<Person> GetAllChilds()
		{
			var data = _repo.GetAll().Where(p => p.Age < 18);
			return data;
		} 
	}
}