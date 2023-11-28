using Req231123_V1.Models;

namespace Req231123_V1.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}
