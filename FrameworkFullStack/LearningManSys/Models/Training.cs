using System;
using System.Collections.Generic;

#nullable disable

namespace LearningManSys.Models
{
    public partial class Training
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public string Faculty { get; set; }
        public string Location { get; set; }
    }
}
