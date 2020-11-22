using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Paróquias")]
    public class Paroquia
    {
        public Paroquia()
        {
            
        }
        [Key]
        public long ParoquiaId { get; set; }

        [Required(ErrorMessage = "O digite o nome da paróquia.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Column("Nome", TypeName = "VARCHAR")]
        public string NomeParoquia { get; set; }

        [MaxLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

    }
}