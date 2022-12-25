using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL.Entities;

namespace WebApplication1.DAL
{
	public class Context:IdentityDbContext<AppUser,AppRole,int>
	{
		public Context()
		{
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:127.0.0.1,1433;Database=TemplateDesign;MultipleActiveResultSets=true;User=SA;Password=MyPass@word;");
        }

    }
}

