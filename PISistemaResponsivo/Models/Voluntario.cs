using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Voluntarios")]
    public class Voluntario
    {
        public Voluntario()
        {
            
        }
        [Key]
        public long VoluntarioId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Column("Nome", TypeName = "VARCHAR")]
        public string NomeVoluntario { get; set; }

        [MaxLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}