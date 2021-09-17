using System;
using System.Collections.Generic;

#nullable disable

namespace DALPro.Models
{
    public partial class Job
    {
        public Job()
        {
            JobSeekers = new HashSet<JobSeeker>();
        }

        public int JobId { get; set; }
        public string JobCategory { get; set; }
        public string JobDesignation { get; set; }
        public string JobLocation { get; set; }
        public int Experience { get; set; }
        public int? CurrentOpenings { get; set; }
        public int? EmployerId { get; set; }

        public virtual ICollection<JobSeeker> JobSeekers { get; set; }
    }
}
