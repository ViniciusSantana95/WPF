using System.Windows.Controls;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.UserControls
{
    public partial class ucListarProdutos : UserControl
    {
        
        private ucListarProdutos(IObserver observer)
        {
            InitializeComponent();
            DataContext = new ListarProdutosViewModel(this, observer);
        }

        internal static void Exibir(IObserver observer)
        {
            (new ucListarProdutos(observer).DataContext as ListarProdutosViewModel)
                .Notify();
        }


    }


}