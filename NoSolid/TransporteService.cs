using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSolid
{
    public class TransporteService
    {
        private ITransporte transporte;

        public TransporteService(ITransporte transporte)
        {
            this.transporte = transporte;
        }

        public void MoverTransporte()
        {
            transporte.Mover();
        }

        public void GuardarTransporte()
        {
            transporte.GuardarEnBD();
        }
    }
}
