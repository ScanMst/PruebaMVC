using System;
namespace PrimeraPruevaMVC.Models
{
    
    public class StudentModel : EntityModel
    {
        public StudentModel()
        {
          
        }
        public int Matricula { get; set;}
        public string Nombre { get; set;}
        public string Carrera{ get; set;}
        public int Edad { get; set;}
        public string Sexo { get; set;}

    }

}



