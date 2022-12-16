using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAula.Models;
using Microsoft.EntityFrameworkCore;

namespace apiAula.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Ennderecos { get; set; }
        
    }
}