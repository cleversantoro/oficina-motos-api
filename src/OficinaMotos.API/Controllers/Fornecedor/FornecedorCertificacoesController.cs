using Microsoft.AspNetCore.Mvc;
using OficinaMotos.Application.DTOs.Requests.Fornecedor;
using OficinaMotos.Application.DTOs.Responses.Fornecedor;
using OficinaMotos.Application.Interfaces.Fornecedor;

namespace OficinaMotos.API.Controllers.Fornecedor
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FornecedorCertificacoesController : ControllerBase
    {
        private readonly IFornecedorCertificacaoService _service;

        public FornecedorCertificacoesController(IFornecedorCertificacaoService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<FornecedorCertificacaoResponseDTO>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(FornecedorCertificacaoResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(long id)
        {
            var item = await _service.GetByIdAsync(id);
            if (item == null) return NotFound(new { message = "Certificação não encontrada." });
            return Ok(item);
        }

        [HttpPost]
        [ProducesResponseType(typeof(FornecedorCertificacaoResponseDTO), StatusCodes.Status201Created)]
        public async Task<IActionResult> Create([FromBody] CreateFornecedorCertificacaoDTO request)
        {
            var created = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(FornecedorCertificacaoResponseDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update(long id, [FromBody] UpdateFornecedorCertificacaoDTO request)
        {
            var updated = await _service.UpdateAsync(id, request);
            if (updated == null) return NotFound(new { message = "Certificação não encontrada." });
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(long id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound(new { message = "Certificação não encontrada." });
            return NoContent();
        }
    }
}
