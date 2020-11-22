using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public long EnderecoId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "VARCHAR")]
        public string Rua { get; set; }

        [RegularExpression(@"^[0-9]$")]
        [MaxLength(5)]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "O número não pode ser menor que 2")]
        [Column(TypeName = "VARCHAR")]
        public string Numero { get; set; }

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Cep Incompleto")]
        [DataType(DataType.PostalCode)]
        [DisplayFormat(DataFormatString = "99999-999", ApplyFormatInEditMode = true)]
        [Column(TypeName = "VARCHAR")]
        public string Cep { get; set; }

        [Column(TypeName = "VARCHAR")]
        [RegularExpression(@"^[a-zA-Z0-9 '' - '\ s] * $", ErrorMessage = "Caracteres espciais não são aceitos")]
        public string Bairro { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9 '' - '\ s] + $", ErrorMessage = "Caracteres espciais não são aceitos")]
        [Column(TypeName = "VARCHAR")]
        public string Cidade { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string Estado { get; set; }
    }
}