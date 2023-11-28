using Microsoft.EntityFrameworkCore;
using Req231123_V1.Context;
using Req231123_V1.Controllers;
using Req231123_V1.Repositories.Interfaces;
using Req231123_V1.Models;

namespace Req231123_V1.Repositories
{
    public class RequisicaoRepository : IRequisicaoRepository
    {
        private readonly AppDbContext _context;

        public RequisicaoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }


        public IEnumerable<Requisicao> Requisicaos => _context.Requisicao.Include(c => c.Produtos);  

        public IEnumerable<Requisicao> Data => _context.Requisicao.Include(c => c.Produtos);

        public Requisicao GetRequisicaoById(int RequisicaoId)
        {
            throw new NotImplementedException();
        }


        //public Requisicao GetRequisicaoById(int RequisicaoId)
        //{
        //return _context.Requisicao.FirstOrDefault(1 => 1.RequisicaoID == RequisicaoId);
        //}
    }
}