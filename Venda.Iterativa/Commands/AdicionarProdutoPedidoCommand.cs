using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class AdicionarProdutoPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ListarProdutosViewModel;

            if (string.IsNullOrWhiteSpace(vm.ProdutoSelecionado.Descricao))
            {
                MessageBox.Show("Selecione um produto para adicionar");
                return;
            }

            if (vm.ProdutoSelecionado.Estoque - 1.00m < 0.0m)
            {
                MessageBox.Show("Estoque não disponivel!");
                return;
            }

            vm.ProdutoSelecionado.Estoque -= 1.00m;
            vm.Pedido.Produtos.Add(vm.ProdutoSelecionado);
            vm.Pedido.Total = vm.Pedido.Produtos.Sum(x => x.Preco);
        }
    }
}