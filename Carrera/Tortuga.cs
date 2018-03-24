using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Tortuga : Animal
    {
        private static Random aleat = new Random();

        public override int Correr()
        {
            _position = 0;
            _pasos = 0;
            _pasos = aleat.Next(1,11);

            if (_pasos <= 5)
                {
                    _position += 3;
                }
                else if (_pasos > 5 && _pasos <= 7 )
                {
                    _position -= 6;
                }
                else if (_pasos > 7 && _pasos <= 10)
                {
                    _position += 1;
                }
            
            return _position;
        }
    }
}
