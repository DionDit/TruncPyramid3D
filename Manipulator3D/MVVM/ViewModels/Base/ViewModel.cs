using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Manipulator3D.MVVM.ViewModels.Base
{
    /// <summary>
    /// Базовый класс ViewModel.
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие для оповещения при изменения данных.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод для вызова события изменения данных.
        /// </summary>
        /// <param name="PropertyName"></param>
        public virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Изменение данных.
        /// </summary>
        public virtual bool Set<T>(ref T Field, T Value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(Field, Value))
            {
                return false;
            }
            else
            {
                Field = Value;
                OnPropertyChanged(PropertyName);
                return true;
            }
        }
    }
}