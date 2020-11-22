using PISistemaResponsivo.Infraestrutura.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Doacoes")]
    public class Doacao
    {
        public Doacao()
        {
            DataEntrega = DateTime.Now;
        }
        [Key]
        public long DoacaoId { get; set; }
        public PessoaCarente PessoaCarente { get; set; }
        public Voluntario Voluntario { get; set; }
        public Paroquia Paroquia { get; set; }

        
        [Display(Name = "Data da Entrega")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column("Data de Entrega")]
        public DateTime DataEntrega { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Doação é obrigatório.")]
        [MaxLength(100)]
        [Column("Tipo de doacao", TypeName = "VARCHAR")]
        public string TipoDoacao { get; set; }

        [Required(ErrorMessage = "O campo motivo da doação é obrigatório.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Motivo da Doação")]
        [Column(TypeName = "VARCHAR")]
        public string MotivoDoacao { get; set; }

        public int CalcularDias(int id)
        {
            DateTime dtAtual = DateTime.Now;
            DoacaoDao objDoacao = new DoacaoDao();
            var dtEntrega = objDoacao.Buscar(id);
            
            TimeSpan dataEmDias = dtAtual - dtEntrega.DataEntrega;

            int totalDias = dataEmDias.Days;

            return totalDias;
        }
    }
}