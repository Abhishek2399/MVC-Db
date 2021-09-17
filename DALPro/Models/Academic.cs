using System;
using System.Collections.Generic;

#nullable disable

namespace DALPro.Models
{
    public partial class Academic
    {
        public Academic()
        {
            Resumes = new HashSet<Resume>();
        }

        public int AcademicsId { get; set; }
        public string AcademicsName { get; set; }
        public double Percentage { get; set; }
        public string Yop { get; set; }
        public int JsId { get; set; }

        public virtual JobSeeker Js { get; set; }
        public virtual ICollection<Resume> Resumes { get; set; }
    }
}
