using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
    public class SuperClaseVehiculos
    {
        private string NombreVehiculo;
      
        public string TipoMotor;

        public int NumeroPersonas;

        public SuperClaseVehiculos (string NombreTipoVehiculo, string TipoMotor, int NumeroPersonas)
        {
            this.NombreVehiculo = NombreTipoVehiculo;
            this.TipoMotor = TipoMotor;
            this.NumeroPersonas = NumeroPersonas;
        }
        public string getNombreVehiculo()
        {
            return NombreVehiculo;
        }
        public void setNombreVehiculo(string nombre)
        {
            this.NombreVehiculo = NombreVehiculo;

        }
        public string getTipoMotor()
        {
            return TipoMotor;

        }
        public void setTipoMotor(string TipoMotor)
        {
            this.TipoMotor = TipoMotor;
        }
        public int getNumeroPersonas()
        {
            return NumeroPersonas;

        }
        public void setApellido(int NumeroPersonas)
        {
            this.NumeroPersonas = NumeroPersonas;
        }


    }
}
