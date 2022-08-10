using System.ComponentModel.DataAnnotations;

namespace InterestCalculationProject.Model
{
    public class InterestModel
    {
       
        [Required(ErrorMessage = "Please enter number")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid number")]
        public double Balance { get; set; }  //Ana para property'si

        
        [Required(ErrorMessage = "Please enter number")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid number")]
        public double InterestRate{ get; set; } // Faiz oranı property'si

        
        [Required(ErrorMessage = "Please enter number")]
        [Range(0, double.MaxValue, ErrorMessage = "please enter a valid value")]
        public double Maturity { get; set; } // Vade property'si
    }
}
