using Microsoft.AspNetCore.Mvc;
using Pessoas.Api.Models;
using Pessoas.Api.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pessoas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoasServices _pessoasService;
        public PessoasController(IPessoasServices pessoaService)
        {
            _pessoasService = pessoaService;
        }

        [HttpGet]
        public async Task<IEnumerable<Pessoa>> GetAllAsync()
        {
            var pessoa = await _pessoasService.ListAsync();
            return pessoa;
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest();
            }
            _pessoasService.AddAsync(pessoa);
            
            return CreatedAtRoute("", new { Controller = "Pessoas", id = pessoa.Nome }, pessoa);
        }

        [HttpDelete]
        public async Task Deletar(int id)
        {
            await _pessoasService.Remove(id);
        }

        [HttpPut]
        public async Task Atualizar([FromBody] Pessoa pessoa)
        {
            await _pessoasService.Update(pessoa);
        }

        //[HttpGet]
        //public async Task<Pessoa> GetByPessoaID(int id)
        //{
        //    return await _pessoasService.GetById(id);
        //}
    }
}
