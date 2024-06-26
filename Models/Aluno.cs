using System.ComponentModel.DataAnnotations;

namespace AcademiaFacil.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MyProperty { get; set; }
    }
}