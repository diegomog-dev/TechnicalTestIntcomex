using Application.Repository;
using Application.Repository.IRepository;
using Domain.Models;
using Domain.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ResponseCache(CacheProfileName = "Default30")]
    public class SubcategoryController : ControllerBase
    {
        private readonly ISubcategoryRepository _subcategoryRepository;
        protected APIResponse _response;

        public SubcategoryController(ISubcategoryRepository subcategoryRepository)
        {
            _subcategoryRepository = subcategoryRepository;
            _response = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetSubcategories()
        {
            try
            {
                IEnumerable<Subcategory> subcategories = await _subcategoryRepository.GetAll();
                _response.Result = subcategories;
                _response.StatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.Message };
            }

            return _response;
        }
    }
}
