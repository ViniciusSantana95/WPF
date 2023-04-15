using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Venda.Iterativa.Classes;
using Venda.Iterativa.Commands;
using Venda.Iterativa.Interfaces;

namespace Venda.Iterativa.ViewModel
{
    internal class MainWindowViewModel : AbstractViewModel, IObserver
    {
        #region variaveis privadas

        private UserControl _userControl;

        #endregion variaveis privadas

        #region propriedades

        public UserControl UserControl 
        { 
            get => _userControl;
            set => SetField(ref _userControl, value);
        }

        #endregion propriedades

        #region comandos

        public ListarProdutosCommand ListarProdutos { get; private set; }
            = new ListarProdutosCommand();

        #endregion comandos

        public MainWindowViewModel() : base("UMFG | Home") { }

        public void Update(ISubject subject)
        {
            if (subject is ListarProdutosViewModel)
                UserControl = (subject as ListarProdutosViewModel).UserControl;

            if (subject is ReceberViewModel)
                UserControl = (subject as ReceberViewModel).UserControl;
        }
    }
}