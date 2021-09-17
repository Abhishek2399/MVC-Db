using System;
using System.Collections.Generic;

#nullable disable

namespace DALPro.Models
{
    public partial class JobSeeker
    {
        public JobSeeker()
        {
            Academics = new HashSet<Academic>();
        }

        public int JsId { get; set; }
        public string JsName { get; set; }
        public string JsPwd { get; set; }
        public string JsMobile { get; set; }
        public string JsAddress { get; set; }
        public DateTime JsDob { get; set; }
        public int? JsJobId { get; set; }
        public int? JsResumeId { get; set; }
        public string JsEmail { get; set; }

        public virtual Job JsJob { get; set; }
        public virtual Resume JsResume { get; set; }
        public virtual ICollection<Academic> Academics { get; set; }
    }
}
