using System;
using System.Windows.Input;

namespace Options_Window_Library
{
    partial class Item_Numeral_System_List
    {
        private class Item_Numeral_System_Button_Command : ICommand
        {
            internal Item_Numeral_System_List Item_Numeral_System_List;

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            internal Item_Numeral_System_Button_Command(Item_Numeral_System_List _Item_Numeral_System_List)
            {
                Item_Numeral_System_List = _Item_Numeral_System_List;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                Item_Numeral_System_List.Numeral_System_Item_Button_Action();
            }
        }
    }
}
