using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ZoomExample.Common
{
    public class RelayCommand : ICommand
    {
        private Action<object, RoutedEventArgs> addImageClick_Loaded;
        private RelayCommand imageDown;

        public Action<object> MyAction { get; set; }

        public RelayCommand(Action<object> MyAction)
        {
            this.MyAction = MyAction;
        }

        public RelayCommand(Action<object, RoutedEventArgs> addImageClick_Loaded)
        {
            this.addImageClick_Loaded = addImageClick_Loaded;
        }

        public RelayCommand(RelayCommand imageDown)
        {
            this.imageDown = imageDown;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MyAction(parameter);
        }
    }
}
