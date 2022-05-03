using Pessoas.Api.Data.Repository;
using Pessoas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pessoas.Api.Services
{
    public class PessoasService : IPessoasServices
    {
        private readonly IPessoasRepository _pessoaRepository;

        public PessoasService(IPessoasRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task<Pessoa> GetById(int id)
        {
            return await _pessoaRepository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _pessoaRepository.ListAsync();
        }

        public void AddAsync(Pessoa pessoa)
        {
           _pessoaRepository.AddAsync(pessoa);
        }

        public async Task Update(Pessoa item)
        {
            var pessoa = await _pessoaRepository.FindByIdAsync(item.Id);

            if (pessoa != null)
            {
                pessoa.Id = item.Id;
                pessoa.Nome = item.Nome;
                pessoa.DataNascimento = item.DataNascimento;
                pessoa.CPF = item.CPF;
                pessoa.StatusPessoa = item.StatusPessoa;
            }

            _pessoaRepository.Update(pessoa);
        }

        public async Task Remove(int id)
        {
            var pessoa = await _pessoaRepository.FindByIdAsync(id);
            _pessoaRepository.Remove(pessoa);
        }
    }
}
