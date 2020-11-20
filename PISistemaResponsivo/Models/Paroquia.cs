using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Paroquias")]
    public class Paroquia
    {

        public long ParoquiaId { get; set; }
        public string NomeParoquia { get; set; }
        public Endereco Endereco { get; set; }

    }
}