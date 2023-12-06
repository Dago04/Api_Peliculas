using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CrearCategoriaDto
    {
       
        //validacion importante sino se crea vacio
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage ="El número maximo de caracteres es de 100!")]
        public string Nombre { get; set; }
        
    }
}
