using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FiapDevOps.Models;

namespace FiapDevOps.Data
{
    public class FiapDevOpsContext : DbContext
    {
        public FiapDevOpsContext (DbContextOptions<FiapDevOpsContext> options)
            : base(options)
        {
        }

        public DbSet<FiapDevOps.Models.TB_ALUNO> AlunoViewModel { get; set; }
    }
}
