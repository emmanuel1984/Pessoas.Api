using Pessoas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pessoas.Api.Data.Repository
{
    public interface IPessoasRepository
    {
        Task<IEnumerable<Pessoa>> ListAsync();

        Task AddAsync(Pessoa pessoa);

        Task<Pessoa> FindByIdAsync(int id);

        void Update(Pessoa pessoa);

        void Remove(Pessoa pessoa);
    }
}
