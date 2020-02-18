using BancoDosPets.Models;
using System.ComponentModel.DataAnnotations;
namespace BancoDoente.Models
{
    public class IncluirPet
    {
        public int PetId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Digite o nome do pet")]
        [Display(Name = "Nome do pet")]
        public string Nome { get; set; }        
        
        
        [Display(Name = "Sexo")]
        public bool Sexo { get; set; }
        public int Idade { get; set; }

        [Required(ErrorMessage = "Digite o valor de doação esperado")]
        public decimal ValorEsperado { get; set; }
        
        public decimal ValorRecebido { get; set; }

        [StringLength(100)]

        [Required(ErrorMessage ="Esse campo deve ser preenchido")]
        public string DescricaoCurta { get; set; }

        [StringLength(200)]
        public string DescricaoLonga { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemThumbnail { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
    

