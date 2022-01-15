using BethanysPieShopHRM.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        readonly IJobCategoryRepository jobCategoryRepository;

        public JobCategoryController(IJobCategoryRepository jobCategoryRepository)
        {
            this.jobCategoryRepository = jobCategoryRepository;
        }

        // GET: api/<JobCategoryController>
        [HttpGet]
        public IActionResult GetAllJobCategories()
        {
            return Ok(jobCategoryRepository.GetAllJobCategories());
        }

        // GET api/<JobCategoryController>/5
        [HttpGet("{id}")]
        public IActionResult GetJobCategoryById(int jobCategoryId)
        {
            return Ok(jobCategoryRepository.GetJobCategoryById(jobCategoryId));
        }
    }
}
