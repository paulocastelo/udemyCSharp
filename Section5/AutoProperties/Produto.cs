using System.Globalization;
namespace AutoProperties
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        private int Quantidade { get; private set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
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

        //public double Preco
        //{
        //    get { return Preco; }
        //}

        //public int Quantidade
        //{
        //    get { return Quantidade; }
        //}
        /* O GET E SET FORAM SUBSTITUÍDOS PELA PROPERTIES
        public double GetPreco() { return Preco; }
        
        public int GetQuantidade() { return Quantidade; }

        public string GetNome() { return _nome; }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
                _nome = nome;
        }
        */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}