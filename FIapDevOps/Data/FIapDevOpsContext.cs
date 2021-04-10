using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FIapDevOps.Models;

namespace FIapDevOps.Data
{
    public class FIapDevOpsContext : DbContext
    {
        public FIapDevOpsContext (DbContextOptions<FIapDevOpsContext> options)
            : base(options)
        {
        }

        public DbSet<FIapDevOps.Models.TB_ALUNO> AlunoViewModel { get; set; }
    }
}
