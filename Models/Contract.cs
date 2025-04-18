using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1.Models
{
    public partial class Contract
    {
        public int IdContract { get; set; }
        public DateTime DateContract { get; set; }
        public DateTime? DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public int IdClient { get; set; }
        public long? Cost { get; set; }
        public virtual Client IdClientNavigation { get; set; }
    }
}
