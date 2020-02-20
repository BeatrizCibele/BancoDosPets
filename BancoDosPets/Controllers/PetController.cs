using BancoDoente.Repositories;
using BancoDosPets.Context;
using BancoDosPets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BancoDoente.Controllers
{
    public class PetController : Controller
    {
        private readonly AppDbContext _contexto;
        private readonly IPetRepository _petRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public PetController(ICategoriaRepository categoriaRepository, IPetRepository petRepository, AppDbContext context)
        {
            _contexto = context;
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
        public IActionResult EditPet(int petId)
        {
            var editPet = _petRepository.Pets.FirstOrDefault(p => p.PetId == petId);
            return View(editPet);
            
        }
        [HttpGet]
        public IActionResult AdicionarPetAobanco()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult AdicionarPetAoBanco(Pet pet)
        {
            var novoPet = new Pet
            {
                Nome = pet.Nome,
                Idade = pet.Idade,
                Sexo = pet.Sexo,
                DescricaoCurta = pet.DescricaoCurta,
                DescricaoLonga = pet.DescricaoLonga,
                Categoria = pet.Categoria
                
            };
            var petAdicionado = _contexto.Add(novoPet);

            _contexto.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}