using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PORFAVORFUNCIONA3.Models
{
    public class Jogo
    {
        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public int Cod_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string Nome_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo é obrigatório")]
        public string Versao_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo desenvolvedor é obrigatório")]
        public string Dev_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo gênero é obrigatório")]
        public string Genero_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo faixa etaria é obrigatório")]
        public string FaixaEtaria_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo plataforma é obrigatório")]
        public string Plataforma_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo ano de lançamento é obrigatório")]
        public int AnodeLanc_jogo { get; set; }

        [Required(ErrorMessage = "O preenchimento do campo sinopse é obrigatório")]
        public string Sinopse_jogo { get; set; }
    }
}