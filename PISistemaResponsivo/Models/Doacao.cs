using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Doacoes")]
    public class Doacao
    {
        public long DoacaoId { get; set; }
        public PessoaCarente PessoaCarente { get; set; }
        public Voluntario Voluntario { get; set; }
        public Paroquia Paroquia { get; set; }
        public DateTime DataEntrega { get; set; }
        public string TipoDoacao { get; set; }
        public string MotivoDoacao { get; set; }
    }
}