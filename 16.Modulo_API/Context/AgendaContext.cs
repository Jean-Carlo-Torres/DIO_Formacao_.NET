using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _16.Modulo_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace _16.Modulo_API.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options): base(options){

        }

        public DbSet<Contato> Contatos{ get; set; }
    }
}