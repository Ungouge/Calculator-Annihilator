using System;
using System.Windows.Input;

namespace Options_Window_Library
{
    partial class Add_New_Comma_Type_List_Item
    {
        private class Add_New_Comma_Type_Button_Command : ICommand
        {
            private Comma_Type_List_Context Comma_Type_List_Context;

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            internal Add_New_Comma_Type_Button_Command(Comma_Type_List_Context _Comma_Type_List_Context)
            {
                Comma_Type_List_Context = _Comma_Type_List_Context;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                if (parameter != null)
                {
                    if (parameter is string parameter_String)
                    {
                        if (String.IsNullOrWhiteSpace(parameter_String))
                            return;

                        foreach (string comma_Type in Comma_Type_List_Context.Commas_Type)
                            if (parameter_String == comma_Type)
                                return;

                        Comma_Type_List_Context.Add_New_Comma_Type(parameter.ToString());
                    }
                }

                return ;
            }
        }
    }
}