using System;
using System.Windows;
using System.Windows.Controls;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.Model;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.UserControls
{
    public partial class ucReceber : UserControl
    {
        private ucReceber(IObserver observer, PedidoModel pedido)
        {
            InitializeComponent();
            DataContext = new ReceberViewModel(this, observer, pedido);
        }

        internal static PedidoModel Exibir(IObserver observer,
            PedidoModel pedido)
        {
            var tela = new ucReceber(observer, pedido);
            var vm = tela.DataContext as ReceberViewModel;

            vm.Notify();

            return vm.Pedido;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NCartao.Text) || string.IsNullOrEmpty(Data_Validade.Text) || string.IsNullOrEmpty(CVV.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos para finalizar a compra.");
            }
            else
            {
                MessageBox.Show("Compra finalizada com sucesso!");

                //Fechar o UserControl atual
                UserControl userControlAtual = this.Parent as UserControl;
                Grid gridPai = userControlAtual.Parent as Grid;
                gridPai.Children.Remove(userControlAtual);

                //Chamar o UserControl inicial
                UserControl userControlInicial = new ucListarProdutos();
                gridPai.Children.Add(userControlInicial);
            }
        }
    }
}