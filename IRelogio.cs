using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDNotaFiscal
{
    public interface IRelogio
    {
        DateTime Hoje();
    }

    public class RelogioDoSistema : IRelogio
    {
        public DateTime Hoje()
        {
            return DateTime.Now;
        }
    }
}