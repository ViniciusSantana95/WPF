using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Interfaces;
using Venda.Iterativa.Model;

namespace Venda.Iterativa.ViewModel
{
    internal sealed class ReceberViewModel : AbstractViewModel
    {
        private PedidoModel _pedido = new PedidoModel();

        public PedidoModel Pedido
        {
            get => _pedido;
            set => SetField(ref _pedido, value);
        }

        public ReceberViewModel(UserControl userControl, IObserver observer,
            PedidoModel pedido) : base("UMFG | Receber")
        {
            UserControl = userControl;
            MainUserControl = observer;
            Pedido = pedido ?? throw new ArgumentNullException(nameof(pedido));

            Add(observer ?? throw new ArgumentNullException(nameof(observer)));
        }
    }
}