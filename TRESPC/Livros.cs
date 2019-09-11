using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRESPC
{
    class Livros
    {
        private string _nome;
        private double _preco;
        private int _numeroDePaginas;

        public Livros()
        {
           
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
        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value >= 0.01)
                    _preco = value;
            }
        }
        public int NumeroDePaginas
        {
            get { return _numeroDePaginas; }
            set
            {
                if (_numeroDePaginas + value > 0)
                    _numeroDePaginas = value;
            }
        }
    }
}
