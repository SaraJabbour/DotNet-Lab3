using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNet_Lab3.Models;

namespace DotNet_Lab3.Data
{
    public class DotNet_Lab3Context : DbContext
    {
        public DotNet_Lab3Context (DbContextOptions<DotNet_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<DotNet_Lab3.Models.Student> Student { get; set; } = default!;
    }
}
