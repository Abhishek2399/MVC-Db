using System;
using System.Collections.Generic;

#nullable disable

namespace DALPro.Models
{
    public partial class Resume
    {
        public int ResumeId { get; set; }
        public string Title { get; set; }
        public string Skills1 { get; set; }
        public string ContactDetails { get; set; }
        public string Name { get; set; }
        public int? Experience { get; set; }
        public string Organization { get; set; }
        public string Skills2 { get; set; }
        public string Skills3 { get; set; }
        public string Address { get; set; }
        public int? AcademicId { get; set; }
        public string Email { get; set; }

        public virtual Academic Academic { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
