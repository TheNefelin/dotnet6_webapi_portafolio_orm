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
        public int Id { get; set; }

        [Required]
        public string Nombre {  get; set; }

        [Required]
        public string Url {  get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int Id_Link_Grp { get; set; }

        [ForeignKey("Id_Link_Grp")]
        public virtual PF_Link_Grp LinksGrp { get; set; }
    }
}
