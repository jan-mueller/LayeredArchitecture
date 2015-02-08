using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitecture.Data.Repository;
using LayeredArchitecture.Data.Repository.Contracts;
using LayeredArchitecture.Logic.PersonManagement;
using LayeredArchitecture.Logic.PersonManagement.Contracts;
using Ninject.Modules;

namespace DependencyInjection
{
	/// <summary>
	/// Implements the Dependency Injection Mappings.
	/// </summary>
	public class Mappings : NinjectModule
	{
		/// <summary>
		/// Loads the module into the kernel.
		/// </summary>
		public override void Load()
		{
			Bind<IPersonRepository>().To<PersonRepository>();
			Bind<IPersonManager>().To<PersonManager>();
		}
	}
}

