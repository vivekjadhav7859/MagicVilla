using MagicVilla.Data;
using MagicVilla.Models;
using MagicVilla.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.Controllers
{
    [Route("api/villaAPI")]
    [ApiController]
    public class villaAPIController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<villaDTO>> GetVillas()
        {
            return Ok(villaStore.villaList);

        }
        [HttpGet("{id:int}")]
        //[ProducesResponseType(200, Type = typeof(villaDTO))]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(404)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = villaStore.villaList.FirstOrDefault(e => e.Id == id);
            if (villa == null) {
                return NotFound();
            }
            return Ok(villa);

        }
    }
}
