using System;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.DAL.Entities
{
	public class AppRole:IdentityRole<int>
	{
		public AppRole()
		{
		}
	}
}

