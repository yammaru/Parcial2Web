using System;
using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class CreditoContext : DbContext
    {
        public CreditoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Credito> creditos { get; set; }
    }
}
