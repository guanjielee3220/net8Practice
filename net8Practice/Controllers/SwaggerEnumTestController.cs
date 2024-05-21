using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net8Practice.Enums;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace net8Practice.Controllers
{
    /// <summary>
    /// Swagger Test
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SwaggerEnumTestController : ControllerBase
    {
        /// <summary>
        /// swaagger enum test
        /// </summary>
        /// <param name="color">color enum</param>
        /// <returns></returns>       
        [HttpGet("color/{color}")]
        public IActionResult Get([Required] SwaggerEnumTest color = SwaggerEnumTest.red)
        {
            return Ok(color);
        }

    }
}
