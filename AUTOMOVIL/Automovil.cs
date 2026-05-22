using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMULADOR_DE_AUTOMÓVIL
{
    internal class Automovil
    {
        private string _marca;
        private bool _motorEncendido;
        private int _velocidadActual;
        private bool _cajaAutomatica;
        private bool _modoCrucero;

        // PROPIEDADES (GET Y SET)
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public bool MotorEncendido
        {
            get { return _motorEncendido; }
            set { _motorEncendido = value; }
        }

        public int VelocidadActual
        {
            get { return _velocidadActual; }
            set { _velocidadActual = value; }
        }

        public bool CajaAutomatica
        {
            get { return _cajaAutomatica; }
            set { _cajaAutomatica = value; }
        }

        public bool ModoCrucero
        {
            get { return _modoCrucero; }
            set { _modoCrucero = value; }
        }

    }
}
