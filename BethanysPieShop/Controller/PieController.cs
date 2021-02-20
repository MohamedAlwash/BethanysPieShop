using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controller
{
    public class PieController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese cakes";
            return view(piesListViewModel);
        }
    }
}