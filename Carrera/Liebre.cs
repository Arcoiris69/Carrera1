using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera
{
    class Liebre : Animal
    {

        private static Random aleat = new Random();

        public override int Correr()
        {
            _pasos = 0;
            _position = 0;
            _pasos = aleat.Next(1, 11);
            if (_pasos <= 2)
            {
                _position += 0;
            }
            else if (_pasos > 2 && _pasos <= 4)
            {
                _position += 9;
            }
            else if (_pasos == 5)
            {
                _position -= 12;
            }
            else if (_pasos > 5 && _pasos <= 8)
            {
                _position += 1;
            }
            else if (_pasos > 8 && _pasos <=10)
                _position -= 2;
            
            return _position;
        }
        
    }
}
