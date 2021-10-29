using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }

        [StringLength(50)]
        public string WriteFirstName { get; set; }
        
        [StringLength(50)]
        public string WriteLastName { get; set; }
        
        [StringLength(100)]
        public string WriteImage { get; set; }
        
        [StringLength(50)]
        public string WriteMail { get; set; }
        
        [StringLength(25)]
        public string WritePassword { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }



    }
}
