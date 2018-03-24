using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    abstract class Animal 
    {
        protected static int _pasos = 0;
        public int pasos = _pasos;
        protected static int _position = 0;
        public int posicion = _position;


        public abstract int Correr();

    }

}
