using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDNotaFiscal.Model;

namespace TDDNotaFiscal
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> Acoes;
        private IRelogio Relogio;
        private ITabela Tabela;
        private NFDao dao;
        private SAP sap;

        public GeradorDeNotaFiscal()
        { }

        public GeradorDeNotaFiscal(NFDao _dao)
        {
            dao = _dao;
        }

        public GeradorDeNotaFiscal(NFDao _dao, SAP _sap)
        {
            this.dao = _dao;
            this.sap = _sap;
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio)
        {
            this.Acoes = acoes;
            this.Relogio = relogio;
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, ITabela tabela)
        {
            this.Acoes = acoes;
            this.Tabela = tabela;
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio, ITabela tabela)
        {
            this.Acoes = acoes;
            this.Relogio = relogio;
            this.Tabela = tabela;
        }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes) : this(acoes, new RelogioDoSistema())
        { }

        public NotaFiscal GerarNota(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * Tabela.ParaValor(pedido.ValorTotal), Relogio.Hoje());

            if (Acoes != null)
            {
                foreach (var acao in Acoes)
                {
                    acao.Executa(nf);
                }
            }

            //new NFDao().Persiste(nf);

            //dao.Persiste(nf);
            //sap.Envia(nf);

            return nf;
        }
    }
}