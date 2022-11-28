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
        private NFDao dao;
        private SAP sap;

        public GeradorDeNotaFiscal()
        {
        }

        public GeradorDeNotaFiscal(NFDao _dao)
        {
            dao = _dao;
        }

        public GeradorDeNotaFiscal(NFDao _dao, SAP _sap)
        {
            this.dao = _dao;
            this.sap = _sap;
        }

        public NotaFiscal GerarNota(Pedido pedido)
        {
            NotaFiscal nf = new NotaFiscal(pedido.Cliente, pedido.ValorTotal * 0.94, DateTime.Now);

            //new NFDao().Persiste(nf);

            //dao.Persiste(nf);
            //sap.Envia(nf);

            return nf;
        }
    }
}