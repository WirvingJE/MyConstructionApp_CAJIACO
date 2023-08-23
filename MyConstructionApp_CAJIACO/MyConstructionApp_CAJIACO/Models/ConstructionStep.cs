using System;
using System.Collections.Generic;
using System.Text;

namespace MyConstructionApp_CAJIACO.Models
{
    public class ConstructionStep
    {
        public int ConstructionStepsId { get; set; }
        public string Step { get; set; } = null!;
        public string? Description { get; set; }
        public int UserId { get; set; }


    }
}
