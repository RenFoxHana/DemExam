using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1.Models
{
    public partial class BonusCard
    {
        public BonusCard()
        {
            Client = new HashSet<Client>();
        }

        public int IdCard { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
