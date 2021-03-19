using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentCoreApi.Models
{
    public partial class Students
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Sage { get; set; }
        public string Scourse { get; set; }
        public string Semail { get; set; }
        public string Scontact { get; set; }
    }
}
