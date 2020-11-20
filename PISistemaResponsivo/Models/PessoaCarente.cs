using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Models
{
    [Table("Pessoas Carentes")]
    public class PessoaCarente
    {
        public PessoaCarente()
        {
            Endereco = new Endereco();
        }
        [Key]
        public long CarenteId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        [Column("Nome", TypeName = "VARCHAR")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo genero é obrigatório.")]
        [Column(TypeName = "VARCHAR")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatorio")]
        [RegularExpression(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$", ErrorMessage = "Somente números no campo CPF")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "O digite o cpf Completo.")]
        [Column("CPF", TypeName = "VARCHAR")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "A data de nascimento não poder ser em branco.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtNascimento { get; set; }

        [Column (TypeName = "VARCHAR")]
        [Display(Name = "Estado Cívil")]
        public string EstadoCivil { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$", ErrorMessage = "Preenchimento Invalido")]
        [Column(TypeName = "VARCHAR")]
        public string Telefone { get; set; }

        [Required(ErrorMessage ="O campo Religião é obrigatório.")]
        [MaxLength(20)]
        [RegularExpression(@"^[a-zA-Z '' - '\ s] * $", ErrorMessage = "Digite somente letras")]
        public string Religiao { get; set; }
        public Endereco Endereco { get; set; }

        [Display(Name = "Renda Familiar")]
        [DisplayFormat(DataFormatString = "{0,c}", ApplyFormatInEditMode = true)]
        public decimal RendaFamiliar { get; set; }

    }
}