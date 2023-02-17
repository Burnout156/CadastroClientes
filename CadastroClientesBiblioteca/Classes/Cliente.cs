using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroClientesBiblioteca.Classes
{
    public class Cliente
    {

        [Key]
        [MaxLength(14)]
        [Column(TypeName = "nvarchar(14)")]
        [Display(Name = "CPF")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "nvarchar(200)")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [MaxLength(1)]
        [Column(TypeName = "varchar(1)")]
        public string Sexo { get; set; }

        [MaxLength(2)]
        [Column(TypeName = "varchar(2)")]
        public string Estado { get; set; }

        [MaxLength(2)]
        [Column(TypeName = "varchar(2)")]
        public string Cidade { get; set; }
    }
}
