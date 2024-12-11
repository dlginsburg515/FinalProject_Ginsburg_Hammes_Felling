using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProject_DG_CH_BF.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Email { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }

        public int PetID { get; set; }

        public DateOnly BirthDay { get; set; }

        public string NameOfVet { get; set; }

        public Boolean HasChildren { get; set; }

        public Boolean HasDogs { get; set; }

        public Boolean HasCats { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Address { get; set; }

        public string AdditionalInfo { get; set; }

    }
}
