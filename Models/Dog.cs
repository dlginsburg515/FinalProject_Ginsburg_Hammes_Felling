using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject_DG_CH_BF.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public DateOnly DateArrived { get; set; }
        public double Weight { get; set; }
        public double Height {  get; set; }
        public string Color { get; set; }
        public string Breed {  get; set; }
        public string Gender { get; set; }
        public int Age {  get; set; }
        public string Description { get; set; }
        public string HealthStatus { get; set; }
        public Boolean GoodWithKids { get; set; }
        public Boolean GoodWithDogs { get; set; }
        public Boolean GoodWithCats { get; set; }

    }
}
