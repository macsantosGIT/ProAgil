using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class EventoDto
    {
        public int Id{get;set;}

        [Required (ErrorMessage="O Campo {0} é obrigatório")]
        [StringLength (100, MinimumLength=3, ErrorMessage="O Local deve ter entre 3 e 100 caracteres")]
        public string Local{get;set;}
        public string DataEvento{get;set;}
        
        [Required (ErrorMessage="O Tema deve ser preenchido")]
        public string Tema{get;set;} 
        
        [Range(2, 9999, ErrorMessage="A Quantidade de pessoas deve ser entre 2 e 9999")]
        public int QtdPessoas{get;set;}

        [Required (ErrorMessage="A URL da Imagem deve ser preenchida")]
        public string ImagemURL{get;set;}

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public List<LoteDto> Lotes {get;set;}    
        public List<RedeSocialDto> RedeSociais { get; set; }
        public List<PalestranteDto> Palestrantes { get; set; }
        
    }
}