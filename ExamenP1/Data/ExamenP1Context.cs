using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenP1.Models;

namespace ExamenP1.Data
{
    public class ExamenP1Context : DbContext
    {
        public ExamenP1Context (DbContextOptions<ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<ExamenP1.Models.Persona> Persona { get; set; } = default!;
        public DbSet<ExamenP1.Models.Carrera> Carrera { get; set; } = default!;
    }
}
