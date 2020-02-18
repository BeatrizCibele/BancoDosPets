using BancoDosPets.Context;
using BancoDosPets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancoDoente.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _contexto;

        public CategoriaRepository(AppDbContext context)
        {
            _contexto = context;
        }

        public IEnumerable<Categoria> Categorias => _contexto.Categorias;

       
    }
}
