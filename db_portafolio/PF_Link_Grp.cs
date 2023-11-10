using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_portafolio
{
    public class PF_Link_Grp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Orden {  get; set; }

        [Required]
        public bool Estado { get; set; }

        public virtual ICollection<PF_Link> Links { get; set; }
    }
}
