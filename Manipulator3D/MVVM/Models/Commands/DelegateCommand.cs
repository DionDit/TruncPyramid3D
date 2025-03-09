using Manipulator3D.MVVM.Models.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulator3D.MVVM.Models.Commands
{
    /// <summary>
    /// Класс реализующий команду.
    /// </summary>
    public class DelegateCommand : Command
    {
        /// <summary>
        /// Выполнение команды.
        /// </summary>
        private readonly Action<object> _Execute;

        /// <summary>
        /// Выполнение команды с условием.
        /// </summary>
        private readonly Func<object, bool> _CanExecute;

        /// <summary>
        /// Конструктор класса <see cref="DelegateCommand"./>
        /// </summary>
        public DelegateCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
        }

        /// <summary>
        /// Выполнение команды.
        /// </summary>
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        /// <summary>
        /// Выполнение команды с условием.
        /// </summary>
        public override void Execute(object parameter) => _Execute.Invoke(parameter);
    }
}