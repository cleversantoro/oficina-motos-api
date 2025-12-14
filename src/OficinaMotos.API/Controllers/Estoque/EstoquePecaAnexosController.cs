using Microsoft.AspNetCore.Mvc;
using OficinaMotos.Application.DTOs.Requests.Estoque;
using OficinaMotos.Application.DTOs.Responses.Estoque;
using OficinaMotos.Application.Interfaces.Estoque;

namespace OficinaMotos.API.Controllers.Estoque
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EstoquePecaAnexosController : ControllerBase
    {
        private readonly IEstoquePecaAnexoService _service;

        public EstoquePecaAnexosController(IEstoquePecaAnexoService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<EstoquePecaAnexoResponseDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EstoquePecaAnexoResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(long id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null) return NotFound(new { message = "Anexo não encontrado." });
            return Ok(item);
        }

        [HttpPost]
        [ProducesResponseType(typeof(EstoquePecaAnexoResponseDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateEstoquePecaAnexoDTO request)
        {
            try
            {
                var created = await _service.CreateAsync(request);
                return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(EstoquePecaAnexoResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(long id, [FromBody] UpdateEstoquePecaAnexoDTO request)
        {
            try
            {
                var updated = await _service.UpdateAsync(id, request);
                if (updated == null) return NotFound(new { message = "Anexo não encontrado." });
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(long id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound(new { message = "Anexo não encontrado." });
            return NoContent();
        }
    }
}
