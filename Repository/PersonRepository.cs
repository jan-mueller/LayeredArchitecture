using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.CrossCutting.DataClasses;
using LayeredArchitecture.Data.Repository.Contracts;

namespace LayeredArchitecture.Data.Repository
{
	/// <summary>
	/// Implements the Person Repository.
	/// </summary>
	public class PersonRepository : IPersonRepository
	{
		/// <summary>
		/// Implements GetAll.
		/// </summary>
		/// <returns>Returns a collection of persons.</returns>
		public IEnumerable<Person> GetAll()
		{
			return new[]
			{
				new Person {Firstname = "Jan", Age = 28},
				new Person {Firstname = "Maximilian", Age = 2},
				new Person {Firstname = "Hans", Age = 56},
				new Person {Firstname = "Georg", Age = 35},
				new Person {Firstname = "Franz", Age = 7},
				new Person {Firstname = "Stefan", Age = 3}
			};
		}
	}
}