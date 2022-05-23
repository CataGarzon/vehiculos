using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    internal class colectivos:carro
    {

        private string colorPlaca;
        public string ColorPlaca
        {
            get { return colorPlaca; }
            set { colorPlaca = value; }
        }

        private string tipoServicio;
        public string TipoServicio
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }
    }
}
