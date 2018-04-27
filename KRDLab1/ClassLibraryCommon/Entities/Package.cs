using ClassLibraryCommon.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibraryCommon.Entities
{
    public class Package : BaseEntity 
    {
        //public int Number { get; set; } // zamienione na Id 
        [Required]
        public PakageStatus Status { get; set; }
        [Required]
        public DateTime Hour { get; set; }
        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
