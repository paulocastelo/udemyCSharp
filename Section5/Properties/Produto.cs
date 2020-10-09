using System.Globalization;
namespace AutoProperties
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }

        public string Nome
        {
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
            get { return _nome; }
        }
        
        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        /* O GET E SET FORAM SUBSTITUÍDOS PELA PROPERTIES
        public double GetPreco() { return _preco; }
        
        public int GetQuantidade() { return _quantidade; }

        public string GetNome() { return _nome; }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
                _nome = nome;
        }
        */

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}