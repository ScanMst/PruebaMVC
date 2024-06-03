namespace PrimeraPruevaMVC.Models
{
    public class TeacherModel : EntityModel
    {
        public TeacherModel()
        {

        }

        public string Nombre { get; set; }
        public string Apellidos { get; set;}
        public string Titulo { get; set; }
        public string GradoEstudios { get; set; }
        public decimal Salario { get; set; }
       
    }
}