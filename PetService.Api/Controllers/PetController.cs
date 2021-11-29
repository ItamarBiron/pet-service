using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PetService.Api.Controllers
{
    public class PetController : ControllerBase
    {

        public PetController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> getPets()
        {
            return Ok();
        }
        
        
        
    }
}