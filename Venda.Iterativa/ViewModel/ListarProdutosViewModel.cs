using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Commands;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.Model;

namespace Venda.Iterativa.ViewModel
{
    internal sealed class ListarProdutosViewModel : AbstractViewModel
    {
        #region variaveis privadas

        private const string C_DESCRICAO = "Sed sed enim vehicula, " +
            "placerat enim ac, rutrum augue. Fusce tristique lacus " +
            "tempus mattis convallis. Duis ac ultrices ex, " +
            "sed ullamcorper leo. Etiam cursus consectetur sodales. " +
            "Suspendisse congue nibh sed vestibulum interdum." +
            " Duis convallis mauris sit amet justo fermentum aliquam." +
            " Vestibulum congue pretium pharetra. Donec laoreet risus eu mattis " +
            "congue. Pellentesque pulvinar finibus sagittis. Aliquam turpis ante," +
            " luctus et magna quis, feugiat facilisis augue. Curabitur rutrum" +
            " lorem at bibendum pellentesque. Nullam rhoncus, augue id imperdiet" +
            " aliquam, nibh nisl gravida felis, interdum sagittis lacus augue" +
            " non neque. Orci varius natoque penatibus et magnis dis parturient" +
            " montes, nascetur ridiculus mus.";

        private ProdutoModel _produtoSelecionado = new ProdutoModel();
        private PedidoModel _pedido = new PedidoModel();
        private ObservableCollection<ProdutoModel> _produtos 
            =  new ObservableCollection<ProdutoModel>();

        #endregion variaveis privadas

        #region propriedades

        public ObservableCollection<ProdutoModel> Produtos 
        { 
            get => _produtos; 
            set => SetField(ref _produtos, value);
        }

        public PedidoModel Pedido
        {
            get => _pedido;
            set => SetField(ref _pedido, value);
        }

        public ProdutoModel ProdutoSelecionado
        {
            get => _produtoSelecionado;
            set => SetField(ref _produtoSelecionado, value);
        }

        #endregion propriedades

        #region comandos

        public AdicionarProdutoPedidoCommand Adicionar { get; private set; }
            = new AdicionarProdutoPedidoCommand();

        public ReceberPedidoCommand Receber { get; private set; }
            = new ReceberPedidoCommand();

        #endregion comandos

        #region construtores

        public ListarProdutosViewModel(UserControl userControl,
            IObserver observer) : base("Lista de Produtos") 
        {
            UserControl = userControl;
            MainUserControl = observer;

            Add(observer);
            CarregarProdutos();
        }

        #endregion construtores

        #region metodos

        private void CarregarProdutos()
        {
            Produtos.Clear();

            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\batata.png", UriKind.Relative)),
                Referencia = "Batata",
                Descricao = C_DESCRICAO,
                Estoque = 100.00m,
                Preco = 8.90m,
            });
            
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\combo.png", UriKind.Relative)),
                Referencia = "Combo",
                Descricao = C_DESCRICAO,
                Estoque = 100.00m,
                Preco = 38.90m,
            });
            
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\lanche.jpg", UriKind.Relative)),
                Referencia = "Lanche",
                Descricao = C_DESCRICAO,
                Estoque = 100.00m,
                Preco = 19.90m,
            });
            
            Produtos.Add(new ProdutoModel()
            {
                Imagem = new BitmapImage(
                    new Uri(@"..\net6.0-windows\Imagens\refrigerante.png", UriKind.Relative)),
                Referencia = "Refrigerante",
                Descricao = C_DESCRICAO,
                Estoque = 1.00m,
                Preco = 4.50m,
            });
        }

        #endregion metodos
    }
}