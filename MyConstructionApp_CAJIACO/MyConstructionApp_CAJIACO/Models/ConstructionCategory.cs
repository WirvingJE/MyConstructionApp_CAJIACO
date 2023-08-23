using System;
using System.Collections.Generic;
using System.Text;

namespace MyConstructionApp_CAJIACO.Models
{
    public  class ConstructionCategory
    {
        public ConstructionCategory()
        {
           // Constructions = new HashSet<Construction>();
        }

        public int ConstructionCategory1 { get; set; }
        public string Description { get; set; } = null!;
        public int UserId { get; set; }

        //public virtual User? User { get; set; } = null!;
       // public virtual ICollection<Construction>? Constructions { get; set; }


    }
}
