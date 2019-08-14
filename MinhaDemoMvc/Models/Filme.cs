using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres!")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto!")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatório!")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido!")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "O campo gênero é requerido!")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Informar um valor de R$ 1 a R$ 1000")]
        [Required(ErrorMessage = "Preencha o campo valor!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números de 1 a 5!")]
        [Required(ErrorMessage = "Preencha o campo de avaliação!")]
        [Display(Name ="Avaliação")]
        public int Avaliacao { get; set; }

    }
}
