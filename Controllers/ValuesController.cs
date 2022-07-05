using Microsoft.AspNetCore.Mvc;
using SPK.Models;
using SPK.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SPK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;  

        public ValuesController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("Symptoms")]
        public async Task<ApiResponse> GetSymptoms()
        {
            var data = await _context.Symptoms.OrderBy(x => x.SymptomID).ToListAsync();

            return new ApiResponse {  Data = data };
        }
        
        [HttpGet("Diseases")]
        public async Task<ApiResponse> GetDiseases()
        {
            var data = await _context.Diseases.OrderBy(x => x.DiseaseID).ToListAsync();

            return new ApiResponse {  Data = data };
        }
        
        [HttpGet("Solutions")]
        public async Task<ApiResponse> GetSolutions()
        {
            var data = await _context.Solutions.OrderBy(x => x.SolutionID).ToListAsync();

            return new ApiResponse {  Data = data };
        }       
    }
}
