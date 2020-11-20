using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Voluntarios")]
    public class Voluntario
    {
        public long VoluntarioId { get; set; }
        public string NomeVoluntario { get; set; }
        public Endereco Endereco { get; set; }
    }
}