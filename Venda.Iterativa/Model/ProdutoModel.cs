using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Venda.Iterativa.Classes;

namespace Venda.Iterativa.Model
{
    internal sealed class ProdutoModel : AbstractModel
    {
        #region variaveis privadas

        private ImageSource _imagem;
        private string _referencia;
        private string _descricao;
        private decimal _estoque;
        private decimal _preco;

        #endregion variaveis privadas

        #region propriedades

        public ImageSource Imagem
        {
            get => _imagem;
            set => SetField(ref _imagem, value);
        }

        public string Referencia
        {
            get => _referencia;
            set => SetField(ref _referencia, value);
        }

        public string Descricao
        {
            get => _descricao;
            set => SetField(ref _descricao, value);
        }

        public decimal Estoque
        {
            get => _estoque;
            set => SetField(ref _estoque, value);
        }

        public decimal Preco
        {
            get => _preco;
            set => SetField(ref _preco, value);
        }

        #endregion propriedades
    }
}