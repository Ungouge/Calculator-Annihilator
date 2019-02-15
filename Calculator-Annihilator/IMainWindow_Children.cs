namespace Calculator_Annihilator
{
    interface IMainWindow_Children
    {
        MainWindow Parent_MainWindow { get; set; }

        void Push_Set_Text(Standard_Messages standard_Messages);
    }
}
