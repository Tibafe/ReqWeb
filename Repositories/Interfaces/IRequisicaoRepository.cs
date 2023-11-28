using Req231123_V1.Controllers;

namespace Req231123_V1.Repositories.Interfaces
{
    public interface IRequisicaoRepository
    {
        IEnumerable<Requisicao> Requisicaos { get; }
        IEnumerable<Requisicao> Data { get; }
        Requisicao GetRequisicaoById (int RequisicaoId);
    }
}
