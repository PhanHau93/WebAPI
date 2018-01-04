
using AppGes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGes
{
    public class Context : DbContext
    {
        public DbSet<ClientItem> Clients { get; set; }
        public DbSet<EmployeeItem> Employes { get; set; }
       // public DbSet<ProviderItem> Providers { get; set; }
        public DbSet<TrabajoItem> Trabajos { get; set; }

    }

    public static class Entity {
        public static void ReloadEntity<TEntity>(
        this DbContext context,
        TEntity entity)
        where TEntity : class
        {
            context.Entry(entity).Reload();
        }
    }
}
