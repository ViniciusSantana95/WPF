﻿using System;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.UserControls;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class ReceberPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            try
            {
                var vm = parameter as ListarProdutosViewModel;

                if(vm.Pedido.Produtos.Count == 0)
                {
                    MessageBox.Show("Não foi adicionado nenhum produto");  
                }
                else 
                {
                    if(MessageBox.Show("Deseja prosseguir para o pagamento ?","Foi adicionado: " + vm.Pedido.Produtos.Count + " itens no carrinho", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                    }
                    else
                    {
                        vm.Pedido = ucReceber.Exibir(vm.MainUserControl, vm.Pedido);
                    }
                    
                    

                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}