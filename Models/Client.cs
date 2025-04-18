using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WpfApp1.Models
{
    public partial class Client
    {
        public Client()
        {
            Contract = new HashSet<Contract>();
        }

        public int IdClient { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Passport { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public int IdCard { get; set; }
        public string Articul { get; set; }
        public string FullName => $"{LastName} {FirstName} {Patronymic}";
        public virtual RoomHotel ArticulNavigation { get; set; }
        public virtual BonusCard IdCardNavigation { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
