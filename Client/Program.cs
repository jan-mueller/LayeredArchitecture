using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection;
using LayeredArchitecture.Logic.PersonManagement.Contracts;
using Ninject;

namespace Client
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an application kernel that knows about hte dependencies.
			var kernel = new StandardKernel(new Mappings ());

			// Create a PersonManager.
			var manager = kernel.Get<IPersonManager>();

			// Get person collections
			var allAdults = manager.GetAllAdults();
			var allChilds = manager.GetAllChilds();


			// Do some stuff
			Console.WriteLine ("All Adults:");
			foreach (var p in allAdults)
				Console.WriteLine (p.Firstname);

			Console.WriteLine ();

			Console.WriteLine ("All Childs:");
			foreach (var c in allChilds)
				Console.WriteLine (c.Firstname);

			Console.ReadKey();
		}
	}
}
