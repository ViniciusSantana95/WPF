using System;
using System.Linq;
using System.Security.Claims;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
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
            if (NCartao.Text.Length < 16)
            {
                MessageBox.Show("Número do cartão precisa ter 16 digitos");
            }
            else if (CVV.Text.Length < 3)
            {
                MessageBox.Show("CVV deve conter 3 digitos");
            }else if(string.IsNullOrEmpty(NCartao.Text) || string.IsNullOrEmpty(Data_Validade.Text) || string.IsNullOrEmpty(CVV.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos para finalizar a compra.");
            }else if(!CVV.Text.All(char.IsDigit) || !NCartao.Text.All(char.IsDigit))
            {
                MessageBox.Show("O Número do cartão e CVV deve possuir apenas números");
            }
            else
            {
                MessageBox.Show("Compra finalizada com sucesso!");
            }
        }

        private void Data_Validade_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Data_Validade.SelectedDate != null)
            {
                Data_Validade.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FD0"));
            }
            else
            {
                Data_Validade.Foreground = Brushes.Black; // cor padrão
            }
        }

    }
}