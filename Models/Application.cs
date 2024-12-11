using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProject_DG_CH_BF.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PetID { get; set; }

        public DateOnly BirthDay { get; set; }

        public string NameOfVet { get; set; }

        public Boolean HasChildren { get; set; }

        public Boolean HasDogs { get; set; }

        public Boolean HasCats { get; set; }

        public string Address { get; set; }

        public string AdditionalInfo { get; set; }

    }
}
