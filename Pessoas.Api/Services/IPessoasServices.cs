using Pessoas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pessoas.Api.Services
{
    public interface IPessoasServices
    {
        Task<IEnumerable<Pessoa>> ListAsync();
        Task<Pessoa> GetById(int id);
        void AddAsync(Pessoa pessoa);
        Task Update(Pessoa pessoa);
        Task Remove(int id);
    }
}
