using BancoDosPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDoente.Repositories
{
    public interface IPetRepository
    {
        IEnumerable<Pet> Pets { get; }

        Pet GetPetById(int petId);
    }
}
