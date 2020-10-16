using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Titular
    {
        private string _nome;
        
        public Titular (string nome)
        {
            _nome = nome;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }
    }
}
