using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class PalestranteDto
    {
        public int Id { get; set; }

        [Required (ErrorMessage="O Nome deve ser preenchido")]
        public string Nome { get; set; }

        [Required (ErrorMessage="O Mini Curriculo deve ser preenchido")]
        public string MiniCurriculo { get; set; }

        [Required (ErrorMessage="A URL da Imagem deve ser preenchida")]
        public string ImagemURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<RedeSocialDto> RedeSociais { get; set; }
        public List<EventoDto> Eventos { get; set; }

    }
}