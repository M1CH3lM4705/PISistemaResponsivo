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
        public string Rua { get; set; }
        public int Numero { get; set; }

        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Cep Incompleto")]
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}