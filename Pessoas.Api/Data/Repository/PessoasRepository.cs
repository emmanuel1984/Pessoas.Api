using Microsoft.EntityFrameworkCore;
using Pessoas.Api.Data.Context;
using Pessoas.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pessoas.Api.Data.Repository
{
    public class PessoasRepository : BaseRepository, IPessoasRepository
    {
        public PessoasRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _context.Pessoa.ToListAsync();
        }

        public async Task AddAsync(Pessoa pessoa)
        {
            await _context.Pessoa.AddAsync(pessoa);
            await _context.SaveChangesAsync();
        }
        public async Task<Pessoa> FindByIdAsync(int id)
        {
            return await _context.Pessoa.FindAsync(id);
        }
        public async void Remove(Pessoa pessoa)
        {
             _context.Pessoa.Remove(pessoa);
             _context.SaveChanges();
        }
        public async void Update(Pessoa pessoa)
        {
            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();
        }
    }
}
