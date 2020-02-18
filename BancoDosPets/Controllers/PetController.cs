using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoDoente.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BancoDoente.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetRepository _petRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public PetController(ICategoriaRepository categoriaRepository, IPetRepository petRepository)
        {
            _petRepository = petRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            var listaPets = _petRepository.Pets;

            return View(listaPets);
        }
        public IActionResult PetDetalhe(int petId)
        {
            var petSelecionado = _petRepository.Pets.FirstOrDefault(p => p.PetId == petId);

            return View(petSelecionado);
        }
       
    }
}