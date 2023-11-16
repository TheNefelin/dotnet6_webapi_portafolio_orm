using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_portafolio
{
    public class PF_Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string url_img { get; set; }

        [Required]
        public int orden { get; set; }

        public virtual ICollection<PF_Pro_Sour> ProjectSources { get; set; }
        public virtual ICollection<PF_Pro_Lang> ProjectLanguage { get; set; }
        public virtual ICollection<PF_Pro_Tech> ProjectTechnology { get; set; }
    }
}
