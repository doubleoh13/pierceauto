using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PierceAuto;
internal class DbContext(DbContextOptions<DbContext> options): Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Models.Product> Products { get; set; }
}
