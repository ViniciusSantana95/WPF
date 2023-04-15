using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Venda.Iterativa.Classes
{
    internal abstract class AbstractCommand
        : AbstractNotifyPropertyChange, ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter) => true;
        public void RaizeCanExecuteChanged()
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        public abstract void Execute(object? parameter);
    }
}