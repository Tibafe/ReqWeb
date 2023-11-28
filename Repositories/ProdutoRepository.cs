using Req231123_V1.Context;
using Req231123_V1.Models;
using Req231123_V1.Repositories.Interfaces;

namespace Req231123_V1.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produto;
    }
}
