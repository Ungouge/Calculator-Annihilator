using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace AnnihilatorWindowBase
{
    abstract public class Annihilator_Window_Base : Window
    {
        protected abstract string[] Styled_Elements_List { get; }

        protected abstract void Set_Element_Base_Style();

        protected abstract void Set_Element_Default_Style();

        protected abstract void Set_Styles();
    }
}
