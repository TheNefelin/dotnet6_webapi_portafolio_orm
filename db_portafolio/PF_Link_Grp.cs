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
        public int id {  get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        public bool estado { get; set; }

        public virtual ICollection<PF_Link> Links { get; set; }
    }
}
