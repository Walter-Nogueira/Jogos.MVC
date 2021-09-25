using Jogos.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogos.MVC
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options) { }
        public DbSet <Jogo> Jogos { get; set; }

    }
}
