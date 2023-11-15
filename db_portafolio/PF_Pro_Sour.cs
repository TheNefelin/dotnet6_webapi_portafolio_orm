using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_portafolio
{
    public class PF_Pro_Sour
    {
        [Key, Column(Order = 0)]
        public int id_project { get; set; }

        [Key, Column(Order = 1)]
        public int id_source { get; set; }


        [ForeignKey("id_project")]
        public virtual PF_Project Project { get; set; }

        [ForeignKey("id_source")]
        public virtual PF_Source Source { get; set; }
    }
}
