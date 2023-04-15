using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;
using Venda.Iterativa.UserControls;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class ListarProdutosCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            ucListarProdutos.Exibir(parameter as MainWindowViewModel);
        }
    }
}