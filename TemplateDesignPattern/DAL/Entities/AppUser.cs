using System;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.DAL.Entities
{
	public class AppUser:IdentityUser<int>
	{
		public AppUser()
		{
		}

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
	}
}

