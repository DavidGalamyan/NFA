using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFA.Persistence
{
	public class DbInitializer
	{
		public static void Initialize(NfaDbContext context)
		{
			context.Database.EnsureCreated();
		}
	}
}
