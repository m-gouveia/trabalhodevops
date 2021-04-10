using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FIapDevOps.Models
{
    [Table("TB_ALUNO")] // tblOrders table in App namespace
    public class TB_ALUNO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("NOM_ALUNO")]
        public string NOM_ALUNO { get; set; }

        [Column("NUM_RA")]
        public int NUM_RA { get; set; }
    }
}

