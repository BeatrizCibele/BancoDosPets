using BancoDosPets.Context;
using BancoDosPets.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BancoDoente.Models
{

    public class IncluirPet
    {
        private readonly AppDbContext _contexto;

        public IncluirPet(AppDbContext context)
        {
            _contexto = context;
        }

        public void AdicionarPetAoBanco(Pet pet)
        {
            var novoPet = new Pet
            {
                PetId = pet.PetId,
                Nome = pet.Nome,
                Idade = pet.Idade,
                Sexo = pet.Sexo,
                DescricaoCurta = pet.DescricaoCurta,
                DescricaoLonga = pet.DescricaoLonga,
                Categoria = pet.Categoria,
                CategoriaId = pet.PetId
            };
            var petAdicionado = _contexto.Add(novoPet);

            _contexto.SaveChanges();
        }
    }
}


