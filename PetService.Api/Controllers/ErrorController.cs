using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace PetService.Api.Controllers
{
    // make it impossible to reach this controller directly from api
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult GlobalErrorHandler([FromServices] IWebHostEnvironment webHostEnvironment)
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            if (context == null) return Problem();

            int code;

            var error = context.Error;

            if (error is KeyNotFoundException)
            {
                code = (int) HttpStatusCode.NotFound;
            }
            else
            {
                code = (int) HttpStatusCode.InternalServerError;
            }

            if (webHostEnvironment.IsDevelopment())
            {
                return StatusCode(
                    code,
                    new
                    {
                        title = context.Error?.Message,
                        detail = context.Error?.StackTrace
                    });
            }

            return StatusCode(code, new {title = context.Error?.Message});
        }
        
        
        
    }
}
