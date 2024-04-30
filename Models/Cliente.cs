using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Exemplo_DA.Models
{
    public class Cliente
    {
        
        public int ClienteID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 4, ErrorMessage ="Digite um texto com 4 a 60 caracteres")]
        public string Sobrenome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }

        [ScaffoldColumn(false)]
        public string Endereco { get; set; }

       
       [Display(Name ="Telefone / Whatsapp")]
       [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$", ErrorMessage ="Digite o telefone no formato (xx) 9xxxx-xxxx")]
        /*============ EXPLICAÇÃO DA REGEX =======================*/

        /*
         ^ Início da linha.
         \(?\d{2}\)? : Procura por dois dígitos que podem ou não estar entre parênteses. Isso corresponde ao código de área do telefone.
         [\s-]? : Procura por um espaço em branco ou um hífen. Este é o separador opcional após o código de área.
         [\s9]? : Procura por um espaço em branco ou o número 9. Este é o nono dígito opcional que alguns números de telefone no Brasil possuem.
         \d{4} : Procura por quatro dígitos. Isso corresponde aos primeiros quatro dígitos do número de telefone.
         -? : Procura por um hífen opcional. Este é o separador opcional entre os conjuntos de dígitos do número de telefone.
         \d{4} : Procura por quatro dígitos. Isso corresponde aos últimos quatro dígitos do número de telefone.
         $ : Este é o final da linha.
         */

        public string Telefone { get; set; } 

        [DataType(DataType.EmailAddress, ErrorMessage ="Digite um endereço válido com @")]
        public string Email { get; set; }

        [Compare("Email", ErrorMessage ="A confirmação não corresponde ao e-mail.")]
        public string ConfirmaEmail { get; set; }
        public string Usuario { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
       
    }
}
