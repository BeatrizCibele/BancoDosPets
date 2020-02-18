using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDosPets.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Digite o nome do pet")]
        [Display(Name = "Nome do pet")]
        public string Nome { get; set; }

        [StringLength(1)]
        [Required(ErrorMessage = "Digite o sexo do pet")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }        
        public int Idade { get; set; }

        [Required(ErrorMessage = "Digite o valor de doação esperado")]
        public decimal ValorEsperado { get; set; }

        //valor que se assemelha a carrinho de compra
        public decimal ValorRecebido { get; set; }

        [StringLength(100)]

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
