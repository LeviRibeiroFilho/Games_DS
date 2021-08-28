using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PORFAVORFUNCIONA3.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public int Cod_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string Nome_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string CPF_func{ get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string RG_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string DataDN_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string Endereco_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public int Tel_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string Email_func { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string Cargo_func { get; set; }

    }
}