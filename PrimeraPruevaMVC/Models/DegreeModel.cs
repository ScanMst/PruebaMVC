using System.ComponentModel.DataAnnotations;

namespace PrimeraPruevaMVC.Models
{
    
     public class DegreeModel : BaseModel
    {
        public DegreeModel()
        {
            
        }
        
        [Required(ErrorMessage = "El (0) es un campo requerido")]
        [StringLength(maximumLength:50, MinimumLength = 5, ErrorMessage = "La longitud del campo (0) debe ser minimo entre (2) y maximo (1)") ]
        public string Nombre { get; set; }
        
    }
        

}

