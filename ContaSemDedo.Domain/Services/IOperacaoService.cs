using ContaSemDedo.Domain.Entities;

namespace ContaSemDedo.Domain.Services
{
    public interface IOperacaoService
    {
        public List<Operacao> RetornaTodasOperacoes();
        public Operacao RetornaAOperacao(int id);

        public void AdicionarOperacao (Operacao operacao);
        public void DeletarOperacao(int id);
    }
}