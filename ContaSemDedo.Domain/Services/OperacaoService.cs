using ContaSemDedo.Domain.Entities;

namespace ContaSemDedo.Domain.Services
{
    public class OperacaoService : IOperacaoService

    {
        private List<Operacao> operacoes = new();

        public void AdicionarOperacao(Operacao operacao)
        {
            operacao.Id = operacoes.Max(o => o.Id) + 1;

            operacoes.Add(operacao);
        }

        public void DeletarOperacao(int id)
        {
            operacoes.RemoveAll(o => o.Id == id);
        }

        public Operacao RetornaAOperacao(int id)
        {
            return operacoes.FirstOrDefault(o => o.Id == id) ?? new Operacao();
        }

        public List<Operacao> RetornaTodasOperacoes()
        {
            return operacoes;
        }
    }
}