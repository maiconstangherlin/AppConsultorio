using Core.Domain;
using Core.Shared.ModelViews;
using Manager.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager clienteManager;

        public ClientesController(IClienteManager clienteManager)
        {
            this.clienteManager = clienteManager;
        }

        // GET: api/<ClientesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await clienteManager.GetClientesAsync());
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await clienteManager.GetClienteAsync(id));
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NovoCliente novoCliente)
        {
            var clienteInserido = await clienteManager.InsertClienteAsync(novoCliente);
            return CreatedAtAction(nameof(Get), new { id = clienteInserido.Id }, clienteInserido);
        }

        // PUT api/<ClientesController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AlteraCliente alteraCliente)
        {
            var clienteAtualizado = await clienteManager.UpdateClienteAsync(alteraCliente);
            if (clienteAtualizado == null)
                return NotFound();

            return Ok(clienteAtualizado);
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await clienteManager.DeleteAsync(id);
            return NoContent();
        }
    }
}
