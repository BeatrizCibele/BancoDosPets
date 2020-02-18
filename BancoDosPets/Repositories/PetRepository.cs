using BancoDosPets.Context;
using BancoDosPets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDoente.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly AppDbContext _contexto;

        public PetRepository(AppDbContext context)
        {
            _contexto = context;
        }
       public  IEnumerable<Pet> Pets => _contexto.Pets.Include(c => c.Categoria);



        public Pet GetPetById(int petId)
        {
            return _contexto.Pets.FirstOrDefault(p => p.PetId == petId);
        }
    }
}
