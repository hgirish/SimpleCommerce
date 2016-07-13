using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleCommerce.Core.ApplicationServices;
using SimpleCommerce.Core.Domain.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata;
using SimpleCommerce.Infrastructure.Domain.Models;

namespace SimpleCommerce.Core.Infrastructure.EntityFramework
{
    public class SimpleDbContext : IdentityDbContext<User, Role, long> 
    {
        public SimpleDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            List<Type> typeToRegisters = new List<Type>();
            foreach (var module in GlobalConfiguration.Modules)
            {
                var assembly = Assembly.Load(new AssemblyName(module.AssemblyName));
                typeToRegisters.AddRange(assembly.DefinedTypes
                    .Select(t => t.AsType()));
            }
            RegisterEntities(builder, typeToRegisters);

            //builder.Entity<IdentityUserLogin<long>>();
             base.OnModelCreating(builder);

            builder.Entity<UserAddress>()
                .HasOne(x => x.User)
                .WithMany(a => a.UserAddresses)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void RegisterEntities(ModelBuilder modelBuilder, List<Type> typeToRegisters)
        {
            var entityTypes =
                typeToRegisters.Where(x => x.GetTypeInfo()
                .IsSubclassOf(typeof(Entity)) && 
                !x.GetTypeInfo().IsAbstract);
            foreach (var type in entityTypes)
            {
                modelBuilder.Entity(type);
            }
        }
    }
}