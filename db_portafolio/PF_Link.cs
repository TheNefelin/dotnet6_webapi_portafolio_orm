using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_portafolio
{
    public class PF_Link
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre {  get; set; }

        [Required]
        [StringLength(255)]
        public string url_link {  get; set; }

        [Required]
        public bool estado { get; set; }

        [Required]
        public int id_link_grp { get; set; }

        [ForeignKey("id_link_grp")]
        public virtual PF_Link_Grp LinkGrp { get; set; }
    }
}
