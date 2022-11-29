using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDNotaFiscal.Model;

namespace TDDNotaFiscal
{
    public interface IAcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}