using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq;

namespace PORFAVORFUNCIONA3.Models
{
    public class Cliente {
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter no mínimo 2 letras")]
        [Required(ErrorMessage = "O preenchimento do nome é obrigatório")]
        public string Nome_client { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        public string CPF_client { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório" )]
        public string DataDN_client{ get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Email_client { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        public Int64 Tel_client { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Endereco_client { get; set; }


    }
}