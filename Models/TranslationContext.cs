using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication.Models
{
    public class TranslationContext : DbContext
    {
        public TranslationContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Translation> Translations { get; set; }
    }
}